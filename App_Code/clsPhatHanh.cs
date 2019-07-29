using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;



/// </summary>
/// tuanbn.pto cls Phat Hanh Hoa Don 

public class clsPhatHanh
{
    public DataTable get_danh_sach_hd_moilap(string id_tramba, string ky)
    {
        SqlConnection myConn = null;
        string sql = "";
        if (id_tramba == "0")
        {
            sql = "select a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,c.ten_bang_gia,d.cs_cu,d.cs_moi,(d.cs_moi - d.cs_cu) san_luong,f.ma_cong_to,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu,d.trang_thai";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, chi_so_cong_to d, tram_bien_ap e, dm_cong_to f ";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and a.ma_kh=f.ma_kh and d.ma_cong_to=f.ma_cong_to and d.trang_thai=1 and d.ky='" + ky + "'";
            sql = sql + " order by a.ma_kh";
        }
        else
        {
            sql = "select a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,c.ten_bang_gia,d.cs_cu,d.cs_moi,(d.cs_moi - d.cs_cu) san_luong,f.ma_cong_to,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu,d.trang_thai";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, chi_so_cong_to d, tram_bien_ap e,dm_cong_to f ";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and a.ma_kh=f.ma_kh and d.ma_cong_to=f.ma_cong_to and d.trang_thai=1  a.id_tram_bien_ap='" + id_tramba + "' and d.ky='" + ky + "'";
            sql = sql + " order by a.ma_kh";
        }
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