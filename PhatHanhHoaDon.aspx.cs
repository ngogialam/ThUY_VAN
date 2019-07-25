using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using ClosedXML.Excel;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.UI.HtmlControls;

public partial class PhatHanhHoaDon : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    clsConnect myCon = new clsConnect();
    clsNhapChiSo myNCS = new clsNhapChiSo();
    DataTable CusList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            drpTram.DataSource = myNCS.get_danh_sach_tba();
            drpTram.DataBind();

            drpKy.DataSource = myNCS.get_danhsach_ky();
            drpKy.DataBind();

            ddlKyCu.DataSource = myNCS.get_danhsach_ky();
            ddlKyCu.DataBind();
            lblErr.Text = "";

            string kyhd = drpKy.SelectedItem.ToString();
            string tungay = myNCS.lay_tungay_denngay(kyhd).Rows[0]["tu_ngay"].ToString().Substring(0, 10); 
            string denngay = myNCS.lay_tungay_denngay(kyhd).Rows[0]["den_ngay"].ToString().Substring(0, 10);
            lblTuNgay.Text = tungay;
            lblDenNgay.Text = denngay;


        }

    }

    protected void gv_bind(string id_tramba, string kyhd)
    {
        CusList = myNCS.get_danh_sach_lap_hd(id_tramba, kyhd);
        
        int i = 0;
        int j = 0;
        CusList.Columns.Add("total", typeof(String));
        CusList.Columns.Add("vatamount", typeof(String));
        CusList.Columns.Add("amount", typeof(String));
        if (CusList.Rows.Count > 0)
        {
            for (i = 0; i < CusList.Rows.Count; i++)
            {
                Double dntt = 0;
                int sh = 0;
                Double dongia = 0;
                Double total = 0;
                Double vatrate = 0;
                Double vatamount = 0;
                Double amount = 0; // amount = total + vatamount
                DataTable BangGia = myNCS.lay_bang_gia(CusList.Rows[i]["id_bang_gia"].ToString());
                dntt = Convert.ToDouble(CusList.Rows[i]["san_luong"].ToString());
                sh = Convert.ToInt32(CusList.Rows[i]["so_ho"].ToString());
                if (BangGia.Rows.Count == 1)
                {
                    vatrate = Convert.ToDouble(BangGia.Rows[0]["phan_tram_thue"].ToString());
                    dongia = Convert.ToDouble(BangGia.Rows[0]["don_gia"].ToString());
                    total = dntt * dongia;
                    vatamount = vatrate * total / 100;
                    amount = total + vatamount;
                }
                else
                {
                    Double[] muc = myNCS.tinh_cs_6_muc(dntt, sh);
                    Double[] dongiamuc = new Double[] { };

                    for (j = 0; j < muc.Length; j++)
                    {
                        total = total + (muc[j] * Convert.ToDouble(BangGia.Rows[j]["gia_ko_vat"].ToString()));
                        vatrate = Convert.ToDouble(BangGia.Rows[0]["phan_tram_thue"].ToString());

                    }

                }
                vatamount = vatrate * total / 100;
                amount = total + vatamount;
                CusList.Rows[i]["total"] = total.ToString();
                CusList.Rows[i]["vatamount"] = vatamount.ToString();
                CusList.Rows[i]["amount"] = amount.ToString();
            }

            GridViewEman.DataSource = CusList;
            GridViewEman.DataBind();
            GridViewEman.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected DataTable dtb_bind(string id_tramba, string kyhd)
    {
        CusList = myNCS.get_danh_sach_lap_hd(id_tramba, kyhd);
        int i = 0;
        int j = 0;
        CusList.Columns.Add("don_gia", typeof(String));
        CusList.Columns.Add("total", typeof(String));
        CusList.Columns.Add("vatamount", typeof(String));
        CusList.Columns.Add("amount", typeof(String));
        if (CusList.Rows.Count > 0)
        {
            for (i = 0; i < CusList.Rows.Count; i++)
            {
                Double dntt = 0;
                int sh = 0;
                Double dongia = 0;
                Double total = 0;
                Double vatrate = 0;
                Double vatamount = 0;
                Double amount = 0; // amount = total + vatamount
                DataTable BangGia = myNCS.lay_bang_gia(CusList.Rows[i]["id_bang_gia"].ToString());
                dntt = Convert.ToDouble(CusList.Rows[i]["san_luong"].ToString());
                sh = Convert.ToInt32(CusList.Rows[i]["so_ho"].ToString());
                if (BangGia.Rows.Count == 1)
                {
                    vatrate = Convert.ToDouble(BangGia.Rows[0]["phan_tram_thue"].ToString());
                    dongia = Convert.ToDouble(BangGia.Rows[0]["don_gia"].ToString());
                    total = dntt * dongia;
                    vatamount = vatrate * total / 100;
                    amount = total + vatamount;
                }
                else
                {
                    Double[] muc = myNCS.tinh_cs_6_muc(dntt, sh);
                    Double[] dongiamuc = new Double[] { };

                    for (j = 0; j < muc.Length; j++)
                    {
                        total = total + (muc[j] * Convert.ToDouble(BangGia.Rows[j]["gia_ko_vat"].ToString()));
                        vatrate = Convert.ToDouble(BangGia.Rows[0]["phan_tram_thue"].ToString());

                    }

                }

                vatamount = vatrate * total / 100;
                amount = total + vatamount;
                CusList.Rows[i]["don_gia"] = dongia.ToString();
                CusList.Rows[i]["total"] = total.ToString();
                CusList.Rows[i]["vatamount"] = vatamount.ToString();
                CusList.Rows[i]["amount"] = amount.ToString();
            }
        }
        return CusList;
    }

    protected void btnLaySL_Click(object sender, EventArgs e)
    {
        string id_tram = drpTram.SelectedValue.ToString();
        string kyhd = drpKy.SelectedItem.ToString();
        gv_bind(id_tram, kyhd);
    }

    protected void btnChotSL_Click(object sender, EventArgs e)
    {
        string id_tram = drpTram.SelectedValue.ToString();
        string kyhd = drpKy.SelectedItem.ToString();
        string tungay = myNCS.lay_tungay_denngay(kyhd).Rows[0]["tu_ngay"].ToString().Substring(0, 10);
        string denngay = myNCS.lay_tungay_denngay(kyhd).Rows[0]["den_ngay"].ToString().Substring(0, 10);
        string user = Context.User.Identity.Name.ToString();
        DataTable dtbInv = dtb_bind(id_tram, kyhd);
        int i = 0;
        if (dtbInv.Rows.Count > 0)
        {
            do
            {
                //int j = i;
                string makh = dtbInv.Rows[i]["ma_kh"].ToString();
                string mact = "";
                string soho = dtbInv.Rows[i]["so_ho"].ToString();
                string cscu = dtbInv.Rows[i]["cs_cu"].ToString();
                string csmoi = dtbInv.Rows[i]["cs_moi"].ToString();
                string dongia = dtbInv.Rows[i]["don_gia"].ToString();
                Double dntt = 0;
                Double total = 0;
                Double vatamount = 0;
                Double amount = 0;
                string idKhu = dtbInv.Rows[i]["id_khu"].ToString();
                string idTram = dtbInv.Rows[i]["id_tram_bien_ap"].ToString();
                string idBangGia = dtbInv.Rows[i]["id_bang_gia"].ToString();
               
                total = Convert.ToDouble(dtbInv.Rows[i]["total"].ToString());
                vatamount = Convert.ToDouble(dtbInv.Rows[i]["vatamount"].ToString());
                amount = Convert.ToDouble(dtbInv.Rows[i]["amount"].ToString());
                dntt = Convert.ToDouble(dtbInv.Rows[i]["san_luong"].ToString());
                mact = dtbInv.Rows[i]["ma_cong_to"].ToString();

                Int64 idHD = myNCS.lay_idhd();
                if (i > 0)
                {
                    if (i < dtbInv.Rows.Count && string.Compare(dtbInv.Rows[i]["ma_kh"].ToString(), dtbInv.Rows[i - 1]["ma_kh"].ToString()) == 0)
                    {
                        idHD = idHD - 1;
                    }
                }
                i++;
                myNCS.them_moi_hoa_don(idHD, makh, kyhd, tungay, denngay, cscu, csmoi, dntt.ToString(),dongia, total, vatamount, amount, user, idBangGia, mact);
                myNCS.chotchiso(mact, kyhd);
            } while (i < dtbInv.Rows.Count);
        }
        else
        {
            txtErr.Text = "Không có dữ liệu";
        }

    }

    protected void ThemKyHD(object sender, EventArgs e)
    {
        string tungay = Request.Form["strTuNgay"].ToString();
        string denngay = Request.Form["strDenNgay"].ToString();
        string kyhd = Request.Form["strKyHD"].ToString();
        int i = 0;
        if (tungay != "-1" && denngay != "-1")
        {
            int inttungay = Convert.ToInt32(tungay);
            int intdenngay = Convert.ToInt32(denngay);
            if (inttungay > intdenngay)
            {
                txtErr.Text = "Thời gian từ ngày phải nhỏ hơn đến ngày";
            }
            else
            {
                string tungay1 = tungay.Substring(0, 4) + "-" + tungay.Substring(4, 2) + "-" + tungay.Substring(6, 2);
                string denngay1 = denngay.Substring(0, 4) + "-" + denngay.Substring(4, 2) + "-" + denngay.Substring(6, 2);
                string thang = kyhd.Substring(0, 2);
                int intthang = Convert.ToInt32(thang) + 1;
                if (intthang < 10)
                {
                    thang = "0" + intthang.ToString();
                }
                string nam = kyhd.Substring(3, 4);
                kyhd = thang + "/" + nam;
                int result = myNCS.them_kyhd(kyhd, thang, nam, tungay1, denngay1);
                if (result == 1)
                {
                    string kycu = ddlKyCu.SelectedItem.ToString();
                    CusList = myNCS.get_danh_sach_nhap_cs("0", kycu);
                    for (i = 0; i < CusList.Rows.Count; i++)
                    {
                        string mact = CusList.Rows[i]["ma_cong_to"].ToString();
                        string csmoi = CusList.Rows[i]["cs_moi"].ToString();
                        if (csmoi != "")
                        {
                            if (myNCS.check_cs_ct(mact, kyhd) < 1)
                            {
                                result = myNCS.them_chi_so_ky_moi(mact, csmoi, kyhd);
                                if (result == 0)
                                {
                                    lblErr.Text = "Có lỗi xảy ra trong quá trình khởi tạo dữ liệu kỳ sau mã công tơ " + mact;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (result == 1)
                {
                    Response.Redirect("NhapChiSo.aspx");
                }

            }
        }

    }

}