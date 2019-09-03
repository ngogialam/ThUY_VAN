using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DanhMucCongTo : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    clsConnect myCon = new clsConnect();
    DataTable CusList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv_bind();
            DataTable tblTrangThai = new DataTable();
            tblTrangThai.Columns.Add(new DataColumn("ma_tt", typeof(int)));
            tblTrangThai.Columns.Add(new DataColumn("ten_tt", typeof(String)));
            // Thêm row trạng thái sms
            tblTrangThai.Rows.Add(1, "Activate");
            tblTrangThai.Rows.Add(0, "Deactive");
            drpTrangThai.DataSource = tblTrangThai;
            drpTrangThai.DataBind();
            drpTrangThai_AddModal.DataSource = tblTrangThai;
            drpTrangThai_AddModal.DataBind();
        }

    }
    protected void gv_bind()
    {
        CusList = myCus.get_danh_muc_cong_to();
        GridViewEman.DataSource = CusList;
        GridViewEman.DataBind();
        if (CusList.Rows.Count > 0)
        {
            GridViewEman.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        Label maCto = (Label)row.FindControl("lblMaCTo");
        Label maKh = (Label)row.FindControl("lblMaKh");
        Label chungLoai = (Label)row.FindControl("lblChungLoai");
        Label heSoTi = (Label)row.FindControl("lblHeSoTi");
        Label nhaSanXuat = (Label)row.FindControl("lblNhaSanXuat");
        Label ngaySD = (Label)row.FindControl("lblNgaySuDung");
        Label ngayHetHan = (Label)row.FindControl("lblNgayHetHan");
        Label trangThai = (Label)row.FindControl("lblIDTrangThai");

        if (e.CommandName == "suaGiaDien")
        {
            //DataTable DiaBanList = myCus.get_dia_ban();
            txtMaCTo.Text = maCto.Text;
            txtMaKh.Text = maKh.Text;
            txtChungLoai.Text = chungLoai.Text;
            txtHeSoTi.Text = heSoTi.Text;
            txtNhaSanXuat.Text = nhaSanXuat.Text;
            txtNgaySD.Text = ngaySD.Text;
            txtNgayHetHan.Text = ngayHetHan.Text;
            drpTrangThai.SelectedValue = trangThai.Text;
           
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#EditModal').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal",
            sb.ToString(), false);
        }
        else if (e.CommandName == "xoaGiaDien")
        {
        }

    }

    protected void btnSave_Callback(object sender, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
    {
        //int id_bang_gia = Convert.ToInt32(txtId.Text);
        //string log = "Sửa giá điện mã " + id_bang_gia;
        //string ten_bang_gia = txtTenBangGia.Text;
        //string ten_viet_tat = txtTenVietTat.Text;
        //double don_gia = Convert.ToDouble(txtDonGia.Text);
        //double tien_thue_vat = Convert.ToDouble(txtTienThue.Text);
        //double phan_tram_thue = Convert.ToDouble(txtPhanTramThue.Text);
        //double gia_ban = Convert.ToDouble(txtGiaBan.Text);
        //int kich_hoat = 0;
        //if (ckbTrangThai.Checked == true) kich_hoat = 1;
        //try
        //{
        //    myCus.cap_nhat_gia_dien(id_bang_gia, ten_bang_gia, ten_viet_tat, don_gia, tien_thue_vat, phan_tram_thue, gia_ban, kich_hoat);
        //    myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");
        //    e.Result = "1";
        //}
        //catch
        //{
        //    e.Result = "0";
        //}
    }

    protected void btnThemMoi_Callback(object sender, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
    {
        string maCongTo = txtMaCTo_AddModal.Text;
        string maKh = txtMaKh_AddModal.Text;
        string chungLoai = txtChungLoai_AddModal.Text;
        string nhaSanXuat = txtNhaSanXuat_AddModal.Text;
        string ngaySD = txtNgaySD_AddModal.Text;
        string ngayHetHan = txtNgayHetHan_AddModal.Text;

        int heSoTi = Convert.ToInt32(txtHeSoTi_AddModal.Text);
        int trangThai = 0;
        int i = myCus.them_moi_cong_to(maCongTo, maKh, heSoTi);
        if (i == 0)
            e.Result = "0";
        else
            e.Result = "1";
    }
}
