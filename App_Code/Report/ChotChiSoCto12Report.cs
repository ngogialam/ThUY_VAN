using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for ChotChiSoCto12Report
/// </summary>
public class ChotChiSoCto12Report : DevExpress.XtraReports.UI.XtraReport
{
    private DetailBand Detail;
    private BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private TopMarginBand TopMargin;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRLabel xrLabel3;
    private XRLabel lblDonViBanDien;
    private XRLabel lblLoaiBaoCao;
    private XRLabel lblTenTram;
    private XRLabel lblQuyNam;
    private XRLabel lblNgayIn;
    private XRLabel lblTenXomKhu;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell lblStt;
    private XRTableCell lblMaKh;
    private XRTableCell lblTenKh;
    private XRTableCell lblDiaChi;
    private XRTableCell lblMaCto;
    private XRTableCell lblT7;
    private XRTableCell lblT8;
    private XRTableCell lblT9;
    private XRTableCell lblT10;
    private XRTableCell lblT11;
    private XRTableCell lblT12;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public ChotChiSoCto12Report()
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
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "ChotChiSoCto12Report.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblStt = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblMaKh = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTenKh = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblDiaChi = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblMaCto = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblT7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblT8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblT9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblT10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblT11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblT12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDonViBanDien = new DevExpress.XtraReports.UI.XRLabel();
            this.lblLoaiBaoCao = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenTram = new DevExpress.XtraReports.UI.XRLabel();
            this.lblQuyNam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNgayIn = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTenXomKhu = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1147.699F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UsePadding = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblStt,
            this.lblMaKh,
            this.lblTenKh,
            this.lblDiaChi,
            this.lblMaCto,
            this.lblT7,
            this.lblT8,
            this.lblT9,
            this.lblT10,
            this.lblT11,
            this.lblT12});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // lblStt
            // 
            this.lblStt.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblStt.Name = "lblStt";
            this.lblStt.StylePriority.UseFont = false;
            this.lblStt.StylePriority.UseTextAlignment = false;
            this.lblStt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblStt.Weight = 0.54727096305207745D;
            // 
            // lblMaKh
            // 
            this.lblMaKh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblMaKh.Name = "lblMaKh";
            this.lblMaKh.StylePriority.UseFont = false;
            this.lblMaKh.StylePriority.UseTextAlignment = false;
            this.lblMaKh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblMaKh.Weight = 0.82970266155470906D;
            // 
            // lblTenKh
            // 
            this.lblTenKh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblTenKh.Name = "lblTenKh";
            this.lblTenKh.StylePriority.UseFont = false;
            this.lblTenKh.StylePriority.UseTextAlignment = false;
            this.lblTenKh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblTenKh.Weight = 1.8434795898072081D;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.StylePriority.UseFont = false;
            this.lblDiaChi.StylePriority.UseTextAlignment = false;
            this.lblDiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblDiaChi.Weight = 1.6474615882287442D;
            // 
            // lblMaCto
            // 
            this.lblMaCto.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaCto.Name = "lblMaCto";
            this.lblMaCto.StylePriority.UseFont = false;
            this.lblMaCto.StylePriority.UseTextAlignment = false;
            this.lblMaCto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblMaCto.Weight = 1.0347011006643321D;
            // 
            // lblT7
            // 
            this.lblT7.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblT7.Name = "lblT7";
            this.lblT7.StylePriority.UseFont = false;
            this.lblT7.StylePriority.UseTextAlignment = false;
            this.lblT7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblT7.Weight = 1.0777113750671146D;
            // 
            // lblT8
            // 
            this.lblT8.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblT8.Name = "lblT8";
            this.lblT8.StylePriority.UseFont = false;
            this.lblT8.StylePriority.UseTextAlignment = false;
            this.lblT8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblT8.Weight = 1.0777112447666877D;
            // 
            // lblT9
            // 
            this.lblT9.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblT9.Name = "lblT9";
            this.lblT9.StylePriority.UseFont = false;
            this.lblT9.StylePriority.UseTextAlignment = false;
            this.lblT9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblT9.Weight = 1.0777112447666875D;
            // 
            // lblT10
            // 
            this.lblT10.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblT10.Name = "lblT10";
            this.lblT10.StylePriority.UseFont = false;
            this.lblT10.StylePriority.UseTextAlignment = false;
            this.lblT10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblT10.Weight = 1.0777112429538467D;
            // 
            // lblT11
            // 
            this.lblT11.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblT11.Name = "lblT11";
            this.lblT11.StylePriority.UseFont = false;
            this.lblT11.StylePriority.UseTextAlignment = false;
            this.lblT11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblT11.Weight = 1.0777112420474269D;
            // 
            // lblT12
            // 
            this.lblT12.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblT12.Name = "lblT12";
            this.lblT12.StylePriority.UseFont = false;
            this.lblT12.StylePriority.UseTextAlignment = false;
            this.lblT12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblT12.Weight = 1.0777112420474269D;
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
            this.xrTable3,
            this.xrLabel3,
            this.lblDonViBanDien,
            this.lblLoaiBaoCao,
            this.lblTenTram,
            this.lblQuyNam,
            this.lblNgayIn,
            this.lblTenXomKhu});
            this.PageHeader.HeightF = 169.7088F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable3
            // 
            this.xrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 139.7088F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1147.699F, 30F);
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
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell14,
            this.xrTableCell16,
            this.xrTableCell12,
            this.xrTableCell13});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "  TT\r\n";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 9.3621035544653353D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.CanGrow = false;
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "  Mã KH";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 14.193610722405209D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.CanGrow = false;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "  Họ tên";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 31.536154470199037D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "  Địa chỉ";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 28.182918501575873D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.CanGrow = false;
            this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "  Mã công tơ";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell15.Weight = 17.700509740067154D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.CanGrow = false;
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "  T7";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 18.436273538853797D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "  T8";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 18.436269425180605D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.CanGrow = false;
            this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = "  T9\r\n";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell14.Weight = 18.43627218586516D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.CanGrow = false;
            this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "  T10\r\n";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell16.Weight = 18.436272185865157D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.CanGrow = false;
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "  T11";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell12.Weight = 18.43627223833235D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.CanGrow = false;
            this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "  T12";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell13.Weight = 18.436284897516103D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(441F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "ĐƠN VỊ QUẢN LÝ BÁN ĐIỆN";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblDonViBanDien
            // 
            this.lblDonViBanDien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.lblDonViBanDien.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 23.00002F);
            this.lblDonViBanDien.Multiline = true;
            this.lblDonViBanDien.Name = "lblDonViBanDien";
            this.lblDonViBanDien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDonViBanDien.SizeF = new System.Drawing.SizeF(441F, 23.00001F);
            this.lblDonViBanDien.StylePriority.UseFont = false;
            this.lblDonViBanDien.StylePriority.UseTextAlignment = false;
            this.lblDonViBanDien.Text = "\r\n";
            this.lblDonViBanDien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblLoaiBaoCao
            // 
            this.lblLoaiBaoCao.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblLoaiBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 57.16073F);
            this.lblLoaiBaoCao.Multiline = true;
            this.lblLoaiBaoCao.Name = "lblLoaiBaoCao";
            this.lblLoaiBaoCao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLoaiBaoCao.SizeF = new System.Drawing.SizeF(1154F, 23F);
            this.lblLoaiBaoCao.StylePriority.UseFont = false;
            this.lblLoaiBaoCao.StylePriority.UseTextAlignment = false;
            this.lblLoaiBaoCao.Text = "DANH SÁCH CHỐT CHỈ SỐ CÔNG TƠ";
            this.lblLoaiBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblTenTram
            // 
            this.lblTenTram.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenTram.LocationFloat = new DevExpress.Utils.PointFloat(0F, 98.09946F);
            this.lblTenTram.Name = "lblTenTram";
            this.lblTenTram.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenTram.SizeF = new System.Drawing.SizeF(219.7917F, 23F);
            this.lblTenTram.StylePriority.UseFont = false;
            this.lblTenTram.StylePriority.UseTextAlignment = false;
            this.lblTenTram.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblQuyNam
            // 
            this.lblQuyNam.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuyNam.LocationFloat = new DevExpress.Utils.PointFloat(266.4492F, 98.09946F);
            this.lblQuyNam.Name = "lblQuyNam";
            this.lblQuyNam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblQuyNam.SizeF = new System.Drawing.SizeF(331.2501F, 23F);
            this.lblQuyNam.StylePriority.UseFont = false;
            this.lblQuyNam.StylePriority.UseTextAlignment = false;
            this.lblQuyNam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblNgayIn
            // 
            this.lblNgayIn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblNgayIn.LocationFloat = new DevExpress.Utils.PointFloat(647.6992F, 98.09946F);
            this.lblNgayIn.Name = "lblNgayIn";
            this.lblNgayIn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNgayIn.SizeF = new System.Drawing.SizeF(219.7917F, 23F);
            this.lblNgayIn.StylePriority.UseFont = false;
            this.lblNgayIn.StylePriority.UseTextAlignment = false;
            this.lblNgayIn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTenXomKhu
            // 
            this.lblTenXomKhu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenXomKhu.LocationFloat = new DevExpress.Utils.PointFloat(934.1575F, 98.09946F);
            this.lblTenXomKhu.Name = "lblTenXomKhu";
            this.lblTenXomKhu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenXomKhu.SizeF = new System.Drawing.SizeF(213.5414F, 23F);
            this.lblTenXomKhu.StylePriority.UseFont = false;
            this.lblTenXomKhu.StylePriority.UseTextAlignment = false;
            this.lblTenXomKhu.Text = "Khu: ";
            this.lblTenXomKhu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(704.4065F, 14.83335F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(448.5266F, 22.99998F);
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
            this.xrLabel2.SizeF = new System.Drawing.SizeF(402.2761F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Người lập biểu";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ChotChiSoCto12Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(15, 0, 27, 27);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "12.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    public void AddBindings(string tenXomKhu, string tenTramBA, string quyNam, string ngayIn, string tenDonViBanDien)
    {
        lblTenXomKhu.Text = tenXomKhu.Trim();
        lblQuyNam.Text = quyNam.Trim();
        lblNgayIn.Text = ngayIn.Trim();
        lblDonViBanDien.Text = tenDonViBanDien.Trim();
        lblTenTram.Text = tenTramBA.Trim();

        lblStt.DataBindings.Add("Text", DataSource, "stt");
        lblMaKh.DataBindings.Add("Text", DataSource, "ma_kh");
        lblTenKh.DataBindings.Add("Text", DataSource, "ten_kh");
        lblDiaChi.DataBindings.Add("Text", DataSource, "dia_chi");
        lblMaCto.DataBindings.Add("Text", DataSource, "ma_cong_to");
        lblT7.DataBindings.Add("Text", DataSource, "t7", "{0:#,# ;(#,#);0}");
        lblT8.DataBindings.Add("Text", DataSource, "t8", "{0:#,# ;(#,#);0}");
        lblT9.DataBindings.Add("Text", DataSource, "t9", "{0:#,# ;(#,#);0}");
        lblT10.DataBindings.Add("Text", DataSource, "t10", "{0:#,# ;(#,#);0}");
        lblT11.DataBindings.Add("Text", DataSource, "t11", "{0:#,# ;(#,#);0}");
        lblT12.DataBindings.Add("Text", DataSource, "t12", "{0:#,# ;(#,#);0}");

    }
}
