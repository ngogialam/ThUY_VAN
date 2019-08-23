using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using ClosedXML.Excel;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.UI.HtmlControls;
public partial class ChiSoCongToTong : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    clsConnect myCon = new clsConnect();
    clsNhapChiSo myNCS = new clsNhapChiSo();
    DataTable CusList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            drpKy.DataSource = myNCS.get_danhsach_ky();
            drpKy.DataBind();

            ddlKyCu.DataSource = myNCS.get_danhsach_ky();
            ddlKyCu.DataBind();
            lblErr.Text = "";
        }

    }

    protected void gv_bind(string kyhd)
    {
        CusList = myNCS.get_danh_sach_nhap_cs_tong(kyhd);
        GirdViewNoPaGE.DataSource = CusList;
        GirdViewNoPaGE.DataBind();
               if (CusList.Rows.Count > 0)
        {
            GirdViewNoPaGE.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    protected void btnLaySL_Click(object sender, EventArgs e)
    {
        string kyhd = drpKy.SelectedItem.ToString();
        gv_bind(kyhd);
    }

    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        int i = 0;
        for (i = 0; i < GirdViewNoPaGE.Rows.Count; i++)
        {
            GridViewRow row = GirdViewNoPaGE.Rows[i];
            string ky = drpKy.SelectedItem.ToString();
            Label lblmact = (Label)row.FindControl("lblMaCT");
            TextBox txtCSMoi = (TextBox)row.FindControl("txtCSMoi");
            string mact = lblmact.Text.ToString();
            string csmoi = txtCSMoi.Text.ToString();
            if (csmoi != "")
            {
                int result = myNCS.cap_nhat_chi_so_cong_to_tong(mact, csmoi, ky);
                if (result == 0)
                {
                    lblErr.Text = "Có lỗi xảy ra trong quá trình cập nhật mã công tơ " + mact;
                }
            }

        }
    }

    protected void ThemKyHD(object sender, EventArgs e)
    {
        string tungay = Request.Form["strTuNgay"].ToString();
        string denngay = Request.Form["strDenNgay"].ToString();
        string kyhd = Request.Form["strKyHD"].ToString();
        int i = 0;
        if (tungay != "-1" && denngay != "-1")
        {

            int inttungay = Convert.ToInt32(tungay);
            int intdenngay = Convert.ToInt32(denngay);
            if (inttungay > intdenngay)
            {
                txtErr.Text = "Thời gian từ ngày phải nhỏ hơn đến ngày";

            }
            else
            {

                string tungay1 = tungay.Substring(0, 4) + "-" + tungay.Substring(4, 2) + "-" + tungay.Substring(6, 2);
                string denngay1 = denngay.Substring(0, 4) + "-" + denngay.Substring(4, 2) + "-" + denngay.Substring(6, 2);
                string thang = kyhd.Substring(0, 2);
                int intthang = Convert.ToInt32(thang) + 1;
                if (intthang < 10)
                {
                    thang = "0" + intthang.ToString();
                }
                string nam = kyhd.Substring(3, 4);
                kyhd = thang + "/" + nam;
                int result = myNCS.them_kyhd(kyhd, thang, nam, tungay1, denngay1);
                if (result == 1)
                {
                    string kycu = ddlKyCu.SelectedItem.ToString();
                    CusList = myNCS.get_danh_sach_nhap_cs_tong(kycu);
                    for (i = 0; i < CusList.Rows.Count; i++)
                    {

                        string mact = CusList.Rows[i]["ma_cong_to"].ToString();
                        string csmoi = CusList.Rows[i]["cs_moi"].ToString();
                        if (csmoi != "")
                        {
                            if (myNCS.check_cs_ct_tong(mact, kyhd) < 1)
                            {
                                result = myNCS.them_chi_so_cong_to_tong_ky_moi(mact, csmoi, kyhd);
                                if (result ==0)
                                {                                   
                                    lblErr.Text = "Có lỗi xảy ra trong quá trình khởi tạo dữ liệu kỳ sau mã công tơ " + mact;
                                    break;
                                }
                            }
                        }

                    }
                }
                if (result == 1)
                {
                    Response.Redirect("ChiSoCongToTong.aspx");
                }
                
            }
        }

    }

    protected void btnXuatExcel_Click(object sender, EventArgs e)
    {
        int j;
        MemoryStream mem = new MemoryStream();
        int rowNo;
        int colNo;

        FileStream file = new FileStream(Server.MapPath("xls/ChiSoCongToTong.xls"), FileMode.Open, FileAccess.Read);
        //HSSFWorkbook hwbook = new HSSFWorkbook(file);
        //HSSFRow row;
        //HSSFCell cell;
        //HSSFSheet hsheet;

        //HSSFFont font;
        //font = hwbook.CreateFont();
        //font.FontName = "Times New Roman";
        //font.Boldweight = HSSFFont.BOLDWEIGHT_BOLD;
        //font.FontHeight = 220;
        //hsheet = hwbook.GetSheet("Sheet1");
        //HSSFCellStyle styleleftnoborder;
        //styleleftnoborder = hwbook.CreateCellStyle();
        //styleleftnoborder.Alignment = HSSFCellStyle.ALIGN_LEFT;
        //styleleftnoborder.SetFont(font);
        //HSSFCellStyle stylecenternoborder;
        //stylecenternoborder = hwbook.CreateCellStyle();
        //stylecenternoborder.Alignment = HSSFCellStyle.ALIGN_CENTER;
        //stylecenternoborder.SetFont(font);
        //rowNo = 0;
        //colNo = 0;
        //row = hsheet.CreateRow(rowNo);
        //cell = row.CreateCell(colNo);
        //cell.SetCellValue(mConfig.cfg_ten_ban_nganh);
        //cell.CellStyle = styleleftnoborder;
        //rowNo = 1;
        //colNo = 0;
        //row = hsheet.CreateRow(rowNo);
        //cell = row.CreateCell(colNo);
        //cell.SetCellValue("ĐƠN VỊ: " + UCase(Session("VAN_BAN_TEN_DON_VI")));
        //cell.CellStyle = styleleftnoborder;

        //// CÁN BỘ
        //font = hwbook.CreateFont();
        //font.FontName = "Times New Roman";
        //font.FontHeight = 220;
        //HSSFCellStyle stylecenter;
        //stylecenter = hwbook.CreateCellStyle();
        //stylecenter.BorderTop = HSSFCellStyle.BORDER_THIN;
        //stylecenter.BorderLeft = HSSFCellStyle.BORDER_THIN;
        //stylecenter.BorderRight = HSSFCellStyle.BORDER_THIN;
        //stylecenter.BorderBottom = HSSFCellStyle.BORDER_THIN;
        //stylecenter.Alignment = HSSFCellStyle.ALIGN_CENTER;
        //stylecenter.SetFont(font);
        //HSSFCellStyle styleleft;
        //styleleft = hwbook.CreateCellStyle();
        //styleleft.BorderTop = HSSFCellStyle.BORDER_THIN;
        //styleleft.BorderLeft = HSSFCellStyle.BORDER_THIN;
        //styleleft.BorderRight = HSSFCellStyle.BORDER_THIN;
        //styleleft.BorderBottom = HSSFCellStyle.BORDER_THIN;
        //styleleft.Alignment = HSSFCellStyle.ALIGN_LEFT;
        //styleleft.SetFont(font);
        //rowNo = 10;
        //colNo = 0;
        //int stt = 0;
        //DataSet dts;
        //dts = myMain.getDataSet("DANHMUC.SELECT_DM_LOAI");
        //for (j = 0; j <= dts.Tables(0).Rows.Count - 1; j++)
        //{
        //    row = hsheet.CreateRow(rowNo);
        //    cell = row.CreateCell(colNo);
        //    stt = stt + 1;
        //    cell.SetCellValue(stt);
        //    cell.CellStyle = stylecenter;
        //    colNo += 1;
        //    string tenloai = dts.Tables(0).Rows(j).Item("TEN_LOAI").ToString;
        //    row = hsheet.CreateRow(rowNo);
        //    cell = row.CreateCell(colNo);
        //    cell.SetCellValue(tenloai);
        //    cell.CellStyle = styleleft;
        //    colNo += 1;
        //    string tenlinhvuc = dts.Tables(0).Rows(j).Item("TEN_LINH_VUC").ToString;
        //    row = hsheet.CreateRow(rowNo);
        //    cell = row.CreateCell(colNo);
        //    cell.SetCellValue(tenlinhvuc);
        //    cell.CellStyle = styleleft;
        //    rowNo += 1;
        //    colNo = 0;
        //}
        //rowNo += 1;
        //colNo = 2;
        //row = hsheet.CreateRow(rowNo);
        //cell = row.CreateCell(colNo);
        //cell.SetCellValue("Ngày.... tháng..... năm.....");
        //cell.CellStyle = stylecenternoborder;
        //rowNo += 1;
        //colNo = 2;
        //row = hsheet.CreateRow(rowNo);
        //cell = row.CreateCell(colNo);
        //cell.SetCellValue("Nhân viên lập");
        //cell.CellStyle = stylecenternoborder;
        //rowNo += 4;
        //colNo = 2;
        //row = hsheet.CreateRow(rowNo);
        //cell = row.CreateCell(colNo);
        //cell.SetCellValue(Session("VAN_BAN_HO_TEN"));
        //cell.CellStyle = stylecenternoborder;
        //hwbook.Write(mem);
        //Response.ContentType = "application/vnd.ms-excel";
        //Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", "LoaiVanBan.xls"));
        //Response.Clear();
        //Response.BinaryWrite(mem.GetBuffer());
        //Response.End();
    }
}