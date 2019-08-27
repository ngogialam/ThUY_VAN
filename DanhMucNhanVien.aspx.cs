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

public partial class DanhMucNhanVien : System.Web.UI.Page
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
        CusList = myCus.get_danh_sach_nhan_vien();
        GridViewEman.DataSource = CusList;
        GridViewEman.DataBind();
        if (CusList.Rows.Count > 0)
        {
            GridViewEman.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    protected void GridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
        int index = row.RowIndex;
        Label maNV = (Label)row.FindControl("lblMaNV");
        Label tenNV = (Label)row.FindControl("lblTenNV");
        Label diaChi = (Label)row.FindControl("lblDiaChi");
        Label dienThoai = (Label)row.FindControl("lblDienThoai");
        Label ghiChu = (Label)row.FindControl("lblGhiChu");

        if (e.CommandName == "suaNhanVien")
        {
            //DataTable DiaBanList = myCus.get_dia_ban();
            txtMaNV.Text = maNV.Text;
            txtTeNV.Text = tenNV.Text;
            txtDiaChi.Text = diaChi.Text;
            txtDienThoai.Text = dienThoai.Text;
            txtGhiChu.Text = ghiChu.Text;

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
        string maNV = txtMaNV.Text;
        string tenNV = txtTeNV.Text;
        string diaChi = txtDiaChi.Text;
        string dienThoai  = txtDienThoai.Text;
        string ghiChu = txtGhiChu.Text;
        string log = "Sửa nhân viên mã"+ maNV;

        myCus.cap_nhat_nhan_vien(maNV, tenNV, diaChi, dienThoai, ghiChu);
        myCon.save_log(Context.User.Identity.Name.ToString(), log, "4");
        Response.Redirect("DanhMucNhanVien.aspx");
    }
}