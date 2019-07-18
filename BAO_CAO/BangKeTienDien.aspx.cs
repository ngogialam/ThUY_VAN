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
        tbx.Columns.Add("sh1");
        tbx.Columns.Add("sh2");
        tbx.Columns.Add("sh3");
        tbx.Columns.Add("sh4");
        tbx.Columns.Add("sh5");
        tbx.Columns.Add("sh6");

        tbx.Columns.Add("NT");
        tbx.Columns.Add("BV");
        tbx.Columns.Add("KD");
        tbx.Columns.Add("CSCC");
        tbx.Columns.Add("TH");
        tbx.Columns.Add("HCSN");
        tbx.Columns.Add("BN");
        tbx.Columns.Add("SX");

        dr = tbx.NewRow();

        double tong_nam = 0;
        double tong_1_kh = 0;
        double tong_thang_1 = 0;
        double tong_thang_2 = 0;
        double tong_thang_3 = 0;
        double tong_thang_4 = 0;
        double tong_thang_5 = 0;
        double tong_thang_6 = 0;
        double tong_thang_7 = 0;
        double tong_thang_8 = 0;
        double tong_thang_9 = 0;
        double tong_thang_10 = 0;
        double tong_thang_11 = 0;
        double tong_thang_12 = 0;
        


        double san_luong_tt = 0;
        double tong_tien = 0;

        string ma_kh = "";
        for (int i = 0; i < tbx.Rows.Count; i++)
        {
            ma_kh = tbx.Rows[i]["ma_kh"].ToString().Trim();
            if (ma_kh != "")
            { 
                    san_luong_tt += double.Parse(tbx.Rows[i]["dien_nang_tt"].ToString());
                    tong_tien += double.Parse(tbx.Rows[i]["tong_tien_sau_thue"].ToString());
            }
        }

        DataRow newRow4 = tbx.NewRow();
        //newRow4[0] = "Tổng";
        newRow4[1] = "Tổng";
        //newRow4[2] = "";
        //newRow4[3] = "";
        //newRow4[4] = "";
        //newRow4[5] = "";
        newRow4[8] = san_luong_tt;
        newRow4[9] = tong_tien;
        tbx.Rows.InsertAt(newRow4, 0);

        GridView1.DataSource = tbx;
        GridView1.DataBind();
        ViewState["DataTable"] = tbx;
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
