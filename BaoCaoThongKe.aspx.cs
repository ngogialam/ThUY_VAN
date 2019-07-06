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

public partial class BaoCaoThongKe : System.Web.UI.Page
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
        clsBaocao cslBC = new clsBaocao();
        tbx = cslBC.SELECT_SAN_LUONG_BIA(tu_ngay, den_ngay, id_dia_ban);

        double soluong_bh = 0;
        double soluong_bc = 0;
        double soluong_bk1 = 0;
        double soluong_bk2 = 0;
        for (int i = 0; i < tbx.Rows.Count; i++)
        {
            soluong_bh += double.Parse(tbx.Rows[i][7].ToString());
            soluong_bc += double.Parse(tbx.Rows[i][8].ToString());
            soluong_bk1 += double.Parse(tbx.Rows[i][9].ToString());
            soluong_bk2 += double.Parse(tbx.Rows[i][10].ToString());
        }
        lbl_solieu.Text = "Sản lượng tiêu thụ từ ngày: " + tu_ngay + " đến ngày: " + den_ngay;
        lblTongBH.Text = soluong_bh.ToString();
        lblTongBC.Text = soluong_bc.ToString();
        lblTongBK.Text = soluong_bk1.ToString();
        lblTongBK2.Text = soluong_bk2.ToString();

        //ViewState.Remove("DataTable");
        //DataRow newRow = tbx.NewRow();
        //newRow[0] = 0;
        //newRow[1] = "Tổng cộng";
        //newRow[2] = "";
        //newRow[3] = "";
        //newRow[4] = "";
        //newRow[5] = soluong_bh;
        //newRow[6] = soluong_bc;
        //newRow[7] = soluong_bk;
        //tbx.Rows.InsertAt(newRow, 0);
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
