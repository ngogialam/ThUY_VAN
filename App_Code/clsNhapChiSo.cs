using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for NhapChiSo
/// </summary>
/// tuanbn.pto cls Nhập chỉ số điện năng
public class clsNhapChiSo
{
    public DataTable get_danh_sach_nhap_cs()
    {
        SqlConnection myConn = null;
        string sql = "select a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,c.ten_bang_gia,d.ky_hd,d.chi_so_cu,d.ma_congto, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu";
        sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, hoa_don d ";
        sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia " ;
       
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter myData = new SqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            myConn.Open();
            myData.Fill(dts);
            myData.Dispose();
            cmd.Parameters.Clear();
            cmd.Connection.Close();
            myConn.Close();
            return dts.Tables[0];
            // return dts;    
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (myConn != null)
            {
                myConn.Close();
            }
        }
    }
	
}