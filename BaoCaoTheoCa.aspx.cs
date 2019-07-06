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

public partial class BaoCaoTheoCa : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //DataTable DiaBanList = myCus.get_dia_ban();
            //cbVung.DataSource = DiaBanList;
            //cbVung.DataBind();
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
        string tungay = Request.Form["strTuNgay"].ToString();
        string denngay = Request.Form["strDenNgay"].ToString();
        if (tungay != "-1" && denngay != "-1")
        {
           // Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "xembieudo(" + tungay + "," + denngay + ")", true);
            int inttungay = Convert.ToInt32(tungay);
            int intdenngay = Convert.ToInt32(denngay);
            if (inttungay > intdenngay)
            {
                txtErr.Text = "Thời gian từ ngày phải nhỏ hơn đến ngày";

            }
            else
            {
                string tungay1=tungay.Substring(0,4)+"-"+tungay.Substring(4,2)+"-"+tungay.Substring(6,2);
                string denngay1 = denngay.Substring(0, 4) + "-" + denngay.Substring(4, 2) + "-" + denngay.Substring(6, 2);
                int id_dia_ban = int.Parse(ddlDiaBan.SelectedValue.ToString());

                bindGrid(tungay1, denngay1, id_dia_ban);
            }
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
    void bindGrid(string tu_ngay,string den_ngay,int id_dia_ban)
    {
        DataTable tbx = new DataTable();
        DataTable tbxView = new DataTable();
        clsBaocao cslBC = new clsBaocao();
        tbx = cslBC.SELECT_SAN_LUONG_THEO_CA(tu_ngay, den_ngay, id_dia_ban);

        double soluong_bh50l = 0;
        double soluong_bh30l = 0;
        double soluong_bh20l = 0;
        double soluong_bk1 = 0;
        double soluong_bk2 = 0;
        double soluong_bl = 0;
        double soluong_bc = 0;

        double soluong_bh50l_2 = 0;
        double soluong_bh30l_2 = 0;
        double soluong_bh20l_2 = 0;
        double soluong_bk1_2 = 0;
        double soluong_bk2_2 = 0;
        double soluong_bl_2 = 0;
        double soluong_bc_2 = 0;

        double soluong_bh50l_3 = 0;
        double soluong_bh30l_3 = 0;
        double soluong_bh20l_3 = 0;
        double soluong_bk1_3 = 0;
        double soluong_bk2_3 = 0;
        double soluong_bl_3 = 0;
        double soluong_bc_3 = 0;

        double soluong_bh50l_4 = 0;
        double soluong_bh30l_4 = 0;
        double soluong_bh20l_4 = 0;
        double soluong_bk1_4 = 0;
        double soluong_bk2_4 = 0;
        double soluong_bl_4 = 0;
        double soluong_bc_4 = 0;


        string ca = "";
        string ma_hang = "";
        for (int i = 0; i < tbx.Rows.Count; i++)
        {
            ca = tbx.Rows[i]["ca"].ToString().Trim();
            ma_hang = tbx.Rows[i]["ma_hang"].ToString().Trim();
            if (ca == "1")
            { 
                if(ma_hang=="3")//bia hoi 50L
                    soluong_bh50l += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if(ma_hang=="2")//bia hoi 30L
                    soluong_bh30l += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "1")//bia hoi 20L
                    soluong_bh20l += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "4")//bia keg 1l
                    soluong_bk1 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "5")//bia keg 2l
                    soluong_bk2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "7")//bia lit
                    soluong_bl += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "6")//bia chai
                    soluong_bc += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else//bao giờ có mã hàng mới thì tính sau
                { }
            }
            else if (ca == "2")
            {
                if (ma_hang == "3")//bia hoi 50L
                    soluong_bh50l_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "2")//bia hoi 30L
                    soluong_bh30l_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "1")//bia hoi 20L
                    soluong_bh20l_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "4")//bia keg 1l
                    soluong_bk1_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "5")//bia keg 2l
                    soluong_bk2_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "7")//bia lit
                    soluong_bl_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "6")//bia chai
                    soluong_bc_2 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else//bao giờ có mã hàng mới thì tính sau
                { }
            }
            else if (ca == "3")
            {
                if (ma_hang == "3")//bia hoi 50L
                    soluong_bh50l_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "2")//bia hoi 30L
                    soluong_bh30l_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "1")//bia hoi 20L
                    soluong_bh20l_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "4")//bia keg 1l
                    soluong_bk1_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "5")//bia keg 2l
                    soluong_bk2_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "7")//bia lit
                    soluong_bl_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "6")//bia chai
                    soluong_bc_3 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else//bao giờ có mã hàng mới thì tính sau
                { }
            }
            else// số liệu bia chưa chốt ca
            {
                if (ma_hang == "3")//bia hoi 50L
                    soluong_bh50l_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "2")//bia hoi 30L
                    soluong_bh30l_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "1")//bia hoi 20L
                    soluong_bh20l_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "4")//bia keg 1l
                    soluong_bk1_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "5")//bia keg 2l
                    soluong_bk2_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "7")//bia lit
                    soluong_bl_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else if (ma_hang == "6")//bia chai
                    soluong_bc_4 += double.Parse(tbx.Rows[i]["tong_sl"].ToString());
                else//bao giờ có mã hàng mới thì tính sau
                { }
            }
            
        }

        DataRow dr;
        tbxView.Columns.Add("ca");
        tbxView.Columns.Add("bia_hoi50L");
        tbxView.Columns.Add("bia_hoi30L");
        tbxView.Columns.Add("bia_hoi20L");
        tbxView.Columns.Add("bia_keg1L");
        tbxView.Columns.Add("bia_keg2L");
        tbxView.Columns.Add("bia_le");
        tbxView.Columns.Add("bia_chai");
        dr = tbxView.NewRow();

        DataRow newRowTong = tbxView.NewRow();
        newRowTong[0] = "Tổng";
        newRowTong[1] = soluong_bh50l_3 + soluong_bh50l_4 + soluong_bh50l_2 + soluong_bh50l;
        newRowTong[2] = soluong_bh30l_3 + soluong_bh30l_4 + soluong_bh30l_2 + soluong_bh30l;
        newRowTong[3] = soluong_bh20l_3 + soluong_bh20l_4 + soluong_bh20l_2 + soluong_bh20l;
        newRowTong[4] = soluong_bk1_3 + soluong_bk1_4 + soluong_bk1_2 + soluong_bk1;
        newRowTong[5] = soluong_bk2_3 + soluong_bk2_4 + soluong_bk2_2 + soluong_bk2;
        newRowTong[6] = soluong_bl_3 + soluong_bl_4 + soluong_bl_2 + soluong_bl;
        newRowTong[7] = soluong_bc_3 + soluong_bc_4 + soluong_bc_2 + soluong_bc;
        tbxView.Rows.InsertAt(newRowTong, 0);

        DataRow newRow2 = tbxView.NewRow();
        newRow2[0] = "2";
        newRow2[1] = soluong_bh50l_2 ;
        newRow2[2] = soluong_bh30l_2 ;
        newRow2[3] = soluong_bh20l_2 ;
        newRow2[4] = soluong_bk1_2 ;
        newRow2[5] = soluong_bk2_2 ;
        newRow2[6] = soluong_bl_2 ;
        newRow2[7] = soluong_bc_2 ;
        tbxView.Rows.InsertAt(newRow2, 0);

        DataRow newRow = tbxView.NewRow();
        newRow[0] = "1";
        newRow[1] = soluong_bh50l ;
        newRow[2] = soluong_bh30l ;
        newRow[3] = soluong_bh20l ;
        newRow[4] = soluong_bk1;
        newRow[5] = soluong_bk2 ;
        newRow[6] = soluong_bl;
        newRow[7] = soluong_bc ;
        tbxView.Rows.InsertAt(newRow, 0);

        DataRow newRow3 = tbxView.NewRow();
        newRow3[0] = "3";
        newRow3[1] = soluong_bh50l_3;
        newRow3[2] = soluong_bh30l_3;
        newRow3[3] = soluong_bh20l_3;
        newRow3[4] = soluong_bk1_3;
        newRow3[5] = soluong_bk2_3;
        newRow3[6] = soluong_bl_3;
        newRow3[7] = soluong_bc_3;
        tbxView.Rows.InsertAt(newRow3, 0);

        DataRow newRow4 = tbxView.NewRow();
        newRow4[0] = "Chưa chốt";
        newRow4[1] = soluong_bh50l_4;
        newRow4[2] = soluong_bh30l_4;
        newRow4[3] = soluong_bh20l_4;
        newRow4[4] = soluong_bk1_4;
        newRow4[5] = soluong_bk2_4;
        newRow4[6] = soluong_bl_4;
        newRow4[7] = soluong_bc_4;
        tbxView.Rows.InsertAt(newRow4, 0);

        lbl_solieu.Text = "Sản lượng tiêu thụ từ ngày: " + tu_ngay + " đến ngày: " + den_ngay;
        lblTongBH50L.Text = (soluong_bh50l_3 + soluong_bh50l_4 + soluong_bh50l_2 + soluong_bh50l).ToString();
        lblTongBH30L.Text = (soluong_bh30l_3 + soluong_bh30l_4 + soluong_bh30l_2 + soluong_bh30l).ToString();
        lblTongBH20L.Text = (soluong_bh20l_3 + soluong_bh20l_4 + soluong_bh20l_2 + soluong_bh20l).ToString();
        lblTongBK.Text = (soluong_bk1_3 + soluong_bk1_4 + soluong_bk1_2 + soluong_bk1).ToString();
        lblTongBK2.Text = (soluong_bk2_3 + soluong_bk2_4 + soluong_bk2_2 + soluong_bk2).ToString();
        lblBiaLe.Text = (soluong_bl_3 + soluong_bl_4 + soluong_bl_2 + soluong_bl).ToString();
        lblBiaChai.Text = (soluong_bc_3 + soluong_bc_4 + soluong_bc_2 + soluong_bc).ToString();

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
