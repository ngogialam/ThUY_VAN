using System;
using System.Web.UI.WebControls;
using System.Data;

public partial class PhatHanhHD : System.Web.UI.Page
{
    private static string adminName = "htxthuyvanadmin";
    private static string adminPass = "123456aA@";
    private static string userName = "thuyvanws";
    private static string userPass = "123456aA@";
    private static string pattern = "01GTKT0/001";
    private static string serial = "TV/19E";

    clsHoaDon myINV = new clsHoaDon();
    clsNguoiBan mySeller = new clsNguoiBan();
    clsNhapChiSo myNCS = new clsNhapChiSo();
    DataTable invList = new DataTable();

    string sophieu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        txtErr.Text = "";
        if (!IsPostBack)
        {
            drpTram.DataSource = myNCS.get_danh_sach_tba();
            drpTram.DataBind();

            drpKy.DataSource = myNCS.get_danhsach_ky();
            drpKy.DataBind();
        }
    }
    protected void btnLaySL_Click(object sender, EventArgs e)
    {
        string id_tram = drpTram.SelectedValue.ToString();
        string kyhd = drpKy.SelectedItem.ToString();
        gv_bind(id_tram, kyhd);
        txtErr.Text = "";

    }
    protected void gv_bind(string id_tramba, string kyhd)
    {
        invList = myINV.get_du_lieu_hd(id_tramba, kyhd, "1");
        GirdViewNoPaGE.DataSource = invList;
        GirdViewNoPaGE.DataBind();

        if (invList.Rows.Count > 0)
        {
            GirdViewNoPaGE.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    

    protected void btnPhatHanh_Click(object sender, EventArgs e)
    {
        string id_tram = drpTram.SelectedValue.ToString();
        string kyhd = drpKy.SelectedItem.ToString();
        invList = myINV.get_du_lieu_hd(id_tram, kyhd, "1");
        string xmlData = myINV.ParseIInvoice(invList);
        int i = 0;
        try
        {
            if (xmlData != null)
            {
                PublishInvWS.PublishService service = new PublishInvWS.PublishService();
               
                var result = service.ImportAndPublishInv(adminName, adminPass, xmlData, userName, userPass, pattern, serial, 0);
              //  var result = service.ImportInv(xmlData, userName, userPass,0);
                if (result.StartsWith("OK:"))
                {
                    string[] ketqua = result.ToString().Split('-');
                    string[] FkeyLists = ketqua[1].ToString().Split(',');                    
                    foreach (string FkeyList in FkeyLists)
                    {
                        string[] invDatas = FkeyList.Split('_');
                        string fkey = invDatas[0];
                        string so_hd = invDatas[1];
                        myINV.updateEInvoice(fkey, kyhd, so_hd, pattern, serial);
                    }
                    txtErr.Text = "Phát hành "+FkeyLists.Length+" hóa đơn thành công";


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
