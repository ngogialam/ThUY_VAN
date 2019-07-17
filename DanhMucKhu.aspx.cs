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

public partial class DanhMucKhu : System.Web.UI.Page
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
        CusList = myCus.get_danh_muc_khu();
        GirdView.DataSource = CusList;
        GirdView.DataBind();
        GirdView.HeaderRow.TableSection = TableRowSection.TableHeader;
    }

    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        Label id = (Label)row.FindControl("lblId");
        Label tenKhu = (Label)row.FindControl("lblTenKhu");
        Label idPhuongXa = (Label)row.FindControl("lblIdPhuongXa");

        if (e.CommandName == "suaDMKhu")
        {
            //DataTable DiaBanList = myCus.get_dia_ban();
            txtId.Text = id.Text;
            txtTenKhu.Text = tenKhu.Text;
            txtIdPhuongXa.Text = idPhuongXa.Text;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(@"<script type='text/javascript'>");
            sb.Append("$('#EditModal').modal('show');");
            sb.Append(@"</script>");


            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MyModal",
            sb.ToString(), false);
        }

    }
    //kiemtratrangthai

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id_bang_gia = Convert.ToInt32(txtId.Text);
        string log = "Sửa giá điện mã " + id_bang_gia;
        string ten_khu = txtTenKhu.Text;
        int id_phuong_xa = Convert.ToInt32(txtIdPhuongXa.Text);

        //myCus.cap_nhat_gia_dien(id_bang_gia, ten_bang_gia, ten_viet_tat, don_gia, tien_thue_vat, phan_tram_thue, gia_ban, kich_hoat);
        //myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");

        Response.Redirect("DanhMucTramBienAp.aspx");
    }

    //validate
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int n = int.Parse(args.Value);
        if ((n == 0) || (n == 1))
            args.IsValid = true;
        else
            args.IsValid = false;
    }

}
