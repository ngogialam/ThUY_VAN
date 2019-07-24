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

public partial class ThemNhanVien : System.Web.UI.Page
{
    clsKhachHang myCus = new clsKhachHang();

    protected void ThemNhanVien_Click(object sender, EventArgs e)
    {

        string maNV = txtMaNV.Text;
        string tenNv = txtTenNV.Text; 
        string diaChi = txtDiaChi.Text;
        string dienThoai = txtDienThoai.Text;
        string ghiChu = txtGhiChu.Text;
        int i = myCus.them_moi_nhan_vien(maNV, tenNv, diaChi, dienThoai, ghiChu);
        if (i == 0)
            txtErr.Text = "Thêm mới thất bại!";
        else
            txtErr.Text = "Thêm nhân viên thành công!";

    }

    }
