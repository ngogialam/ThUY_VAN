using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using ClosedXML.Excel;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;

public partial class BangKeTienDien : System.Web.UI.Page
{
    clsBaocao myCus = new clsBaocao();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           

            DataTable tram_bien_ap = myCus.get_tram_bien_ap();
            DataRow newRow = tram_bien_ap.NewRow();
            newRow[0] = 0;
            newRow[1] = "Tất cả";
            tram_bien_ap.Rows.InsertAt(newRow, 0);
            ddlTramBA.DataSource = tram_bien_ap;
            ddlTramBA.DataBind();

            

            DataTable khu = myCus.get_khu();
            //DataRow newRow1 = bang_gia_dien.NewRow();
            //newRow[0] = 0;
            //newRow[1] = "Tất cả";
            //bang_gia_dien.Rows.InsertAt(newRow, 0);
            ddlXomKhu.DataSource = khu;
            ddlXomKhu.DataBind();

            DataTable nam = myCus.get_nam();
            //DataRow newRow1 = bang_gia_dien.NewRow();
            //newRow[0] = 0;
            //newRow[1] = "Tất cả";
            //bang_gia_dien.Rows.InsertAt(newRow, 0);
            ddlNam.DataSource = nam;
            ddlNam.DataBind();
        }

    }

    protected void XemBC(object sender, EventArgs e)
    {
        txtErr.Text = "";
        string thang = ddlThang.SelectedValue.ToString();

        string nam = ddlNam.SelectedValue.ToString();
        
        if (thang != "" && nam != "")
        {
            string ky_hd = thang + "/" + nam;
                int id_dia_ban = int.Parse(ddlXomKhu.SelectedValue.ToString());
                string id_tram_bien_ap = ddlTramBA.SelectedValue.ToString();
                
                bindGrid(id_tram_bien_ap, id_dia_ban,  ky_hd);
           //     bindGrid(tungay1, denngay1, id_dia_ban);
            
        }
        else
        {
            txtErr.Text = "Bạn phải nhập tháng, năm để tính được kì hóa đơn ";
        }
    }

    protected void XuatExcel(object sender, EventArgs e)
    {
        ////getting datatable from viewstate  
        DataTable dt = (DataTable)ViewState["DataTable"];
        if (dt.Rows.Count == 0)
        {
            return;
        }
        
        string nameFile = "BaoCaoSanLuong_" + DateTime.Now.Year + ".xlsx";
        //calling create Excel File Method and ing dataTable   
        CreateExcelFile(dt, nameFile);
    }

    public void CreateExcelFile(DataTable baocao, string FileName)
    {
        using (baocao)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(baocao, "Sheet1");
                Response.Clear();
                Response.Buffer = true;
                Response.Charset = "";
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;filename=" + FileName);
                using (MemoryStream MyMemoryStream = new MemoryStream())
                {
                    wb.SaveAs(MyMemoryStream);
                    MyMemoryStream.WriteTo(Response.OutputStream);
                    Response.Flush();
                    Response.End();
                }

            }
        }
    }

    void DisplayCurrentPage()
    {
        // Calculate the current page number.
        int currentPage = GridView1.PageIndex + 1;
    }
    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {
        DisplayCurrentPage();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
       // bindGrid(int.Parse(drpDonVi.SelectedValue.ToString()));
    }
    void bindGrid(string id_tram_bien_ap, int id_khu, string ky_hd)
    {
        DataTable tbx = new DataTable();
        DataTable tbxView = new DataTable();
        clsBaocao cslBC = new clsBaocao();
        tbx = cslBC.SELECT_BANG_KE_TIEN_DIEN(id_tram_bien_ap, id_khu, ky_hd);

        DataRow dr;
        tbxView.Columns.Add("stt");
        tbxView.Columns.Add("ten_kh");
        tbxView.Columns.Add("ma_kh");
        tbxView.Columns.Add("dia_chi");
        tbxView.Columns.Add("tong_tien_sau_thue");
        tbxView.Columns.Add("ma_cong_to");
        tbxView.Columns.Add("chi_so_cu");
        tbxView.Columns.Add("chi_so_moi");
        tbxView.Columns.Add("so_ho");
        tbxView.Columns.Add("dien_nang_tt");
        tbxView.Columns.Add("sh1");
        tbxView.Columns.Add("sh2");
        tbxView.Columns.Add("sh3");
        tbxView.Columns.Add("sh4");
        tbxView.Columns.Add("sh5");
        tbxView.Columns.Add("sh6");
        tbxView.Columns.Add("NT");
        tbxView.Columns.Add("BV");
        tbxView.Columns.Add("KD");
        tbxView.Columns.Add("CSCC");
        tbxView.Columns.Add("TH");
        tbxView.Columns.Add("HCSN");
        tbxView.Columns.Add("BN");
        tbxView.Columns.Add("SX");
        dr = tbxView.NewRow();

        double sh1 = 0;
        double sh2 = 0;
        double sh3 = 0;
        double sh4 = 0;
        double sh5 = 0;
        double sh6 = 0;
        double NT = 0;
        double BV = 0;
        double KD = 0;
        double CSCC = 0;
        double BN = 0;
        double HCSN = 0;
        double TH = 0;
        double SX = 0;

        double san_luong_tt = 0;
        double tong_tien = 0;
        double so_ho = 0;
        string ma_kh = "";
        for (int i = 0; i < tbx.Rows.Count; i++)
        {
            ma_kh = tbx.Rows[i]["ma_kh"].ToString().Trim();
            if (ma_kh != "")
            {
                DataRow newRowTong = tbxView.NewRow();
                newRowTong[0] = i + 1;
                newRowTong[1] = tbx.Rows[i]["ten_kh"].ToString();
                newRowTong[2] = tbx.Rows[i]["ma_kh"].ToString();
                newRowTong[3] = tbx.Rows[i]["dia_chi"].ToString();
                newRowTong[4] = tbx.Rows[i]["tong_tien_sau_thue"].ToString();
                newRowTong[5] = tbx.Rows[i]["ma_cong_to"].ToString();
                newRowTong[6] = tbx.Rows[i]["chi_so_cu"].ToString();
                newRowTong[7] = tbx.Rows[i]["chi_so_moi"].ToString();
                newRowTong[8] = tbx.Rows[i]["so_ho"].ToString();
                newRowTong[9] = tbx.Rows[i]["dien_nang_tt"].ToString();

                //=================tinh san luong dien sinh hoat theo tung muc===============
                if (tbx.Rows[i]["id_bang_gia_dien"].ToString() == "7" || tbx.Rows[i]["id_bang_gia_dien"].ToString() == "8")
                {
                    string[] muc = new string[] { };
                    muc = cslBC.TINH_BAC_DIEN_SH(double.Parse(tbx.Rows[i]["dien_nang_tt"].ToString()), int.Parse(tbx.Rows[i]["so_ho"].ToString()));
                    newRowTong[10] = muc[0];
                    sh1=sh1+int.Parse(muc[0]);
                    newRowTong[11] = muc[1];
                    sh2 = sh2 + int.Parse(muc[1]);
                    newRowTong[12] = muc[2];
                    sh3 = sh4 + int.Parse(muc[2]);
                    newRowTong[13] = muc[3];
                    sh4 = sh4 + int.Parse(muc[3]);
                    newRowTong[14] = muc[4];
                    sh5 = sh5 + int.Parse(muc[4]);
                    newRowTong[15] = muc[5];
                    sh6 = sh6 + int.Parse(muc[5]);

                    newRowTong[16] = "";
                    newRowTong[17] = "";
                    newRowTong[18] = "";
                    newRowTong[19] = "";
                    newRowTong[20] = "";
                    newRowTong[21] = "";
                    newRowTong[22] = "";
                    newRowTong[23] = "";
                }
                else //========================tinh san luong dien su dung muc dich khac=====================
                {

                    newRowTong[10] = "";
                    newRowTong[11] = "";
                    newRowTong[12] = "";
                    newRowTong[13] = "";
                    newRowTong[14] = "";
                    newRowTong[15] = "";

                    if (tbx.Rows[i]["ten_viet_tat"].ToString() == "NT")
                    {
                        newRowTong[16] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        NT = NT + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "BV")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        BV = BV + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "KD")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        KD = KD + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "CSCC")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        CSCC = CSCC + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "TH")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        TH = TH + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "HCSN")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        HCSN = HCSN + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "BN")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        BN = BN + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                        newRowTong[23] = "";
                    }
                    else if (tbx.Rows[i]["ten_viet_tat"].ToString() == "SX")
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = tbx.Rows[i]["dien_nang_tt"].ToString();
                        SX = SX + int.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                    }
                    else 
                    {
                        newRowTong[16] = "";
                        newRowTong[17] = "";
                        newRowTong[18] = "";
                        newRowTong[19] = "";
                        newRowTong[20] = "";
                        newRowTong[21] = "";
                        newRowTong[22] = "";
                        newRowTong[23] = "";
                    }
                }


                tong_tien += double.Parse(tbx.Rows[i]["tong_tien_sau_thue"].ToString());
                so_ho += double.Parse(tbx.Rows[i]["so_ho"].ToString());
                san_luong_tt += double.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                

                tbxView.Rows.InsertAt(newRowTong, i);
            }
        }

        DataRow newRow4 = tbxView.NewRow();
        //newRow4[0] = "Tổng";
        newRow4[1] = "Tổng";
        //newRow4[2] = "";
        //newRow4[3] = "";
        //newRow4[4] = "";
       // newRow4[5] = tong_tien;
        newRow4[4] = tong_tien;
        newRow4[8] = so_ho;
        newRow4[9] = san_luong_tt;

        newRow4[10] = sh1;
        newRow4[11] = sh2;
        newRow4[12] = sh3;
        newRow4[13] = sh4;
        newRow4[14] = sh5;
        newRow4[15] = sh6;


        newRow4[16] = NT;
        newRow4[17] = BV;
        newRow4[18] = KD;
        newRow4[19] = CSCC;
        newRow4[20] = TH;
        newRow4[21] = HCSN;
        newRow4[22] = BN;
        newRow4[23] = SX;

        tbxView.Rows.InsertAt(newRow4, 0);

        GridView1.DataSource = tbxView;
        GridView1.DataBind();
        ViewState["DataTable"] = tbxView;
    }




    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayCurrentPage();
        }
    }
    protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["style"] = "cursor:pointer";
        }
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.RowIndex == GridView1.SelectedIndex)
            {
                row.ToolTip = string.Empty;
            }
            else
            {
                row.ToolTip = "Bấm để chọn dữ liệu.";
                Session["madonvi_chon"] = GridView1.SelectedRow.Cells[2].Text.ToString();
            }
        }

    }
   
    
}
