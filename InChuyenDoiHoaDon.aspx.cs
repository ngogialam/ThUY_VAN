using System;
using System.Web.UI.WebControls;
using System.Data;

public partial class InChuyenDoiHoaDon : System.Web.UI.Page
{
    private static string adminName = "htxthanhdinhadmin";
    private static string adminPass = "123456aA@";
    private static string userName = "thanhdinhws";
    private static string userPass = "123456aA@";
    private static string pattern = "01GTKT0/001";
    private static string serial = "TV/19E";

    IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
    clsHoaDon myINV = new clsHoaDon();
    clsNguoiBan mySeller = new clsNguoiBan();
    clsNhapChiSo myNCS = new clsNhapChiSo();
    DataTable invList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        txtErr.Text = "";
        if (!IsPostBack)
        {
            drpTram.DataSource = myNCS.get_danh_sach_tba_notall();
            drpTram.DataBind();

            drpKy.DataSource = myNCS.get_danhsach_ky();
            drpKy.DataBind();

            gv_bind();
        }
    }

    protected void gv_bind()
    {
        string id_tram = drpTram.SelectedValue.ToString();
        string kyhd = drpKy.SelectedItem.ToString();
        invList = myINV.get_danh_sach_hddt(id_tram, kyhd, "2");
        GridViewEman.DataSource = invList;
        GridViewEman.DataBind();

        if (invList.Rows.Count > 0)
        {
            GridViewEman.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected void btnInLoHD_Click(object sender, EventArgs e)
    {
        string id_tram = drpTram.SelectedValue.ToString();
        string kyhd = drpKy.SelectedItem.ToString();
        // Regex reg = new Regex("[*'\",_&#^@]");
        
        invList = myINV.get_danh_sach_hddt(id_tram, kyhd, "2");
        int i;
        string fkey;
        string htmlInv = "";
        for (i = 0; i < invList.Rows.Count; i++)
        {
            fkey = invList.Rows[i]["id"].ToString();
            htmlInv = htmlInv + "<p style='page-break-after:always;'></p>" + myINV.PrintInvoice(fkey, userName, userPass);
        }
        if (GridViewEman.Rows.Count > 0)
        {
            GridViewEman.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        var pdf = Renderer.RenderHtmlAsPdf(htmlInv);
        string pdffilename = "RepConvertInv\\inv_" + id_tram + "_" + kyhd.Replace("/", string.Empty) + ".pdf";
        //string pdfdownloadname = "inv_" + id_tram + "_" + kyhd.Replace("/", string.Empty) + ".pdf";
        pdf.SaveAs(Server.MapPath(pdffilename));
        string zipfilename = "inv_" + id_tram + "_" + kyhd.Replace("/", string.Empty) + ".zip";

        //using (ZipFile zip = new ZipFile())
        //{
        //    zip.AddFile(pdfdownloadname);//Zip file inside filename  
        //    zip.Save(Response.OutputStream);//location and name for creating zip file  
        //}

        //Response.ContentType = "application/pdf";
        //Response.AddHeader("Content-Disposition", @"attachment;filename=" + zipfilename);
        Response.Redirect(pdffilename);
    }

    protected void drpTram_SelectedIndexChanged(object sender, EventArgs e)
    {
        gv_bind();
    }
}
