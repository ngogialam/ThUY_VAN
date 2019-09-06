using System;
using System.Data;
using DevExpress.XtraReports.UI;

public partial class DSChotChiSoDetail : System.Web.UI.Page
{
    clsBaocao myCus = new clsBaocao();

    protected void Page_Load(object sender, System.EventArgs e)
    {
        reportSo.Report = createReport();

    }
    public XtraReport createReport()
    {
        ChotChiSoCtoReport rpt = new ChotChiSoCtoReport(); // đối tượng này là report
        DataTable fixDs = new DataTable();
        DataTable ds = new DataTable();
        try
        {
            fixDs = (DataTable)Session["DSChotChiSoCtoTable"];
            rpt.AddBindings(Session["DSChotChiSoCtoTenXomKhu"].ToString(), Session["DSChotChiSoCtoTenTramBA"].ToString(), Session["DSChotChiSoCtoQuyNam"].ToString(), Session["DSChotChiSoCtoNgayIn"].ToString(), Session["TenDoanhNghiep"].ToString());
            rpt.DataSource = fixDs;
        }
        catch (Exception e)
        {
            rpt.AddBindings("", "", "", "", "");
        }

        return rpt;
    }
}
