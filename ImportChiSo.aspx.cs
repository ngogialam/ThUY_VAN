using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using NPOI.HSSF.UserModel;

public partial class ImportChiSo : System.Web.UI.Page
{
    clsConnect myCon = new clsConnect();
    clsNhapChiSo myNCS = new clsNhapChiSo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            drpKy.DataSource = myNCS.get_danhsach_ky();
            drpKy.DataBind();
            pnlResults.Visible = false;
        }
    }

    protected void btnImport_Click(object sender, EventArgs e)
    {
        if (!fileUpload.HasFile)
        {
            ShowError("Vui lòng chọn file Excel để import.");
            return;
        }

        string ky = drpKy.SelectedItem.ToString();
        if (string.IsNullOrEmpty(ky))
        {
            ShowError("Vui lòng chọn kỳ import.");
            return;
        }

        string fileName = Path.GetFileName(fileUpload.FileName);
        string fileExtension = Path.GetExtension(fileName).ToLower();

        if (fileExtension != ".xls")
        {
            ShowError("Chỉ chấp nhận file Excel .xls");
            return;
        }

        try
        {
            ProcessExcelFile(fileUpload.FileContent, ky);
        }
        catch (Exception ex)
        {
            ShowError("Lỗi khi xử lý file: " + ex.Message);
        }
    }

    private void ProcessExcelFile(Stream fileStream, string ky)
    {
        HSSFWorkbook workbook = null;

        try
        {
            workbook = new HSSFWorkbook(fileStream);

            HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);
            if (sheet == null)
            {
                ShowError("Không tìm thấy sheet trong file Excel.");
                return;
            }

            List<ImportError> errors = new List<ImportError>();
            int successCount = 0;
            int totalRows = 0;
            string id_doanh_nghiep = myCon.get_iddoanhnghiep(HttpContext.Current.User.Identity.Name.ToString());

            for (int rowIndex = 2; rowIndex <= sheet.LastRowNum; rowIndex++)
            {
                HSSFRow row = (HSSFRow)sheet.GetRow(rowIndex);
                if (row == null) continue;

                HSSFCell cellMeterSerial = (HSSFCell)row.GetCell(2);
                HSSFCell cellReading = (HSSFCell)row.GetCell(4);

                if (cellMeterSerial == null || string.IsNullOrWhiteSpace(GetCellValue(cellMeterSerial)))
                {
                    continue;
                }

                totalRows++;

                string meterSerial = GetCellValue(cellMeterSerial).Trim();
                string readingStr = GetCellValue(cellReading);

                if (string.IsNullOrWhiteSpace(readingStr))
                {
                    errors.Add(new ImportError
                    {
                        RowNumber = rowIndex + 1,
                        MeterSerial = meterSerial,
                        Reading = "",
                        ErrorMessage = "Chỉ số trống"
                    });
                    continue;
                }

                int reading = ParseReading(readingStr);
                if (reading < 0)
                {
                    errors.Add(new ImportError
                    {
                        RowNumber = rowIndex + 1,
                        MeterSerial = meterSerial,
                        Reading = readingStr,
                        ErrorMessage = "Chỉ số không hợp lệ"
                    });
                    continue;
                }

                int result = myNCS.import_chi_so_from_excel(meterSerial, reading.ToString(), ky, id_doanh_nghiep);

                if (result > 0)
                {
                    successCount++;
                }
                else
                {
                    errors.Add(new ImportError
                    {
                        RowNumber = rowIndex + 1,
                        MeterSerial = meterSerial,
                        Reading = reading.ToString(),
                        ErrorMessage = "Không tìm thấy công tơ trong hệ thống hoặc lỗi cập nhật"
                    });
                }
            }

            ShowResults(totalRows, successCount, errors);
        }
        finally
        {
        }
    }

    private string GetCellValue(HSSFCell cell)
    {
        if (cell == null) return string.Empty;

        try
        {
            int cellType = (int)cell.CellType;
            
            if (cellType == 1)
            {
                return cell.StringCellValue;
            }
            else if (cellType == 0)
            {
                return cell.NumericCellValue.ToString();
            }
            else if (cellType == 4)
            {
                return cell.BooleanCellValue.ToString();
            }
            else if (cellType == 2)
            {
                try
                {
                    return cell.NumericCellValue.ToString();
                }
                catch
                {
                    try
                    {
                        return cell.StringCellValue;
                    }
                    catch
                    {
                        return string.Empty;
                    }
                }
            }
            else
            {
                return string.Empty;
            }
        }
        catch
        {
            return string.Empty;
        }
    }

    private int ParseReading(string readingStr)
    {
        try
        {
            readingStr = readingStr.Trim().Replace(",", ".");
            
            if (readingStr.Contains("."))
            {
                string[] parts = readingStr.Split('.');
                return int.Parse(parts[0]);
            }
            else
            {
                double value = double.Parse(readingStr);
                return (int)Math.Floor(value);
            }
        }
        catch
        {
            return -1;
        }
    }

    private void ShowResults(int totalRows, int successCount, List<ImportError> errors)
    {
        pnlResults.Visible = true;
        lblTotalRows.Text = totalRows.ToString();
        lblSuccessCount.Text = successCount.ToString();
        lblErrorCount.Text = errors.Count.ToString();

        if (errors.Count > 0)
        {
            pnlErrors.Visible = true;
            gvErrors.DataSource = errors;
            gvErrors.DataBind();
        }
        else
        {
            pnlErrors.Visible = false;
        }
    }

    private void ShowError(string message)
    {
        pnlResults.Visible = true;
        lblTotalRows.Text = "0";
        lblSuccessCount.Text = "0";
        lblErrorCount.Text = "1";
        
        pnlErrors.Visible = true;
        List<ImportError> errors = new List<ImportError>();
        errors.Add(new ImportError
        {
            RowNumber = 0,
            MeterSerial = "",
            Reading = "",
            ErrorMessage = message
        });
        gvErrors.DataSource = errors;
        gvErrors.DataBind();
    }

    public class ImportError
    {
        public int RowNumber { get; set; }
        public string MeterSerial { get; set; }
        public string Reading { get; set; }
        public string ErrorMessage { get; set; }
    }
}

