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

public partial class ThemKhachHang : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            DataTable DiaBanList = myCus.get_dia_ban();
            cbVung.DataSource = DiaBanList;
            cbVung.DataBind();
        }
     

    }

    protected void ThemMoiKhachHang(object sender, EventArgs e)
    {

        string tenkh = txtTenKh.Text.ToString();
        string dia_chi = txtDiaChi.Text.ToString();
        string so_dt = txtSoDT.Text.ToString();
        int nam_bh = int.Parse(txtNamBH.Text.ToString());
        int id_dia_ban = int.Parse(cbVung.SelectedValue.ToString());

        if (tenkh != "" && dia_chi != "" && so_dt != "" )
        {
            int i = myCus.them_moi_khach_hang(tenkh, dia_chi, so_dt, nam_bh, id_dia_ban);
            if(i==0)
                txtErr.Text = "Thêm mới thất bại!";
            else
                txtErr.Text = "Thêm mới khách hàng thành công!";
                
        }
        else
        {
            txtErr.Text = "Chưa nhập đủ dữ liệu!";
        }

    }
   
    
}
