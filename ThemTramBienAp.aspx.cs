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

public partial class ThemTramBienAp : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();

    protected void ThemTramBienAp_Click(object sender, EventArgs e)
    {

        string idTramBA = txtId.Text;
        string tenTramBA = txtTenTrạmBienAp.Text;
        string diaChi = txtDiaChi.Text;
        string nguoiPT = txtNguoiPT.Text;
        string maSoCT = txtMaSoCT.Text;
        int heSoNhan = Convert.ToInt32(txtHeSoNhan.Text);
        int kichHoat = 0;
        if (ckbTrangThai.Checked == true)
            kichHoat = 1;
        int i = myCus.them_moi_tram_bien_ap(idTramBA, tenTramBA, diaChi, nguoiPT, maSoCT, heSoNhan, kichHoat);
        if (i == 0)
            txtErr.Text = "Thêm mới thất bại!";
        else
            txtErr.Text = "Thêm trạm biến áp thành công!";

    }
    protected void Huy_Click(object sender, EventArgs e)
    {

        txtId.Text = "";
        txtTenTrạmBienAp.Text = "";
        txtDiaChi.Text = "";
        txtNguoiPT.Text = "";
        txtMaSoCT.Text ="";
        txtHeSoNhan.Text= "";
        ckbTrangThai.Checked = false;

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
