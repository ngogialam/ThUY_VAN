using System;
using System.Web.UI.WebControls;
using System.Data;
using NReco.PdfGenerator;
using System.IO;
public partial class InChuyenDoiTheoSoHD : System.Web.UI.Page
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
    DataTable invList = new DataTable();

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
        int i;
        string fkey;
        string htmlInv = "";
        for (i = tuso; i <= denso; i++)
        {
            fkey = i.ToString();
            htmlInv = htmlInv + "<p style='page-break-after:always;'></p>" + myINV.PrintInvoice(fkey, userName, userPass);          
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
