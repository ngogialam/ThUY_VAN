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
    clsBaocao myBC = new clsBaocao();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataTable HuyenList = myCus.get_danh_muc_huyen();
            ddlHuyen.DataSource = HuyenList;
            ddlHuyen.DataBind();

            DataTable PhuongXaList = myCus.get_danh_muc_phuong_xa();
            ddlPhuongXa.DataSource = PhuongXaList;
            ddlPhuongXa.DataBind();


            DataTable DiaBanList = myCus.get_danh_muc_khu();
            cbKhu.DataSource = DiaBanList;
            cbKhu.DataBind();

            DataTable tram_bien_ap = myBC.get_tram_bien_ap();
            DataRow newRow = tram_bien_ap.NewRow();
            //newRow[0] = 0;
            //newRow[1] = "Tất cả";
            //tram_bien_ap.Rows.InsertAt(newRow, 0);
            ddlTramBA.DataSource = tram_bien_ap;
            ddlTramBA.DataBind();

            DataTable bang_gia_dien = myBC.get_bang_gia_dien();
            //DataRow newRow1 = bang_gia_dien.NewRow();
            //newRow[0] = 0;
            //newRow[1] = "Tất cả";
            //bang_gia_dien.Rows.InsertAt(newRow, 0);
            ddlBangGiaDien.DataSource = bang_gia_dien;
            ddlBangGiaDien.DataBind();

        }
     

    }

    protected void ThemMoiKhachHang(object sender, EventArgs e)
    {
        string ma_tu_sinh = myCus.get_ma_kh_tu_sinh();
        txtThuTu.Text = ma_tu_sinh;
        string ma_kh=ma_tu_sinh + "."+ myCus.get_ten_viet_tat_TBA( ddlTramBA.SelectedValue.ToString());
        string ten_kh=txtTenKh.Text.ToString().Trim();
        int id_bang_gia=int.Parse(ddlBangGiaDien.SelectedValue.ToString());
        string dia_chi=txtDiaChi.Text.ToString().Trim();
        int id_khu=int.Parse(cbKhu.SelectedValue.ToString());
        string id_tram_bien_ap=ddlTramBA.SelectedValue.ToString();
        int so_ho=int.Parse(txtSoHo.Text.Trim());
        float he_so_ti=float.Parse(txtSoHo.Text.Trim());
        string dien_thoai=txtSoDT.Text.ToString().Trim();
        int sms = ckSms.Checked ? 1 : 0;
        string mst_kh =txtMST.Text.Trim();
        string cot_dien_so=txtCotDienSo.Text.Trim();
        int sl_dong_ho=int.Parse(txtSLDH.Text.Trim());
        int trang_thai = 0;
        if(txtTrangThai.Text.Trim() !="0" || txtTrangThai.Text.Trim() !="1")
            trang_thai = 0;
        else
            trang_thai=int.Parse(txtTrangThai.Text.Trim());
        int thu_tu = int.Parse(txtThuTu.Text.Trim());
        int id_phuong_xa=int.Parse(ddlPhuongXa.SelectedValue.ToString());
        int id_huyen=int.Parse(ddlHuyen.SelectedValue.ToString());
        string ky_hd = DateTime.Now.Month + "/" + DateTime.Now.Year;
        if (DateTime.Now.Month < 10) ky_hd = "0" + ky_hd;
        string ma_cong_to = txtMaCongTo.Text.Trim();
        string[] list_ma_cong_to = ma_cong_to.Split('|');
        int check_ma = myCus.check_list_ma_cong_to(string.Join(", ", list_ma_cong_to));
        if (check_ma >= 1)
        {
            txtErr.Text = "Mã công tơ đã tồn tại, vui lòng kiểm tra lại !";
        }
        else
        {
            if (ten_kh != "" && dia_chi != "" && dien_thoai != "" && ma_cong_to != "" && cot_dien_so != "" && ma_kh != "" && thu_tu != 0 && sl_dong_ho != 0)
            {
                //thêm khách hàng phải thêm cả 2 bảng dm_cong_to và chi_so_cong_to
                int i = myCus.them_moi_khach_hang(ma_kh, ten_kh, id_bang_gia, dia_chi, id_khu, id_tram_bien_ap, so_ho, he_so_ti, dien_thoai, mst_kh, cot_dien_so, sl_dong_ho, ma_cong_to, trang_thai, thu_tu, id_phuong_xa, id_huyen, sms);
                if (i == 0)
                {
                    txtErr.Text = "Thêm mới khách hàng thất bại!";
                }
                else
                {
                    txtErr.Text = "Thêm mới khách hàng thành công!";
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
                txtErr.Text = "Chưa nhập đủ dữ liệu!";
            }
        }

    }
   
    
}
