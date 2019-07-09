using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for clsKhachHang
/// </summary>
public class clsKhachHang
{
    //lyht.pto danh muc bang gia dien
    //hienthi danh sach gia dien
    public DataTable get_danh_muc_bang_gia_dien()
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select ten_bang_gia,ten_viet_tat,don_gia,tien_thue_vat,phan_tram_thue,gia_ban,kich_hoat from bang_gia_dien";
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
<<<<<<< HEAD
<<<<<<< HEAD
    
    //Them moi gia dien
    public int them_moi_gia_dien(string ten_bang_gia, string ten_viet_tat, float don_gia, float tien_thue_vat, float phan_tram_thue, float gia_ban, int kich_hoat)
    {
        int recordsAffected = 0;
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "insert into bang_gia_dien(ten_bang_gia,ten_viet_tat,don_gia,tien_thue_vat,phan_tram_thue,gia_ban,kich_hoat) values(N'" + ten_bang_gia + "','" + ten_viet_tat + "'," + don_gia + "," + tien_thue_vat + "," + phan_tram_thue + "," + gia_ban + "," + kich_hoat + ") ";
            cmd.CommandType = CommandType.Text;
            myConn.Open();
            recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (SqlException)
        {
        }
        finally
        {
            cmd.Connection.Close();
            myConn.Close();
        }
        return recordsAffected;
    }

    //Sua gia dien
    public void cap_nhat_gia_dien(string id,string ten_bang_gia, string ten_viet_tat, string don_gia, string tien_thue_vat, string phan_tram_thue, string gia_ban, string kich_hoat)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();

        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "update khach_hang set ten_bang_gia=N'" + ten_bang_gia + "',ten_viet_tat='" + ten_viet_tat + "',don_gia='" + don_gia + "',tien_thue_vat=" + tien_thue_vat + ",phan_tram_thue=" + phan_tram_thue + " gia_ban='" + gia_ban + ",kich_hoat='" + kich_hoat + "where id_bang_gia=" + id + "";
            cmd.CommandType = CommandType.Text;
            myConn.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }
        catch (SqlException)
        {
        }
        finally
        {
            cmd.Connection.Close();
            myConn.Close();
        }
    }

    //end 
=======
   
>>>>>>> eb75fb9753c2f1cd5b8ed4ee7542de1b4810a766
=======
   
>>>>>>> 4bdba28b06169d52251bf9494698c60674e5ebe6
    public DataTable get_danh_sach_khach_hang()
    {
        SqlConnection myConn = null;
        try{
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
    public DataTable get_danh_sach_khach_hang_dia_ban(int id_dia_ban)
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            if(id_dia_ban==0)
                cmd.CommandText = "select a.ma_kh,a.ten_kh,a.dia_chi,a.so_dt,a.nam_bh,a.id_dia_ban,b.ten_dia_ban, b.vung from khach_hang a, dm_dia_ban b where a.id_dia_ban = b.id_dia_ban";
            else
                cmd.CommandText = "select a.ma_kh,a.ten_kh,a.dia_chi,a.so_dt,a.nam_bh,a.id_dia_ban,b.ten_dia_ban, b.vung from khach_hang a, dm_dia_ban b where a.id_dia_ban = b.id_dia_ban and a.id_dia_ban="+ id_dia_ban +" ";
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
    public DataTable get_dia_ban()
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select id_dia_ban,ten_dia_ban from dm_dia_ban order by id_dia_ban asc";
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
    public string get_ma_kh_addmodal()
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select max(ma_kh) as ma_kh from khach_hang";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter myData = new SqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            myConn.Open();
            myData.Fill(dts);
            myData.Dispose();
            cmd.Parameters.Clear();
            cmd.Connection.Close();
            myConn.Close();
            return dts.Tables[0].Rows[0]["ma_kh"].ToString();
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
    public List<string> get_danh_sach_khac_hang_searchtext(string searchtext)
    {
        List<string> customers = new List<string>();
        clsConnect cnstr = new clsConnect();
        using (SqlConnection myConn = cnstr.ConnectSQL())
        {
            myConn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select a.ma_kh,a.ten_kh,a.dia_chi,b.ten_dia_ban,a.so_dt from khach_hang a, dm_dia_ban b where a.id_dia_ban = b.id_dia_ban and  (a.ten_kh like N'%" + searchtext + "' or a.ten_kh like N'%" + searchtext + "(%' or a.ten_kh like N'%" + searchtext + ")')";
            cmd.CommandType = CommandType.Text;
            using (SqlDataReader myData = cmd.ExecuteReader())
            {
                while (myData.Read())
                {
                    customers.Add(string.Format("{0}${1}${2}${3}${4}", myData["ma_kh"], myData["ten_kh"], myData["ten_dia_ban"], myData["dia_chi"], myData["so_dt"]));
                }
            }
            cmd.Parameters.Clear();
            cmd.Connection.Close();
            myConn.Close();
        }
        return customers;
        // return dts;    
    }
    public int them_moi_khach_hang(string ten_kh, string dia_chi, string so_dt, int nam_bh, int id_dia_ban)
    {
        int recordsAffected = 0;
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "insert into khach_hang(ten_kh,dia_chi,so_dt,nam_bh,id_dia_ban) values(N'" + ten_kh + "',N'" + dia_chi + "','" + so_dt + "'," + nam_bh + "," + id_dia_ban + ") ";
            cmd.CommandType = CommandType.Text;
            myConn.Open();
             recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (SqlException)
        {
        }
        finally
        {
            cmd.Connection.Close();
            myConn.Close();
        }
        return recordsAffected;
    }

    public void cap_nhat_khach_hang(string ma_kh,string ten_kh, string dia_chi, string so_dt, string nam_bh, string id_dia_ban)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        
        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "update khach_hang set ten_kh=N'" + ten_kh + "',dia_chi=N'" + dia_chi + "',so_dt='" + so_dt + "',nam_bh=" + nam_bh + ",id_dia_ban=" + id_dia_ban + " where ma_kh="+ ma_kh +" ";
            cmd.CommandType = CommandType.Text;
            myConn.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
           
        }
        catch (SqlException)
        {
        }
        finally
        {
            cmd.Connection.Close();
            myConn.Close();
        }
    }
    public void xoa_khach_hang(string ma_kh)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "delete khach_hang  where ma_kh=" + ma_kh + " ";
            cmd.CommandType = CommandType.Text;
            int recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (SqlException)
        {
        }
        finally
        {
            cmd.Connection.Close();
            myConn.Close();
        }
    }

}