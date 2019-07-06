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
using System.Web.UI.HtmlControls;
public partial class QuanLyPhieuThu : System.Web.UI.Page
{
    clsBanHang myPOS = new clsBanHang();
    clsConnect myCon = new clsConnect();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable invList = myPOS.tracuugiaodich();

            GirdView.DataSource = invList;
            GirdView.DataBind();
            for (int i = 0; i < invList.Rows.Count; i++)
            {
                string status = invList.Rows[i]["ten_trangthai"].ToString();
                if (status == "Đã hủy")
                {
                    GirdView.Rows[i].Cells[10].CssClass = "label label-danger";

                    ///GirdView.Rows[i]..BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    GirdView.Rows[i].Cells[10].CssClass = "label label-success";
                }
            }
            GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
    protected void addRowSP(string stt, string sanpham, string dvt, string soluong)
    {
        HtmlTableRow row = new HtmlTableRow();
        HtmlTableCell tt = new HtmlTableCell();
        HtmlTableCell sp = new HtmlTableCell();
        HtmlTableCell dv = new HtmlTableCell();
        HtmlTableCell sl = new HtmlTableCell();
        HtmlTableCell bangchu = new HtmlTableCell();

        bangchu.Attributes.Add("class", "text-left");
        sp.Attributes.Add("class", "text-left");
        sl.Attributes.Add("class", "text-right");

        tt.InnerText = stt;
        sp.InnerText = sanpham;
        dv.InnerText = dvt;
        sl.InnerText = soluong;
        bangchu.InnerText = myPOS.NumberToTextVN(Convert.ToDecimal(soluong));

        row.Cells.Add(tt);
        row.Cells.Add(sp);
        row.Cells.Add(dv);
        row.Cells.Add(sl);
        row.Cells.Add(bangchu);
        row.Height = "20px";

        inDSSanPham.Rows.Add(row);

    }
    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        
        Label id = (Label)row.FindControl("lblSoHD");
        Label name = (Label)row.FindControl("lblTenKH");
        //Label bh = (Label)row.FindControl("lblTongBH");
        //Label bk2 = (Label)row.FindControl("lblTongBK2");
        //Label bk1 = (Label)row.FindControl("lblTongBK1");
        //Label bc = (Label)row.FindControl("lblTongBC");
        //Label ngayban = (Label)row.FindControl("lblNgayBan");
        if (e.CommandName ==  "huyHD")
        {           
            lblID.Text = id.Text;
            lblName.Text = name.Text;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#huyModal').modal('show');");
            sb.Append(@"</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal",
            sb.ToString(), false);          
        }
        if (e.CommandName == "inHD")
        {
            DataTable dtbInv = myPOS.layphieuthu(id.Text);
            int i = 0;
            inlblngaythang.Text = "Ngày " + dtbInv.Rows[0]["ngayban"].ToString().Substring(0, 2) + " tháng " + dtbInv.Rows[0]["ngayban"].ToString().Substring(3, 2) + " năm " + dtbInv.Rows[0]["ngayban"].ToString().Substring(6, 4);
            inlblSoPhieu.Text = id.Text;
            inlblName.Text = dtbInv.Rows[0]["ten_kh"].ToString();
            inlblDT.Text = dtbInv.Rows[0]["so_dt"].ToString();
            inlblDiaChi.Text = dtbInv.Rows[0]["dia_chi"].ToString();
            inlblDiaBan.Text = dtbInv.Rows[0]["ten_dia_ban"].ToString();
            string tongBH = dtbInv.Rows[0]["tong_bh"].ToString();
            string bk1 = dtbInv.Rows[0]["tong_bk1"].ToString();
            string bk2 = dtbInv.Rows[0]["tong_bk2"].ToString();
            string bc = dtbInv.Rows[0]["tong_bc"].ToString();
            if (tongBH != "" && tongBH != "0")
            {
                i++;
                addRowSP(i.ToString(), "Bia hơi", "Lít", tongBH);
            }
            if (bk1 != "" && bk1 != "0")
            {               
                i++;
                addRowSP(i.ToString(), "Bia keg 1L", "Keg", bk1);
            }
            if (bk2 != "" && bk2 != "0")
            {                
                i++;
                addRowSP(i.ToString(), "Bia keg 2L", "Keg", bk2);
            }
            if (bc != "" && bc != "0")
            {                
                i++;
                addRowSP(i.ToString(), "Bia chai 1L", "Chai", bc);
            }
            ScriptManager.RegisterClientScriptBlock(this,this.GetType(), "Print", "PrintPanel();", true);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string sophieu = lblID.Text;
        string log = "Hủy phiếu số " + sophieu;
        int recordsAffected = myPOS.huyphieu(sophieu);
         if (recordsAffected == 1)
            {
             myCon.save_log(Context.User.Identity.Name.ToString(),log,"3");
            }
        Response.Redirect("QuanLyPhieuThu.aspx");
    }
}
