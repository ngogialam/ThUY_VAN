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

public partial class DanhSachKyHD : System.Web.UI.Page
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
            DataTable KyHD_tList = myProduct.get_danh_sach_ky_hd();
                KyHD_tList.Columns["id"].ColumnName = "ID";
                KyHD_tList.Columns["ky"].ColumnName = "Kỳ HĐ";
                KyHD_tList.Columns["thang"].ColumnName = "Tháng";
                KyHD_tList.Columns["nam"].ColumnName = "Năm";
                KyHD_tList.Columns["tu_ngay"].ColumnName = "Từ ngày";
                KyHD_tList.Columns["den_ngay"].ColumnName = "Đến ngày";

                GirdView.DataSource = KyHD_tList;
                GirdView.DataBind();
                GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Response.Redirect("Login.aspx");    //}
        
    }
   
    
}
