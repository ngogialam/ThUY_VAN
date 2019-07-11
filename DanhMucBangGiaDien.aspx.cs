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

public partial class DanhMucBangGiaDien : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    clsConnect myCon = new clsConnect();
    DataTable CusList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv_bind();

        }

    }
    protected void gv_bind()
    {
        CusList = myCus.get_danh_muc_bang_gia_dien();
        GirdView.DataSource = CusList;
        GirdView.DataBind();
        GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
    }

    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        Label id = (Label)row.FindControl("lblId");
        Label tenBangGia = (Label)row.FindControl("lblTenBangGia");
        Label tenVietTat = (Label)row.FindControl("lblTenVT");
        Label donGia = (Label)row.FindControl("lblDonGia");
        Label thueVat = (Label)row.FindControl("lblThueVat");
        Label phanTramThue = (Label)row.FindControl("lblPhanTramThue");
        Label giaBan = (Label)row.FindControl("lblGiaBan");
        Label trangThai = (Label)row.FindControl("lblTrangThai");

        if (e.CommandName == "suaGiaDien")
        {
            //DataTable DiaBanList = myCus.get_dia_ban();
            txtId.Text = id.Text;
            txtTenBangGia.Text = tenBangGia.Text;
            txtTenVietTat.Text = tenVietTat.Text;
            txtDonGia.Text = donGia.Text;
            txtTienThue.Text = thueVat.Text;
            txtPhanTramThue.Text = phanTramThue.Text;
            txtGiaBan.Text = giaBan.Text;
            if (myCus.kt_trang_thai(Convert.ToInt32(id.Text)) == 1)
                ckbTrangThai.Checked = true;
            else
                ckbTrangThai.Checked = false;
            //ckbTrangThai.Checked = trangThai.Text;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#EditModal').modal('show');");
            sb.Append(@"</script>");


            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal",
            sb.ToString(), false);
        }

    }
    //kiemtratrangthai

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id_bang_gia = Convert.ToInt32(txtGiaBan.Text);
        string log = "Sửa giá điện mã " + id_bang_gia;
        string ten_bang_gia = txtTenBangGia.Text;
        string ten_viet_tat = txtTenVietTat.Text;
        double don_gia = Convert.ToDouble(txtDonGia.Text);
        double tien_thue_vat = Convert.ToDouble(txtTienThue.Text);
        double phan_tram_thue = Convert.ToDouble(txtPhanTramThue.Text);
        double gia_ban = Convert.ToDouble(txtGiaBan.Text);
        int kich_hoat = 0;
        if (ckbTrangThai.Checked == true) kich_hoat = 1;

        myCus.cap_nhat_gia_dien(id_bang_gia, ten_bang_gia, ten_viet_tat, don_gia, tien_thue_vat, phan_tram_thue, gia_ban, kich_hoat);
        myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");

        Response.Redirect("DanhMucBangGiaDien.aspx");
    }

    //validate
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int n = int.Parse(args.Value);
        if ((n==0) || (n == 1))
            args.IsValid = true;
        else
            args.IsValid = false;
    }

}
