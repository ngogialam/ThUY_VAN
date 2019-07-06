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

public partial class BaoCaoThang : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    
    protected void Page_Load(object sender, EventArgs e)
    {

	//return
        if (!Page.IsPostBack)
        {
          
            DataTable dia_ban = myCus.get_dia_ban();

            DataRow newRow = dia_ban.NewRow();
            newRow[0] = 0;
            newRow[1] = "Tất cả";
            dia_ban.Rows.InsertAt(newRow, 0);


            ddlDiaBan.DataSource = dia_ban;
            ddlDiaBan.DataBind();
        }

        //try
        //{
        //    int i = int.Parse(Session["loginSuccess"].ToString());
        //    if (i == 0)
        //        Response.Redirect("Login.aspx");
        //    else
        //    {
        //        //DataTable ProductList = myProduct.get_danh_sach_san_pham();
        //        //ProductList.Columns["ma_hang"].ColumnName = "Mã sản phẩm";
        //        //ProductList.Columns["ten_hang"].ColumnName = "Tên sản phẩm";
        //        //ProductList.Columns["dv_tinh"].ColumnName = " Đơn vị tính";
        //        //GirdView.DataSource = ProductList;
        //        //GirdView.DataBind();
        //        //GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Response.Redirect("Login.aspx");
        //}


    }

    protected void XemBC(object sender, EventArgs e)
    {
        txtErr.Text = "";
       
            int nam = int.Parse(ddlNam.SelectedValue.ToString());
            int id_dia_ban = int.Parse(ddlDiaBan.SelectedValue.ToString());
            int loai_sp = int.Parse(ddlLoaiSP.SelectedValue.ToString());

            bindGrid(id_dia_ban, loai_sp, nam);
       
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
    void bindGrid(int id_dia_ban, int loai_sp, int nam)
    {
        DataTable tbx = new DataTable();
        DataTable tbxView = new DataTable();
        clsBaocao cslBC = new clsBaocao();
        clsKhachHang clsKH = new clsKhachHang();
        tbx = clsKH.get_danh_sach_khach_hang_dia_ban(id_dia_ban);

       

        DataRow dr;
        tbxView.Columns.Add("ten_kh");
        tbxView.Columns.Add("nam_bh");
        tbxView.Columns.Add("so_dt");
        tbxView.Columns.Add("ten_dia_ban");
        tbxView.Columns.Add("thang1");
        tbxView.Columns.Add("thang2");
        tbxView.Columns.Add("thang3");
        tbxView.Columns.Add("thang4");
        tbxView.Columns.Add("thang5");
        tbxView.Columns.Add("thang6");
        tbxView.Columns.Add("thang7");
        tbxView.Columns.Add("thang8");
        tbxView.Columns.Add("thang9");
        tbxView.Columns.Add("thang10");
        tbxView.Columns.Add("thang11");
        tbxView.Columns.Add("thang12");
        tbxView.Columns.Add("tong_1_kh");
        dr = tbxView.NewRow();

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
        

        for (int i = 0; i < tbx.Rows.Count; i++)
        {
            DataRow newRowTong = tbxView.NewRow();
            newRowTong[0] = tbx.Rows[i]["ten_kh"].ToString();
            newRowTong[1] = tbx.Rows[i]["nam_bh"].ToString();
            newRowTong[2] = tbx.Rows[i]["so_dt"].ToString();
            newRowTong[3] = tbx.Rows[i]["ten_dia_ban"].ToString();

            tong_thang_1= cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 1);
            tong_thang_2 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 2);
            tong_thang_3 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 3);
            tong_thang_4 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 4);
            tong_thang_5 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 5);
            tong_thang_6 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 6);
            tong_thang_7 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 7);
            tong_thang_8 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 8);
            tong_thang_9 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 9);
            tong_thang_10 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 10);
            tong_thang_11 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 11);
            tong_thang_12 = cslBC.SELECT_SAN_LUONG_THANG_THEO_SP(id_dia_ban, int.Parse(tbx.Rows[i]["ma_kh"].ToString()), loai_sp, nam, 12);

            newRowTong[4] = tong_thang_1;
            newRowTong[5] = tong_thang_2;
            newRowTong[6] = tong_thang_3;
            newRowTong[7] = tong_thang_4;
            newRowTong[8] = tong_thang_5;
            newRowTong[9] = tong_thang_6;
            newRowTong[10] = tong_thang_7;
            newRowTong[11] = tong_thang_8;
            newRowTong[12] = tong_thang_9;
            newRowTong[13] = tong_thang_10;
            newRowTong[14] = tong_thang_11;
            newRowTong[15] = tong_thang_12;

            tong_1_kh = tong_thang_1 + tong_thang_2 + tong_thang_3 + tong_thang_4 + tong_thang_5 + tong_thang_6 + tong_thang_7 + tong_thang_8 + tong_thang_9 + tong_thang_10 + tong_thang_11 + tong_thang_12;
            newRowTong[16] = tong_1_kh;
           // tong_nam = tong_nam + tong_1_kh;
            tbxView.Rows.InsertAt(newRowTong, i);

        }

        lbl_solieu.Text = "Chi tiết sản lượng tiêu thụ của khách hàng năm "+ nam ;
        
        //lblTongBK.Text = soluong_bk1.ToString();
        //lblTongBK2.Text = soluong_bk2.ToString();
        //lblTongBC.Text = soluong_bc.ToString();
        //lblBiaHoi.Text = soluong_bh.ToString();

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
