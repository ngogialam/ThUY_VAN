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

public partial class ThemBangGiaDien : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();

    protected void ThemBangGiaDien_Click(object sender, EventArgs e)
    {

        //int idBangGia = Convert.ToInt32(txtId.Text);
        string tenBangGia = txtTenBangGia.Text;
        string tenVietTat = txtTenVietTat.Text;
        double donGia = Convert.ToDouble(txtDonGia.Text);
        double tienThue = Convert.ToDouble(txtTienThue.Text);
        double phanTramThue = Convert.ToDouble(txtPhanTramThue.Text);
        double giaBan = Convert.ToDouble(txtGiaBan.Text);
        int kichHoat =0;
        if (ckbTrangThai.Checked == true)
            kichHoat = 1;
            int i = myCus.them_moi_gia_dien(tenBangGia, tenVietTat, donGia, tienThue, phanTramThue, giaBan, kichHoat);
            if (i == 0)
                txtErr.Text = "Thêm mới thất bại!";
            else
                txtErr.Text = "Thêm mới khách hàng thành công!";

        }

    //validate
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int n = int.Parse(args.Value);
        if ((n == 0) || (n == 1))
            args.IsValid = true;
        else
            args.IsValid = false;
    }
}
