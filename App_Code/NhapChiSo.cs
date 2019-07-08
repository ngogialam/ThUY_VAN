using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for NhapChiSo
/// </summary>
/// tuanbn.pto cls Nhập chỉ số điện năng
public class NhapChiSo
{
    public DataTable get_danh_sach_nhap_cs()
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select a.ma_kh,a.id_tram_bien_ap,a.ten_kh,a.dia_chi,a.dien_thoai,a.so_ho,a.id_khu,b.ten_khu, b.id_khu from khach_hang a, dm_khu b where a.id_khu = b.id_khu";
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