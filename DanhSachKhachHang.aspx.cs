using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DanhSachKhachHang : System.Web.UI.Page
{
    clsNhapChiSo myNCS = new clsNhapChiSo();
    clsKhachHang myCus = new clsKhachHang();
    clsSanPham mySP = new clsSanPham();
    clsConnect myCon = new clsConnect();
    DataTable CusList = new DataTable();
    clsBaocao myBC = new clsBaocao();
    public static DataTable bang_gia_dien = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv_bind("");
            drpTramBienAp_1.DataSource = myNCS.get_danh_sach_tba();
            drpTramBienAp_1.DataBind();
            DataTable DiaBanList = myCus.get_danh_muc_khu();
            cbKhu.DataSource = DiaBanList;
            cbKhu.DataBind();
            drpKhu_AddModal.DataSource = DiaBanList;
            drpKhu_AddModal.DataBind();
            DataTable HuyenList = myCus.get_danh_muc_huyen();
            drpHuyen.DataSource = HuyenList;
            drpHuyen.DataBind();
            drpHuyen_AddModal.DataSource = HuyenList;
            drpHuyen_AddModal.DataBind();
            DataTable PhuongXaList = myCus.get_danh_muc_phuong_xa();
            drpPhuongXa.DataSource = PhuongXaList;
            drpPhuongXa.DataBind();
            drpPhuongXa_AddModal.DataSource = PhuongXaList;
            drpPhuongXa_AddModal.DataBind();
            DataTable tram_bien_ap = myBC.get_tram_bien_ap();
            drpTramBienAp.DataSource = tram_bien_ap;
            drpTramBienAp.DataBind();
            drpTramBienAp_AddModal.DataSource = tram_bien_ap;
            drpTramBienAp_AddModal.DataBind();
            bang_gia_dien = myBC.get_bang_gia_dien();
            drpBangGia.DataSource = bang_gia_dien;
            drpBangGia.DataBind();
            drpBangGia_AddModal.DataSource = bang_gia_dien;
            drpBangGia_AddModal.DataBind();
            DataTable tblSms = new DataTable();
            tblSms.Columns.Add(new DataColumn("trang_thai", typeof(int)));
            tblSms.Columns.Add(new DataColumn("ten", typeof(String)));
            // Thêm row trạng thái sms
            tblSms.Rows.Add(1, "Có");
            tblSms.Rows.Add(0, "Không");
            drpSms.DataSource = tblSms;
            drpSms.DataBind();
            drpSms_AddModal.DataSource = tblSms;
            drpSms_AddModal.DataBind();
        }

    }

    protected void gv_bind(string id_tramba)
    {
        CusList = myCus.get_danh_sach_khach_hang_theo_tram_bien_ap(id_tramba);
        GridViewEman.DataSource = CusList;
        GridViewEman.DataBind();
        if (CusList.Rows.Count > 0)
        {
            GridViewEman.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

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
        Label sms = (Label)row.FindControl("lblNumSms");
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
            drpSms.SelectedValue = sms.Text;

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
            drpPhuongXa.SelectedValue = idPhuongXa.Text;
            drpHuyen.SelectedValue = idHuyen.Text;
            drpTramBienAp.SelectedValue = idtba.Text;
            drpBangGia.SelectedValue = idbg.Text;
            //cbVung.DataSource = DiaBanList;            
            //cbVung.SelectedValue = iddb.Text;
            //cbVung.DataBind();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#EditModal').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal", sb.ToString(), false);
        }
        else if (e.CommandName == "doiCTo")
        {
            txt_swapModal_maKH.Text = id.Text;
            txt_swapModal_tenKH.Text = id.Text + " - " + name.Text;
            string cac_cong_to_hien_tai = idMaCongTo.Text;
            string[] arrMaCTo = cac_cong_to_hien_tai.Split('|');
            drp_swapModal_cTo.DataSource = arrMaCTo;
            drp_swapModal_cTo.DataBind();
            txt_swapModal_csCu.Text = "0";
            txt_swapModal_csCuoiCu.Text = "0";
            txt_swapModal_csDauMoi.Text = "0";
            txt_swapModal_csCuoiMoi.Text = "0";
            txt_swapModal_maCtoMoi.Text = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#SwapModal').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal", sb.ToString(), false);
        }

    }

    protected void btnLaySL_Click(object sender, EventArgs e)
    {
        string id_tram = drpTramBienAp_1.SelectedValue.ToString();
        gv_bind(id_tram);
    }

    protected void btnThemMoi_Callback(object sender, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
    {
        string ma_tu_sinh = myCus.get_ma_kh_tu_sinh();
        txtThuTu.Text = ma_tu_sinh;
        string ma_kh = ma_tu_sinh + "." + myCus.get_ten_viet_tat_TBA(drpTramBienAp_AddModal.SelectedValue.ToString());
        string ten_kh = txtTenKh_AddModal.Text.ToString().Trim();
        int id_bang_gia = int.Parse(drpBangGia_AddModal.SelectedValue.ToString());
        string dia_chi = txtDiaChi_AddModal.Text.ToString().Trim();
        int id_khu = int.Parse(drpKhu_AddModal.SelectedValue.ToString());
        string id_tram_bien_ap = drpTramBienAp_AddModal.SelectedValue.ToString();
        int so_ho = int.Parse(txtSoHo_AddModal.Text.Trim());
        float he_so_ti = float.Parse(txtHSTi_AddModal.Text.Trim());
        string dien_thoai = txtSoDT_AddModal.Text.ToString().Trim();
        int sms = Convert.ToInt32(drpSms_AddModal.SelectedValue);
        string mst_kh = txtMstKH_AddModal.Text.Trim();
        string cot_dien_so = txtSoCot_AddModal.Text.Trim();
        int sl_dong_ho = int.Parse(txtSoDongHo_AddModal.Text.Trim());
        int trang_thai = ckbTrangThai_AddModal.Checked ? 1 : 0;
        int thu_tu = int.Parse(txtThuTu_AddModal.Text.Trim());
        int id_phuong_xa = int.Parse(drpPhuongXa_AddModal.SelectedValue.ToString());
        int id_huyen = int.Parse(drpHuyen_AddModal.SelectedValue.ToString());
        string ky_hd = DateTime.Now.Month + "/" + DateTime.Now.Year;
        if (DateTime.Now.Month < 10) ky_hd = "0" + ky_hd;
        string ma_cong_to = txtMaCongTo_AddModal.Text.Trim();
        string[] list_ma_cong_to = ma_cong_to.Split('|');
        int check_ma = myCus.check_list_ma_cong_to(string.Join(", ", list_ma_cong_to));
        if (check_ma >= 1)
        {
            e.Result = "2"; //Mã công tơ đã tồn tại
        }
        else
        {
            if (ten_kh != "" && dia_chi != "" && dien_thoai != "" && ma_cong_to != "" && cot_dien_so != "" && ma_kh != "" && thu_tu != 0 && sl_dong_ho != 0)
            {
                //thêm khách hàng phải thêm cả 2 bảng dm_cong_to và chi_so_cong_to
                int i = myCus.them_moi_khach_hang(ma_kh, ten_kh, id_bang_gia, dia_chi, id_khu, id_tram_bien_ap, so_ho, he_so_ti, dien_thoai, mst_kh, cot_dien_so, sl_dong_ho, ma_cong_to, trang_thai, thu_tu, id_phuong_xa, id_huyen, sms);
                if (i == 0)
                {
                    e.Result = "0";
                }
                else
                {
                    e.Result = "1";
                }
                foreach (string unique_ma_cto in list_ma_cong_to)
                {
                    if (unique_ma_cto.Trim() != "" & i != 0)
                    {
                        int j = myCus.them_moi_cong_to(unique_ma_cto, ma_kh, he_so_ti);
                        int k = myCus.them_moi_chi_so_cong_to(unique_ma_cto, ky_hd);
                    }
                }
            }
            else
            {
                e.Result = "0";
            }
        }
    }

    protected void btnCapNhat_Callback(object sender, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
    {
        string ma_kh = txtMaKH.Text;
        string ten_kh = txtTenKh.Text;
        int id_bang_gia = int.Parse(drpBangGia.SelectedValue.ToString());
        string dia_chi = txtDiaChi.Text;
        int id_khu = int.Parse(cbKhu.SelectedValue.ToString());
        string id_tram_bien_ap = drpTramBienAp.SelectedValue.ToString();
        int so_ho = int.Parse(txtSoHo.Text);
        float he_so_ti = float.Parse(txtHSTi.Text);
        string dien_thoai = txtSoDT.Text;
        int sms = int.Parse(drpSms.SelectedValue);
        string mst_kh = txtMstKH.Text.ToString();
        string cot_dien_so = txtSoCot.Text;
        int sl_dong_ho = int.Parse(txtSoDongHo.Text);
        string ma_cong_to = txtMaCongTo.Text;
        int trang_thai = 0;
        if (ckbTrangThai.Checked)
            trang_thai = 1;
        int thu_tu = int.Parse(txtThuTu.Text);
        int id_phuong_xa = int.Parse(drpPhuongXa.SelectedValue.ToString());
        int id_huyen = int.Parse(drpHuyen.SelectedValue.ToString());
        try
        {
            string log = "Sửa khách hàng mã " + ma_kh;
            myCus.cap_nhat_khach_hang(ma_kh, ten_kh, id_bang_gia, dia_chi, id_khu, id_tram_bien_ap, so_ho, he_so_ti, dien_thoai, mst_kh, cot_dien_so, sl_dong_ho, ma_cong_to, trang_thai, thu_tu, id_phuong_xa, id_huyen, sms);
            myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");
            e.Result = "1";
        }
        catch
        {
            e.Result = "0";
        }
    }

    protected void btnDoiCTo_Callback(object sender, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
    {
        
        string ma_kh = txt_swapModal_maKH.Text;
        string ten_kh = txt_swapModal_tenKH.Text;
        float csDau_CToCu = float.Parse(txt_swapModal_csCu.Text);
        float csCuoi_CToCu = float.Parse(txt_swapModal_csCuoiCu.Text);
        float csDau_CToMoi = float.Parse(txt_swapModal_csDauMoi.Text);
        float csCuoi_CToMoi = float.Parse(txt_swapModal_csCuoiMoi.Text);
        string ma_cto_cu = drp_swapModal_cTo.SelectedValue;
        string ma_cto_moi = txt_swapModal_maCtoMoi.Text;

        int check_ma = myCus.check_ma_cong_to(ma_cto_moi);
        if (check_ma >= 1)
        {
            e.Result = "2"; //Mã công tơ đã tồn tại
        }
        else
        {
            try
            {
                DataTable tblKH = myCus.get_khach_hang_theo_makh(ma_kh);
                string maCtoKh = tblKH.Rows[0].Field<string>("ma_cong_to");
                // Cập nhật mã công tơ mới trong bảng khach_hang
                string maCtoMoiKh = maCtoKh.Replace(ma_cto_cu, ma_cto_moi);
                myCus.cap_nhat_cong_to_khach_hang(ma_kh, maCtoMoiKh);

                // Lấy kỳ hợp đồng hiện tại
                DataTable tblKyHD = mySP.get_danh_sach_ky_hd();
                string ky_hd = "";

                // Cập nhật trạng thái công tơ cũ trong bảng chi_so_cong_to và dm_cong_to
                myCus.cap_nhat_trang_thai_chi_so_cong_to(ma_cto_cu, ky_hd, 0);
                myCus.cap_nhat_trang_thai_cong_to(ma_cto_cu, 0);

                // Thêm mã công tơ mới trong bảng dm_cong_to và chi_so_cong_to
                DataTable tblCToCu = myCus.get_cong_to_theo_maCTo(ma_cto_cu);
                float hSoTiCu = tblCToCu.Rows[0].Field<float>("he_so_ti");
                myCus.them_moi_cong_to(ma_cto_moi, ma_kh, hSoTiCu);
                myCus.them_moi_chi_so_cong_to(ma_cto_moi, ky_hd);

                e.Result = "1";

                string log = "Đổi công tơ của khách hàng có mã " + ten_kh + " mã công tơ cũ: " + ma_cto_cu + ", mã công tơ mới: " + ma_cto_moi;
                myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");
            }
            catch
            {
                e.Result = "0";
            }
        }
    }

    protected string convertTenBangGia(object idBangGia)
    {
        string result = "";
        bang_gia_dien = myBC.get_bang_gia_dien();
        try
        {
            string expression = "id_bang_gia = " + idBangGia;
            DataRow[] foundRows = bang_gia_dien.Select(expression);
            result = foundRows[0][1].ToString();
        }
        catch { }
        return result;
    }
}
