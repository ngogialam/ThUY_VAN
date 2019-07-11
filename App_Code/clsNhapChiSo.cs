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
    public DataTable get_danh_sach_nhap_cs(string id_tramba, string ky)
    {
        SqlConnection myConn = null;
        string sql = "";
        if (id_tramba == "0")
        {
            sql = "select a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,c.ten_bang_gia,d.cs_cu,d.cs_moi,f.ma_cong_to,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, chi_so_cong_to d, tram_bien_ap e, dm_cong_to f ";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and a.ma_kh=f.ma_kh and d.ma_cong_to=f.ma_cong_to  and d.ky='" + ky + "'";
        }
        else
        {
            sql = "select a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,c.ten_bang_gia,d.cs_cu,d.cs_moi,f.ma_cong_to,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, chi_so_cong_to d, tram_bien_ap e,dm_cong_to f ";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and a.ma_kh=f.ma_kh and d.ma_cong_to=f.ma_cong_to and  a.id_tram_bien_ap='" + id_tramba + "' and d.ky='" + ky + "'";
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
    public DataTable get_danh_sach_tba()
    {
        SqlConnection myConn = null;
        string sql = "select '0' id_tram_bien_ap, N'-- Tất cả --' ten_tram_bien_ap ";
        sql = sql + " union all ";
        sql = sql + " select id_tram_bien_ap,ten_tram_bien_ap from tram_bien_ap where trang_thai=1 ";
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
    //Trạng thái kỳ 1-Chưa chốt, 0-đã chốt
    public DataTable get_danh_ky()
    {
        SqlConnection myConn = null;
        string sql = " select id,ky from ky where trang_thai=1 ";
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
    public int check_cs_ct(string mact, string ky)
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select * from chi_so_cong_to where ma_cong_to = " + mact + " and ky='" + ky + "'";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter myData = new SqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            myConn.Open();
            myData.Fill(dts);
            myData.Dispose();
            cmd.Parameters.Clear();
            cmd.Connection.Close();
            myConn.Close();
            return dts.Tables[0].Rows.Count;
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
    public int cap_nhat_chi_so(string mact, string csmoi, string ky)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        int recordsAffected = 0;
        try
        {
            myConn.Open();
            cmd.Connection = myConn;
            cmd.Parameters.Clear();
            cmd.CommandText = "update chi_so_cong_to set cs_moi='" + csmoi + "', ngay_capnhat = CONVERT( Datetime, GETDATE() ,103) where ma_cong_to='" + mact + "' and ky='" + ky + "'";
            recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
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
        return recordsAffected;
    }
    public int them_chi_so_ky_moi(string mact, string csmoi, string kymoi)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        int recordsAffected = 0;
        try
        {
            myConn.Open();
            cmd.Connection = myConn;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into chi_so_cong_to(ma_cong_to,cs_cu,ky,ngay_capnhat) values ('" + mact + "'," + csmoi + ",'" + kymoi + "',CONVERT( Datetime, GETDATE() ,103))";
            recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
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
        return recordsAffected;
    }
    public int them_kyhd(string ky, string thang, string nam, string tu_ngay, string den_ngay)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        int recordsAffected = 0;
        try
        {
            myConn.Open();
            cmd.Connection = myConn;
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into ky(ky,thang,nam,tu_ngay,den_ngay,trang_thai) values ('" + ky + "'," + thang + "," + nam + ",CONVERT(date,'" + tu_ngay + "'),CONVERT(date,'" + den_ngay + "'),1)";
            recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
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
        return recordsAffected;
    }

}