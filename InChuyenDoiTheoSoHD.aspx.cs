using System;
using System.Web.UI.WebControls;
using System.Data;
using NReco.PdfGenerator;
using System.IO;
public partial class InChuyenDoiTheoSoHD : System.Web.UI.Page
{

    HtmlToPdfConverter htmlToPdf = new HtmlToPdfConverter();
    clsHoaDon myINV = new clsHoaDon();
    clsNguoiBan mySeller = new clsNguoiBan();
    clsNhapChiSo myNCS = new clsNhapChiSo();
    DataTable invList = new DataTable();

    private static string adminName = "eman";
    private static string adminPass = "Einv@oi@vn#pt20";
    private static string userName = "emanws";
    private static string userPass = "Einv@oi@vn#pt20";
    private static string pattern = "1/001";
    //private static string serial = "TV/19E";


    protected void Page_Load(object sender, EventArgs e)
    {
        txtErr.Text = "";
        if (!IsPostBack)
        {

        }
    }


    protected void btnInLoHD_Click(object sender, EventArgs e)
    {
        string strTuso = txtTuSo.Text.ToString();
        string strDenso = txtDenSo.Text.ToString();
        int tuso = Convert.ToInt32(strTuso);
        int denso = Convert.ToInt32(strDenso);
        string serial = drpSerial.SelectedValue.ToString();
        int i;
        string InvToken;
        string htmlInv = "";
        for (i = tuso; i <= denso; i++)
        {
            InvToken = pattern + ";" +serial+";" + i.ToString();
            htmlInv = htmlInv + "<p style='page-break-after:always;'></p>" + myINV.PrintInvoiceByNo(InvToken, userName, userPass);
        }

        htmlToPdf.Orientation = PageOrientation.Portrait;
        htmlToPdf.Zoom = 1.13f;
        htmlToPdf.Size = NReco.PdfGenerator.PageSize.A4;
        var pdfBytes = htmlToPdf.GeneratePdf(htmlInv);
        // string pdffilename = "RepConvertInv\\inv_" + id_tram + "_" + kyhd.Replace("/", string.Empty) + ".pdf";
        string pdfdownloadname = "inv_" + strTuso + "_" + strDenso;
        // string zipfilename = "inv_" + id_tram + "_" + kyhd.Replace("/", string.Empty) + ".zip";
        Response.Clear();
        MemoryStream ms = new MemoryStream(pdfBytes);
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;filename=" + pdfdownloadname + ".pdf");
        Response.Buffer = true;
        ms.WriteTo(Response.OutputStream);
        Response.End();

        // Response.Redirect(pdffilename);
    }


}
