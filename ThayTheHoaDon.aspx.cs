using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NReco.PdfGenerator;
using System.IO;
public partial class ThayTheHoaDon : System.Web.UI.Page
{
    private static string adminName = "htxthuyvanadmin";
    private static string adminPass = "123456aA@";
    private static string userName = "thuyvanws";
    private static string userPass = "123456aA@";
    private static string pattern = "01GTKT0/001";
    private static string serial = "TV/19E";

    HtmlToPdfConverter htmlToPdf = new HtmlToPdfConverter();
    clsHoaDon myINV = new clsHoaDon();
    clsNguoiBan mySeller = new clsNguoiBan();
    clsNhapChiSo myNCS = new clsNhapChiSo();
    clsBaocao myBC = new clsBaocao();
    clsConnect myCon = new clsConnect();
    DataTable invList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        txtErr.Text = "";
        if (!IsPostBack)
        {

        }
    }

    protected void btnLaySoLieu_Click(object sender, EventArgs e)
    {

        string strSoHD = txtSoHD.Text.ToString();
        if (!string.IsNullOrEmpty(strSoHD))
        {
            //  string strDenso = txtDenSo.Text.ToString();
            DataTable invReplace = myINV.get_hddt_theo_so_hd(strSoHD, pattern, serial);
            GirdViewReplace.DataSource = invReplace;
            GirdViewReplace.DataBind();
            if (GirdViewReplace.Rows.Count > 0)
            {
                GirdViewReplace.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
        }
    }

    protected void GirdViewReplace_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        DataTable bang_gia_dien = myBC.get_bang_gia_dien();
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DropDownList DDBangGia = (e.Row.FindControl("drpBangGia") as DropDownList);
            Label idBG = (e.Row.FindControl("idBangGia") as Label);
            DDBangGia.DataSource = bang_gia_dien;
            DDBangGia.DataBind();
            DDBangGia.SelectedValue = idBG.Text.ToString();

        }

    }
    protected void updateChange()
    {
        // Thông tin cũ
        string fkey_cu = (GirdViewReplace.Rows[0].FindControl("lblID") as Label).Text.ToString();
        string mau_so = (GirdViewReplace.Rows[0].FindControl("lblMauSo") as Label).Text.ToString();
        string ky_hieu = (GirdViewReplace.Rows[0].FindControl("lblKyHieu") as Label).Text.ToString();
        string ky = (GirdViewReplace.Rows[0].FindControl("idBangGia") as Label).Text.ToString();
        string makh = (GirdViewReplace.Rows[0].FindControl("lblMaKH") as Label).Text.ToString();
        string idtram_ba = (GirdViewReplace.Rows[0].FindControl("idTramBA") as Label).Text.ToString();
        string id_khu = (GirdViewReplace.Rows[0].FindControl("idKhu") as Label).Text.ToString();

        //Thông tin mới
        string tenkhnew = (GirdViewReplace.Rows[0].FindControl("lblTenKH") as TextBox).Text.ToString();
        int sohonew = Convert.ToInt16((GirdViewReplace.Rows[0].FindControl("lblSoHo") as TextBox).Text.ToString());
        // Double cs_moinew = ;
        DropDownList DDBangGia = (GirdViewReplace.Rows[0].FindControl("drpBangGia") as DropDownList);
        string id_bg_new = DDBangGia.SelectedValue.ToString();

        Double dntt = 0;

        Double total = 0;
        Double vatamount = 0;
        Double amount = 0; // amount = total + vatamount

        Double vatrate = 10;
        int i = 0;
        Double cs_cu = 0;
        Double cs_moi = 0;
        do
        {
            cs_cu = cs_cu + Convert.ToDouble((GirdViewReplace.Rows[i].FindControl("lblCSCu") as Label).Text.ToString());

            cs_moi = cs_moi + Convert.ToDouble((GirdViewReplace.Rows[i].FindControl("txtCSMoi") as TextBox).Text.ToString());
            i++;
        } while (i < GirdViewReplace.Rows.Count && string.Compare((GirdViewReplace.Rows[i].FindControl("lblMaKH") as Label).Text.ToString(), (GirdViewReplace.Rows[i - 1].FindControl("lblMaKH") as Label).Text.ToString()) == 0);

        dntt = cs_moi - cs_cu;
        total = myNCS.tinh_tien_dien(dntt, sohonew, id_bg_new);
        vatamount = vatrate * total / 100;
        //Làm tròn
        vatamount = Math.Round(vatamount, 0, MidpointRounding.AwayFromZero);
        amount = total + vatamount;

        (GirdViewReplace.Rows[0].FindControl("lblAmount") as Label).Text = amount.ToString("###,0");
        (GirdViewReplace.Rows[0].FindControl("lblDienNangTT") as Label).Text = dntt.ToString();

    }

    protected void drpBangGia_SelectedIndexChanged(object sender, EventArgs e)
    {
        updateChange();
    }
    protected void txtCSMoi_TextChanged(object sender, EventArgs e)
    {
        updateChange();
    }
    protected void lblSoHo_TextChanged(object sender, EventArgs e)
    {
        updateChange();
    }

    protected void btnPhatHanhHD_Click(object sender, EventArgs e)
    {
        string fkey_cu = (GirdViewReplace.Rows[0].FindControl("lblID") as Label).Text.ToString();
        string sohd_cu = (GirdViewReplace.Rows[0].FindControl("lblSoHD") as Label).Text.ToString();
        string mau_so = (GirdViewReplace.Rows[0].FindControl("lblMauSo") as Label).Text.ToString();
        string ky_hieu = (GirdViewReplace.Rows[0].FindControl("lblKyHieu") as Label).Text.ToString();
        string ky = (GirdViewReplace.Rows[0].FindControl("lblKy") as Label).Text.ToString();
        string makh = (GirdViewReplace.Rows[0].FindControl("lblMaKH") as Label).Text.ToString();
        string idtram_ba = (GirdViewReplace.Rows[0].FindControl("idTramBA") as Label).Text.ToString();
        string id_khu = (GirdViewReplace.Rows[0].FindControl("idKhu") as Label).Text.ToString();

        //Thông tin mới
        string tenkhnew = (GirdViewReplace.Rows[0].FindControl("lblTenKH") as TextBox).Text.ToString();
        int sohonew = Convert.ToInt16((GirdViewReplace.Rows[0].FindControl("lblSoHo") as TextBox).Text.ToString());
        DropDownList DDBangGia = (GirdViewReplace.Rows[0].FindControl("drpBangGia") as DropDownList);
        string id_bg_new = DDBangGia.SelectedValue.ToString();        
        Int64 idhdmoi = myNCS.lay_idhd();
        string fkey_moi = idhdmoi.ToString();
        //DTB hóa đơn thay thế
        DataTable invReplace = myINV.get_hddt_theo_so_hd(sohd_cu, pattern, serial);
        
        //Thông tin thêm hóa đơn
        string tungay = myNCS.lay_tungay_denngay(ky).Rows[0]["tu_ngay"].ToString().Substring(0, 10);
        string denngay = myNCS.lay_tungay_denngay(ky).Rows[0]["den_ngay"].ToString().Substring(0, 10);
        string user = Context.User.Identity.Name.ToString();
     

        //Cập nhật tenekh, số hộ, bảng giá
       myINV.updateKHreplace(makh, tenkhnew, sohonew.ToString(), id_bg_new);


        //Cập nhật chỉ số
        int i = 0;
        do
        {
            string cs_moi = (GirdViewReplace.Rows[i].FindControl("txtCSMoi") as TextBox).Text.ToString();
            string mact = (GirdViewReplace.Rows[i].FindControl("lblMaCT") as Label).Text.ToString();
            myNCS.cap_nhat_chi_so(mact, cs_moi, ky);


            invReplace.Rows[i]["ten_kh"] = tenkhnew;
            invReplace.Rows[i]["so_ho"] = sohonew;
            invReplace.Rows[i]["chi_so_moi"] = cs_moi;
            invReplace.Rows[i]["id"] = fkey_moi;
            i++;
        } while (i < GirdViewReplace.Rows.Count && string.Compare((GirdViewReplace.Rows[i].FindControl("lblMaKH") as Label).Text.ToString(), (GirdViewReplace.Rows[i - 1].FindControl("lblMaKH") as Label).Text.ToString()) == 0);

        Double dntt = Convert.ToDouble((GirdViewReplace.Rows[0].FindControl("lblDienNangTT") as Label).Text.ToString());
      
        Double total = myNCS.tinh_tien_dien(dntt, sohonew, id_bg_new);
        Double vatamount = 10 * total / 100;
        //Làm tròn
        vatamount = Math.Round(vatamount, 0, MidpointRounding.AwayFromZero);
        Double amount = total + vatamount;

        invReplace.Rows[0]["dien_nang_tt"] = dntt.ToString();
        invReplace.Rows[0]["tong_tien_truoc_thue"] = total;
        invReplace.Rows[0]["vat_rate"] = "10";
        invReplace.Rows[0]["thue_gtgt"] = vatamount;
        invReplace.Rows[0]["tong_tien_sau_thue"] = amount;
         i = 0;
        if (invReplace.Rows.Count > 0)
        {
            do
            {
                int recordsAffected = 0;               
                string mact = "";
                int soho = Convert.ToInt32(invReplace.Rows[i]["so_ho"].ToString());
                string cscuReplace = invReplace.Rows[i]["chi_so_cu"].ToString();
                string csmoiReplace = invReplace.Rows[i]["chi_so_moi"].ToString();

                mact = invReplace.Rows[i]["ma_cong_to"].ToString();
                string idKhu = invReplace.Rows[i]["id_khu"].ToString();
                string idTram = invReplace.Rows[i]["id_tram_bien_ap"].ToString();
                
                string vaterate = invReplace.Rows[i]["vat_rate"].ToString();
                string ten_kh = invReplace.Rows[i]["ten_kh"].ToString();
                

                if (invReplace.Rows[i]["tong_tien_truoc_thue"].ToString() == "")
                {
                    invReplace.Rows[i]["tong_tien_truoc_thue"] = "0";
                }
                if (invReplace.Rows[i]["thue_gtgt"].ToString() == "")
                {
                    invReplace.Rows[i]["thue_gtgt"] = "0";
                }
                if (invReplace.Rows[i]["tong_tien_sau_thue"].ToString() == "")
                {
                    invReplace.Rows[i]["tong_tien_sau_thue"] = "0";
                }
                if (invReplace.Rows[i]["dien_nang_tt"].ToString() == "")
                {
                    invReplace.Rows[i]["dien_nang_tt"] = "0";
                }

                Double totalINV = Convert.ToDouble(invReplace.Rows[i]["tong_tien_truoc_thue"].ToString());
                Double vatamountINV = Convert.ToDouble(invReplace.Rows[i]["thue_gtgt"].ToString());
                Double amountINV = Convert.ToDouble(invReplace.Rows[i]["tong_tien_sau_thue"].ToString());
                Double dnttINV = Convert.ToDouble(invReplace.Rows[i]["dien_nang_tt"].ToString());


                myNCS.them_moi_hoa_don(idhdmoi, makh, ky, tungay, denngay, cscuReplace, csmoiReplace, dnttINV.ToString(), totalINV, vaterate, vatamountINV, amountINV, user, id_bg_new, mact, soho, ten_kh, idTram, idKhu);
                i++;
            } while (i < invReplace.Rows.Count);
         }
        myNCS.them_moi_hoa_don_chi_tiet(idhdmoi, dntt, sohonew, id_bg_new);

        string xmlData = myINV.ParseIInvoiceReplace(invReplace);

        try
        {
            if (xmlData != null)
            {
                BusinessInvWS.BusinessService service = new BusinessInvWS.BusinessService();

                var result = service.replaceInv(adminName, adminPass, xmlData, userName, userPass, fkey_cu,0);
                //  var result = service.ImportInv(xmlData, userName, userPass,0);
                if (result.StartsWith("OK:"))
                {
                    string[] ketqua = result.ToString().Split(';');
                    string[] invDatas = ketqua[2].Split('_');
                    string so_hd = invDatas[1];
                    string fkey = invDatas[0];
                    //cập nhật hóa đơn mới
                    myINV.updateEInvoice(fkey, ky, so_hd, pattern, serial,"2");
                    //Cập nhật hóa đơn cũ
                    myINV.updateEInvoice(fkey_cu, ky, sohd_cu, pattern, serial, "3");
                    txtErr.Text = "Phát hành hóa đơn thành công. Số hóa đơn: "+so_hd;
                    string log = "Thay thế hóa đơn số " +sohd_cu+" bằng số " + so_hd;
                    myCon.save_log(user, log, "666");

                }
                else
                {
                    txtErr.Text = "Có lỗi xảy ra" + result;
                }


            }

            else
            {
                txtErr.Text = "Không có dữ liệu";
            }
        }
        catch (Exception ex)
        {
            txtErr.Text = "Có lỗi";
        }

    }
}
