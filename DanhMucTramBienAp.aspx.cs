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

public partial class DanhMucTramBienAp : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();
    clsConnect myCon = new clsConnect();
    DataTable CusList = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv_bind();
        }

    }
    protected void gv_bind()
    {
        CusList = myCus.get_danh_muc_tram_bien_ap();
        GirdView.DataSource = CusList;
        GirdView.DataBind();
        GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
    }

    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        Label id = (Label)row.FindControl("lblId");
        Label tenTramBienAp = (Label)row.FindControl("lblTenTramBienAp");
        Label diaChi = (Label)row.FindControl("lblDiaChi");
        Label nguoiPT = (Label)row.FindControl("lblNguoiPhuTrach");
        Label maCongTo = (Label)row.FindControl("lblMaCongTo");
        Label heSoNhan = (Label)row.FindControl("lblHeSoNhan");
        Label trangThai = (Label)row.FindControl("lblTrangThai");

        if (e.CommandName == "suaTramBienAp")
        {
            //DataTable DiaBanList = myCus.get_dia_ban();
            txtId.Text = id.Text;
            txtTenTramBA.Text = tenTramBienAp.Text;
            txtDiaChi.Text = diaChi.Text;
            txtNguoiPT.Text = nguoiPT.Text;
            txtMaSoCT.Text = maCongTo.Text;
            txtHeSoNhan.Text = heSoNhan.Text;
            
            //if (myCus.kt_trang_thai(Convert.ToInt32(id.Text)) == 1)
                //ckbTrangThai.Checked = true;
            //else
               // ckbTrangThai.Checked = false;
            //ckbTrangThai.Checked = trangThai.Text;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#EditModal').modal('show');");
            sb.Append(@"</script>");


            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal",
            sb.ToString(), false);
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        string idTramBA = txtId.Text;
        string tenTramBA = txtTenTramBA.Text;
        string diaChi = txtDiaChi.Text;
        string nguoiPT = txtNguoiPT.Text;
        string maSoCT = txtMaSoCT.Text;
        int heSoNhan = Convert.ToInt32(txtHeSoNhan.Text);
        string log = "Sửa trạm biến áp" + idTramBA;
        int trangThai = 0;
        if (ckbTrangThai.Checked == true) trangThai = 1;

        myCus.cap_nhat_tram_bien_ap(idTramBA, tenTramBA, diaChi, nguoiPT, maSoCT, heSoNhan, trangThai);
        myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");
        
        Response.Redirect("DanhMucTramBienAp.aspx");
    }
}