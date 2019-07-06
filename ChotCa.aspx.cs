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

public partial class ChotCa : System.Web.UI.Page
{
    clsBanHang myPOS = new clsBanHang();
    clsNguoiBan mySeller = new clsNguoiBan();
    DataTable invList = new DataTable();
    string sophieu = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        txtErr.Text = "";
        if (!IsPostBack)
        {
            txtErr.Text = "";
            invList = myPOS.phieuchuachotca();
            GirdViewNoPaGE.DataSource = invList;
            GirdViewNoPaGE.DataBind();
            for (int i = 0; i < invList.Rows.Count; i++)
            {
                string status = invList.Rows[i]["ten_trangthai"].ToString();
                if (status == "Đã hủy")
                {
                    GirdViewNoPaGE.Rows[i].Cells[8].CssClass = "label label-danger";
                    ///GirdView.Rows[i]..BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    GirdViewNoPaGE.Rows[i].Cells[8].CssClass = "label label-success";
                }
            }
            DataTable dtbNguoiBan = mySeller.get_danh_sach_nguoi_ban();           
            ddlNguoiBan.DataSource = dtbNguoiBan;           
            ddlNguoiBan.DataValueField = "ma_nguoiban";
            ddlNguoiBan.DataTextField = "ten_nguoiban";
            ddlNguoiBan.DataBind();

           GirdViewNoPaGE.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    protected void ChkBox_CheckedChanged(object sender, EventArgs e)
    {
        sophieu = "";
        for (int i = 0; i < GirdViewNoPaGE.Rows.Count; i++)
        {
            CheckBox chk = GirdViewNoPaGE.Rows[i].FindControl("ChkBox") as CheckBox;
            Label lblSoHD = (Label)GirdViewNoPaGE.Rows[i].FindControl("lblSoHD");
            if (chk.Checked)
            {
                if (sophieu == "")
                {
                    sophieu = lblSoHD.Text.ToString();
                }
                else
                {
                    sophieu = sophieu + "," + lblSoHD.Text.ToString();
                }
            }

        }
    }

    protected void btnChotCa_Click(object sender, EventArgs e)
    {
        string ca = ddlCa.SelectedValue;
        string nguoiban_id = ddlNguoiBan.SelectedValue;
        string nguoiban = ddlNguoiBan.SelectedItem.Text.ToString();
        if (ca == "0")
        {
            txtErr.CssClass = "badge badge-danger";
            txtErr.Text = "Bạn chưa chọn ca để chốt";
        }
        else
        {
            if (nguoiban_id == "0")
            {
                txtErr.CssClass = "badge badge-danger";
                txtErr.Text = "Bạn chưa chọn người bán";
            }
            else
            {
                if (sophieu == "")
                {
                    txtErr.CssClass = "badge badge-danger";
                    txtErr.Text = "Bạn chưa chọn phiếu thu nào để chốt ca";
                }
                else
                {
                    myPOS.chotca(sophieu, ca, nguoiban);
                    txtErr.CssClass = "badge badge-success";
                    txtErr.Text = "Chốt thành công các phiếu số " + sophieu + " vào ca " + ca;
                    invList = myPOS.phieuchuachotca();
                    GirdViewNoPaGE.DataSource = invList;
                    GirdViewNoPaGE.DataBind();
                    GirdViewNoPaGE.HeaderRow.TableSection = TableRowSection.TableHeader;
                }
            }
        }

    }
    
}
