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

public partial class DanhSachKhachHang : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    clsConnect myCon = new clsConnect();
    DataTable CusList = new DataTable();

    clsBaocao myBC = new clsBaocao();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv_bind();

        }

    }
    protected void gv_bind()
    {
        CusList = myCus.get_danh_sach_khach_hang();
        if (CusList.Rows.Count > 0)
        {

            GirdView.DataSource = CusList;
            GirdView.DataBind();
        }
        GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;

        //DataTable DiaBanList = myCus.get_danh_muc_khu();
        //ddlKhu.DataSource = DiaBanList;
        //ddlKhu.DataBind();

    }
    
    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        Label id = (Label)row.FindControl("lblMaKH");
        Label name = (Label)row.FindControl("lblTenKH");
        Label diachi = (Label)row.FindControl("lblDiaChi");
        Label dt = (Label)row.FindControl("lblDienThoai");
        Label thutu = (Label)row.FindControl("lblThuTu");
        Label iddb = (Label)row.FindControl("lblKhu");

        Label idsoho = (Label)row.FindControl("lblsoHo");
        Label idHeSoti = (Label)row.FindControl("lbldHeSoti");
        Label idCotDienSo = (Label)row.FindControl("lblCotDienSo");
        Label idSLDongHo = (Label)row.FindControl("lblSLDongHo");
        Label idMaCongTo = (Label)row.FindControl("lblMaCongTo");
        Label idtba = (Label)row.FindControl("lblIdBA");
        Label idbg = (Label)row.FindControl("lblIdBangGia");
        Label idMtsKHg = (Label)row.FindControl("lblMtsKH");

        Label idPhuongXa = (Label)row.FindControl("lblIdPhuongXa");
        Label idHuyen = (Label)row.FindControl("lblMIdHuyen");
        
            
        

        if (e.CommandName == "suaKH")
        {
            DataTable DiaBanList = myCus.get_danh_muc_khu();
            cbKhu.DataSource = DiaBanList;
            cbKhu.DataBind();


            DataTable HuyenList = myCus.get_danh_muc_huyen();
            cbHuyen.DataSource = HuyenList;
            cbHuyen.DataBind();

            DataTable PhuongXaList = myCus.get_danh_muc_phuong_xa();
            cbVung.DataSource = PhuongXaList;
            cbVung.DataBind();


            DataTable tram_bien_ap = myBC.get_tram_bien_ap();
            cbTramBienAp.DataSource = tram_bien_ap;
            cbTramBienAp.DataBind();

            DataTable bang_gia_dien = myBC.get_bang_gia_dien();
            cbBangGia.DataSource = bang_gia_dien;
            cbBangGia.DataBind();


            txtMaKH.Text = id.Text;
            txtTenKh.Text = name.Text;
            txtDiaChi.Text = diachi.Text;
            txtSoDT.Text = dt.Text;
            txtSoHo.Text = idsoho.Text;
            txtHSTi.Text = idHeSoti.Text;
            txtSoCot.Text = idCotDienSo.Text;
            txtSoDongHo.Text = idSLDongHo.Text;
            txtMaCongTo.Text = idMaCongTo.Text;
            txtThuTu.Text = thutu.Text;
            txtMstKH.Text = idMtsKHg.Text;

            //txtNamBH.Text = nambh.Text;
            cbKhu.SelectedValue = iddb.Text;
            cbVung.SelectedValue = idPhuongXa.Text;
            cbHuyen.SelectedValue = idHuyen.Text;
            cbTramBienAp.SelectedValue = idtba.Text;
            cbBangGia.SelectedValue = idbg.Text;
            
            //cbVung.DataSource = DiaBanList;            
            //cbVung.SelectedValue = iddb.Text;
            //cbVung.DataBind();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#EditModal').modal('show');");
            sb.Append(@"</script>");


            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal",
            sb.ToString(), false);
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string ma_kh=txtMaKH.Text;
        string ten_kh=txtTenKh.Text;
        int id_bang_gia=int.Parse(cbBangGia.SelectedValue.ToString());
        string dia_chi=txtDiaChi.Text;
        int id_khu=int.Parse(cbKhu.SelectedValue.ToString());

        string id_tram_bien_ap=cbTramBienAp.SelectedValue.ToString();
        int so_ho=int.Parse(txtSoHo.Text);
        float he_so_ti=float.Parse(txtHSTi.Text);
        string dien_thoai=txtSoDT.Text;
        string mst_kh=txtMstKH.Text.ToString();
        string cot_dien_so=txtSoCot.Text;
        int sl_dong_ho=int.Parse(txtSoDongHo.Text);
        string ma_cong_to=txtMaCongTo.Text;
        int trang_thai = 0;
        if(ckbTrangThai.Checked)
         trang_thai=1;
        int thu_tu=int.Parse(txtThuTu.Text);
        int id_phuong_xa=int.Parse(cbVung.SelectedValue.ToString());
        int id_huyen = int.Parse(cbHuyen.SelectedValue.ToString());


        string log = "Sửa khách hàng mã " + ma_kh;
       

        myCus.cap_nhat_khach_hang( ma_kh, ten_kh, id_bang_gia, dia_chi, id_khu, id_tram_bien_ap, so_ho, he_so_ti, dien_thoai, mst_kh, cot_dien_so, sl_dong_ho, ma_cong_to, trang_thai, thu_tu, id_phuong_xa, id_huyen);
        myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");
       
        Response.Redirect("DanhSachKhachHang.aspx");
    }
   
}
