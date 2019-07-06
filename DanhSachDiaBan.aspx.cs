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

public partial class DanhSachDiaBan : System.Web.UI.Page
{
    clsSanPham myProduct = new clsSanPham();
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
        //    int i = int.Parse(Session["loginSuccess"].ToString());
        //    if (i == 0)
        //        Response.Redirect("Login.aspx");
        //    else
        //    {
                DataTable DiaBan_tList = myProduct.get_danh_sach_dia_ban();
                DiaBan_tList.Columns["id_dia_ban"].ColumnName = "ID";
                DiaBan_tList.Columns["ten_dia_ban"].ColumnName = "Tên địa bàn";
                DiaBan_tList.Columns["vung"].ColumnName = "Vùng";
                GirdView.DataSource = DiaBan_tList;
                GirdView.DataBind();
                GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Response.Redirect("Login.aspx");    //}
        
    }
   
    
}
