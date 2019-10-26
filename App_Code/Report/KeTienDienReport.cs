using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for KeTienDienReport
/// </summary>
public class KeTienDienReport : DevExpress.XtraReports.UI.XtraReport
{
    private XRTableCell lblMaKh;
    private XRTableCell lblDiaChi;
    private XRTableCell lblChiSoCu;
    private XRTableRow xrTableRow1;
    private XRTableCell lblStt;
    private XRTableCell lblTenKh;
    private XRTableCell lblTienSauThue;
    private XRTableCell lblMaCT;
    private XRTableCell lblChiSoMoi;
    private XRTableCell lblSoHo;
    private DetailBand Detail;
    private XRTable xrTable1;
    private BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private TopMarginBand TopMargin;
    private XRLabel xrLabel3;
    private XRLabel xrLabel5;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell21;
    private XRTableCell lblDienNangTT;
    private XRLabel lblTenTramBA;
    private XRLabel lblKyTramBA;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private ReportFooterBand ReportFooter;
    private XRLabel lblDonViBanDien;
    private XRLabel lblNgayIn;
    private XRLabel lblThangNam;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell33;
    private XRTableCell lblSh1;
    private XRTableCell lblSh2;
    private XRTableCell lblSh3;
    private XRTableCell lblSh4;
    private XRTableCell lblSh5;
    private XRTableCell lblSh6;
    private XRTableCell lblNT;
    private XRTableCell lblGhiChu;
    private XRTableCell lblBV;
    private XRTableCell lblKD;
    private XRTableCell lblCSCC;
    private XRTableCell lblTH;
    private XRTableCell lblHCSN;
    private XRTableCell lblBN;
    private XRTableCell lblSX;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public KeTienDienReport()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
            string resourceFileName = "KeTienDienReport.resx";
            System.Resources.ResourceManager resources = global::Resources.KeTienDienReport.ResourceManager;
            this.lblMaKh = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDiaChi = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblChiSoCu = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblStt = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTenKh = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTienSauThue = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblMaCT = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblChiSoMoi = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSoHo = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDienNangTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSh1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSh2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSh3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSh4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSh5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSh6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblNT = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblBV = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblKD = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblCSCC = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTH = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblHCSN = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblBN = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblSX = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGhiChu = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblNgayIn = new DevExpress.XtraReports.UI.XRLabel();
            this.lblThangNam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDonViBanDien = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKyTramBA = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenTramBA = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // lblMaKh
            // 
            this.lblMaKh.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaKh.Name = "lblMaKh";
            this.lblMaKh.StylePriority.UseFont = false;
            this.lblMaKh.StylePriority.UseTextAlignment = false;
            this.lblMaKh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblMaKh.Weight = 0.50495587538732123D;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.StylePriority.UseFont = false;
            this.lblDiaChi.StylePriority.UseTextAlignment = false;
            this.lblDiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDiaChi.Weight = 0.900688583745052D;
            // 
            // lblChiSoCu
            // 
            this.lblChiSoCu.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblChiSoCu.Name = "lblChiSoCu";
            this.lblChiSoCu.StylePriority.UseFont = false;
            this.lblChiSoCu.StylePriority.UseTextAlignment = false;
            this.lblChiSoCu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblChiSoCu.Weight = 0.29119108852490511D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblStt,
            this.lblTenKh,
            this.lblMaKh,
            this.lblDiaChi,
            this.lblTienSauThue,
            this.lblMaCT,
            this.lblChiSoCu,
            this.lblChiSoMoi,
            this.lblSoHo,
            this.lblDienNangTT,
            this.lblSh1,
            this.lblSh2,
            this.lblSh3,
            this.lblSh4,
            this.lblSh5,
            this.lblSh6,
            this.lblNT,
            this.lblBV,
            this.lblKD,
            this.lblCSCC,
            this.lblTH,
            this.lblHCSN,
            this.lblBN,
            this.lblSX,
            this.lblGhiChu});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.8D;
            // 
            // lblStt
            // 
            this.lblStt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblStt.Name = "lblStt";
            this.lblStt.StylePriority.UseFont = false;
            this.lblStt.Weight = 0.21687448590938158D;
            // 
            // lblTenKh
            // 
            this.lblTenKh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTenKh.Name = "lblTenKh";
            this.lblTenKh.StylePriority.UseFont = false;
            this.lblTenKh.StylePriority.UseTextAlignment = false;
            this.lblTenKh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblTenKh.Weight = 1.2204852027865214D;
            // 
            // lblTienSauThue
            // 
            this.lblTienSauThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTienSauThue.Name = "lblTienSauThue";
            this.lblTienSauThue.StylePriority.UseFont = false;
            this.lblTienSauThue.StylePriority.UseTextAlignment = false;
            this.lblTienSauThue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblTienSauThue.Weight = 0.60058312356497812D;
            // 
            // lblMaCT
            // 
            this.lblMaCT.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaCT.Name = "lblMaCT";
            this.lblMaCT.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.lblMaCT.StylePriority.UseFont = false;
            this.lblMaCT.StylePriority.UsePadding = false;
            this.lblMaCT.StylePriority.UseTextAlignment = false;
            this.lblMaCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblMaCT.Weight = 0.51282482659207074D;
            // 
            // lblChiSoMoi
            // 
            this.lblChiSoMoi.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblChiSoMoi.Name = "lblChiSoMoi";
            this.lblChiSoMoi.StylePriority.UseFont = false;
            this.lblChiSoMoi.StylePriority.UseTextAlignment = false;
            this.lblChiSoMoi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblChiSoMoi.Weight = 0.29119108781662939D;
            // 
            // lblSoHo
            // 
            this.lblSoHo.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSoHo.Name = "lblSoHo";
            this.lblSoHo.StylePriority.UseFont = false;
            this.lblSoHo.StylePriority.UseTextAlignment = false;
            this.lblSoHo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSoHo.Weight = 0.18199408267810224D;
            // 
            // lblDienNangTT
            // 
            this.lblDienNangTT.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblDienNangTT.Name = "lblDienNangTT";
            this.lblDienNangTT.StylePriority.UseFont = false;
            this.lblDienNangTT.StylePriority.UseTextAlignment = false;
            this.lblDienNangTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblDienNangTT.Weight = 0.29119110394754838D;
            // 
            // lblSh1
            // 
            this.lblSh1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSh1.Name = "lblSh1";
            this.lblSh1.StylePriority.UseFont = false;
            this.lblSh1.StylePriority.UseTextAlignment = false;
            this.lblSh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSh1.Weight = 0.29119110721703745D;
            // 
            // lblSh2
            // 
            this.lblSh2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSh2.Name = "lblSh2";
            this.lblSh2.StylePriority.UseFont = false;
            this.lblSh2.StylePriority.UseTextAlignment = false;
            this.lblSh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSh2.Weight = 0.29119109198962057D;
            // 
            // lblSh3
            // 
            this.lblSh3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSh3.Name = "lblSh3";
            this.lblSh3.StylePriority.UseFont = false;
            this.lblSh3.StylePriority.UseTextAlignment = false;
            this.lblSh3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSh3.Weight = 0.29119109160722723D;
            // 
            // lblSh4
            // 
            this.lblSh4.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSh4.Name = "lblSh4";
            this.lblSh4.StylePriority.UseFont = false;
            this.lblSh4.StylePriority.UseTextAlignment = false;
            this.lblSh4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSh4.Weight = 0.29119109141603106D;
            // 
            // lblSh5
            // 
            this.lblSh5.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSh5.Name = "lblSh5";
            this.lblSh5.StylePriority.UseFont = false;
            this.lblSh5.StylePriority.UseTextAlignment = false;
            this.lblSh5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSh5.Weight = 0.29119109132038268D;
            // 
            // lblSh6
            // 
            this.lblSh6.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSh6.Name = "lblSh6";
            this.lblSh6.StylePriority.UseFont = false;
            this.lblSh6.StylePriority.UseTextAlignment = false;
            this.lblSh6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSh6.Weight = 0.29119109127260845D;
            // 
            // lblNT
            // 
            this.lblNT.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblNT.Name = "lblNT";
            this.lblNT.StylePriority.UseFont = false;
            this.lblNT.StylePriority.UseTextAlignment = false;
            this.lblNT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblNT.Weight = 0.29119109124872156D;
            // 
            // lblBV
            // 
            this.lblBV.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblBV.Name = "lblBV";
            this.lblBV.StylePriority.UseFont = false;
            this.lblBV.StylePriority.UseTextAlignment = false;
            this.lblBV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblBV.Weight = 0.29119109123678411D;
            // 
            // lblKD
            // 
            this.lblKD.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblKD.Name = "lblKD";
            this.lblKD.StylePriority.UseFont = false;
            this.lblKD.StylePriority.UseTextAlignment = false;
            this.lblKD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblKD.Weight = 0.29119109122782194D;
            // 
            // lblCSCC
            // 
            this.lblCSCC.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblCSCC.Name = "lblCSCC";
            this.lblCSCC.StylePriority.UseFont = false;
            this.lblCSCC.StylePriority.UseTextAlignment = false;
            this.lblCSCC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblCSCC.Weight = 0.29119109122782183D;
            // 
            // lblTH
            // 
            this.lblTH.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTH.Name = "lblTH";
            this.lblTH.StylePriority.UseFont = false;
            this.lblTH.StylePriority.UseTextAlignment = false;
            this.lblTH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblTH.Weight = 0.29119110233588208D;
            // 
            // lblHCSN
            // 
            this.lblHCSN.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblHCSN.Name = "lblHCSN";
            this.lblHCSN.StylePriority.UseFont = false;
            this.lblHCSN.StylePriority.UseTextAlignment = false;
            this.lblHCSN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblHCSN.Weight = 0.29119108567219754D;
            // 
            // lblBN
            // 
            this.lblBN.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblBN.Name = "lblBN";
            this.lblBN.StylePriority.UseFont = false;
            this.lblBN.StylePriority.UseTextAlignment = false;
            this.lblBN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblBN.Weight = 0.29119108844871067D;
            // 
            // lblSX
            // 
            this.lblSX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSX.Name = "lblSX";
            this.lblSX.StylePriority.UseFont = false;
            this.lblSX.StylePriority.UseTextAlignment = false;
            this.lblSX.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblSX.Weight = 0.29119108983667197D;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.StylePriority.UseFont = false;
            this.lblGhiChu.Weight = 0.312469634314554D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 20F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.Scripts.OnBeforePrint = "Detail_BeforePrint";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1614.253F, 20F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UsePadding = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 27F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNgayIn,
            this.lblThangNam,
            this.lblDonViBanDien,
            this.lblKyTramBA,
            this.lblTenTramBA,
            this.xrTable3,
            this.xrLabel5,
            this.xrLabel3});
            this.PageHeader.HeightF = 259.4916F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblNgayIn
            // 
            this.lblNgayIn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblNgayIn.LocationFloat = new DevExpress.Utils.PointFloat(1021.749F, 98.19073F);
            this.lblNgayIn.Name = "lblNgayIn";
            this.lblNgayIn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNgayIn.SizeF = new System.Drawing.SizeF(219.7917F, 23F);
            this.lblNgayIn.StylePriority.UseFont = false;
            this.lblNgayIn.StylePriority.UseTextAlignment = false;
            this.lblNgayIn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblThangNam
            // 
            this.lblThangNam.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblThangNam.LocationFloat = new DevExpress.Utils.PointFloat(458.6209F, 98.19073F);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblThangNam.SizeF = new System.Drawing.SizeF(219.7917F, 23F);
            this.lblThangNam.StylePriority.UseFont = false;
            this.lblThangNam.StylePriority.UseTextAlignment = false;
            this.lblThangNam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblDonViBanDien
            // 
            this.lblDonViBanDien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblDonViBanDien.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 23F);
            this.lblDonViBanDien.Multiline = true;
            this.lblDonViBanDien.Name = "lblDonViBanDien";
            this.lblDonViBanDien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDonViBanDien.SizeF = new System.Drawing.SizeF(441.1428F, 23F);
            this.lblDonViBanDien.StylePriority.UseFont = false;
            this.lblDonViBanDien.StylePriority.UseTextAlignment = false;
            this.lblDonViBanDien.Text = "\r\n";
            this.lblDonViBanDien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblKyTramBA
            // 
            this.lblKyTramBA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblKyTramBA.LocationFloat = new DevExpress.Utils.PointFloat(1441.09F, 98.19072F);
            this.lblKyTramBA.Name = "lblKyTramBA";
            this.lblKyTramBA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblKyTramBA.SizeF = new System.Drawing.SizeF(173.1637F, 23F);
            this.lblKyTramBA.StylePriority.UseFont = false;
            this.lblKyTramBA.StylePriority.UseTextAlignment = false;
            this.lblKyTramBA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblTenTramBA
            // 
            this.lblTenTramBA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenTramBA.LocationFloat = new DevExpress.Utils.PointFloat(0.0001179803F, 98.19073F);
            this.lblTenTramBA.Name = "lblTenTramBA";
            this.lblTenTramBA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenTramBA.SizeF = new System.Drawing.SizeF(220.7286F, 23F);
            this.lblTenTramBA.StylePriority.UseFont = false;
            this.lblTenTramBA.StylePriority.UseTextAlignment = false;
            this.lblTenTramBA.Text = "Trạm : ";
            this.lblTenTramBA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 139.4916F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow2});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1614.253F, 120F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell15,
            this.xrTableCell17,
            this.xrTableCell21,
            this.xrTableCell19,
            this.xrTableCell27});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "TT\r\n";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 6.8655280774098246D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanGrow = false;
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Họ tên hộ sử dụng điện";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 38.6364663289254D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell3.CanGrow = false;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Mã khách hàng";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 15.98520636736297D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Địa chỉ";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 28.51275675371587D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.CanGrow = false;
            this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "Tổng tiền";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell15.Weight = 19.012443290423739D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.CanGrow = false;
            this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "Thành phần điện đầu nguồn";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell17.Weight = 49.650063214193978D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.CanGrow = false;
            this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "Sản lượng tiêu thụ điện Sinh Hoạt ở các mức (kWh)";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell21.Weight = 55.308795689914355D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.CanGrow = false;
            this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = "Sản lượng tiêu thụ điện Mục Đích Khác ở các mức (kWh)";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell19.Weight = 73.745065300802239D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.CanGrow = false;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Text = "Ghi chú";
            this.xrTableCell27.Weight = 9.8917304953120073D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell18,
            this.xrTableCell16,
            this.xrTableCell20,
            this.xrTableCell10,
            this.xrTableCell22,
            this.xrTableCell24,
            this.xrTableCell12,
            this.xrTableCell25,
            this.xrTableCell13,
            this.xrTableCell26,
            this.xrTableCell14,
            this.xrTableCell32,
            this.xrTableCell23,
            this.xrTableCell29,
            this.xrTableCell28,
            this.xrTableCell31,
            this.xrTableCell30,
            this.xrTableCell34,
            this.xrTableCell36,
            this.xrTableCell33});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.Weight = 6.8655287806975114D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.CanGrow = false;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.Weight = 38.636465625637719D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.Weight = 15.98520636736297D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.Weight = 28.512762380017364D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.CanGrow = false;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.Weight = 19.012437664122245D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.CanGrow = false;
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "Mã công tơ\r\n";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell18.Weight = 16.234333066423758D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell16.CanGrow = false;
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBorders = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "Chỉ số \r\nđầu";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell16.Weight = 9.2181325579682252D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.CanGrow = false;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "Chỉ số cuối";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell20.Weight = 9.218132206324384D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.CanGrow = false;
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Số \r\nhộ";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 5.7613318666083D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.CanGrow = false;
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.Text = "ĐNTT";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell22.Weight = 9.21813281358245D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.CanGrow = false;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.Text = "1678 đ/kWh";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell24.Weight = 9.21813245543857D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.CanGrow = false;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "1734 đ/kWh";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell12.Weight = 9.2181334439973046D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.CanGrow = false;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.Text = "2014 đ/kWh";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell25.Weight = 9.2181334439973046D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.CanGrow = false;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "2536 đ/kWh";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 9.21813245311264D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.CanGrow = false;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.Text = "2834 đ/kWh";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell26.Weight = 9.2181331564004338D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.CanGrow = false;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = "2927 đ/kWh";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell14.Weight = 9.2181335630413415D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell32.CanGrow = false;
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            this.xrTableCell32.Text = "2014 đ/kWh NT";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell32.Weight = 9.2181335630413415D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.CanGrow = false;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "1771 đ/kWh BV";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell23.Weight = 9.2181336677628565D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell29.CanGrow = false;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.Text = "2666 đ/kWh KD";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell29.Weight = 9.218133667762844D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.CanGrow = false;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.Text = "1902 đ/kWh CSCC";
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell28.Weight = 9.2181336677628458D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell31.CanGrow = false;
            this.xrTableCell31.Multiline = true;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseBorders = false;
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.Text = "1771 đ/kWh TH\r\n";
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell31.Weight = 9.2181337201236069D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell30.CanGrow = false;
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseBorders = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = "1902 đ/kWh HCSN";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell30.Weight = 9.2181337463039821D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell34.CanGrow = false;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseBorders = false;
            this.xrTableCell34.Text = "1685 đ/kWh BN";
            this.xrTableCell34.Weight = 9.2181323528186958D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell36.CanGrow = false;
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseBorders = false;
            this.xrTableCell36.Text = "1685 đ/kWh SX";
            this.xrTableCell36.Weight = 9.2181323593637785D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell33.CanGrow = false;
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseBorders = false;
            this.xrTableCell33.Weight = 9.8917269283879143D;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(460.5212F, 55.57928F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(812.1646F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "BẢNG KÊ TIỀN ĐIỆN HỘ THƯỜNG\r\n";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(441.1428F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "ĐƠN VỊ QUẢN LÝ BÁN ĐIỆN";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 27F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2});
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(964.2534F, 9.999974F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650.0001F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "CTHĐQT - GIÁM ĐỐC";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(37.23927F, 14.83339F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(608.7054F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Người lập biểu";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // KeTienDienReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(15, 1, 27, 27);
            this.PageHeight = 1268;
            this.PageWidth = 1752;
            this.PaperKind = System.Drawing.Printing.PaperKind.A3Extra;
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
    
    public void AddBindings(string tenTramBA, string kyTramBA, string thangNam, string ngayIn, string tenDonViBanDien)
    {
        lblTenTramBA.Text = tenTramBA.Trim();
        lblKyTramBA.Text = kyTramBA.Trim();
        lblThangNam.Text = thangNam.Trim();
        lblNgayIn.Text = ngayIn.Trim();
        lblDonViBanDien.Text = tenDonViBanDien.Trim();

        lblStt.DataBindings.Add("Text", DataSource, "stt");
        lblTenKh.DataBindings.Add("Text", DataSource, "ten_kh");
        lblMaKh.DataBindings.Add("Text", DataSource, "ma_kh");
        lblDiaChi.DataBindings.Add("Text", DataSource, "dia_chi");
        lblTienSauThue.DataBindings.Add("Text", DataSource, "tong_tien_sau_thue", "{0:#,# ;(#,#);0}");
        lblMaCT.DataBindings.Add("Text", DataSource, "ma_cong_to");
        lblChiSoCu.DataBindings.Add("Text", DataSource, "chi_so_cu", "{0:#,# ;(#,#);0}");
        lblChiSoMoi.DataBindings.Add("Text", DataSource, "chi_so_moi", "{0:#,# ;(#,#);0}");
        lblSoHo.DataBindings.Add("Text", DataSource, "so_ho", "{0:#,# ;(#,#);0}");
        lblDienNangTT.DataBindings.Add("Text", DataSource, "dien_nang_tt", "{0:#,# ;(#,#);0}");
        lblSh1.DataBindings.Add("Text", DataSource, "sh1", "{0:#,# ;(#,#);0}");
        lblSh2.DataBindings.Add("Text", DataSource, "sh2", "{0:#,# ;(#,#);0}");
        lblSh3.DataBindings.Add("Text", DataSource, "sh3", "{0:#,# ;(#,#);0}");
        lblSh4.DataBindings.Add("Text", DataSource, "sh4", "{0:#,# ;(#,#);0}");
        lblSh5.DataBindings.Add("Text", DataSource, "sh5", "{0:#,# ;(#,#);0}");
        lblSh6.DataBindings.Add("Text", DataSource, "sh6", "{0:#,# ;(#,#);0}");
        lblNT.DataBindings.Add("Text", DataSource, "NT", "{0:#,# ;(#,#);0}");
        lblBV.DataBindings.Add("Text", DataSource, "BV", "{0:#,# ;(#,#);0}");
        lblKD.DataBindings.Add("Text", DataSource, "KD", "{0:#,# ;(#,#);0}");
        lblCSCC.DataBindings.Add("Text", DataSource, "CSCC", "{0:#,# ;(#,#);0}");
        lblTH.DataBindings.Add("Text", DataSource, "TH", "{0:#,# ;(#,#);0}");
        lblHCSN.DataBindings.Add("Text", DataSource, "HCSN", "{0:#,# ;(#,#);0}");
        lblBN.DataBindings.Add("Text", DataSource, "BN", "{0:#,# ;(#,#);0}");
        lblSX.DataBindings.Add("Text", DataSource, "SX", "{0:#,# ;(#,#);0}");
    }
}
