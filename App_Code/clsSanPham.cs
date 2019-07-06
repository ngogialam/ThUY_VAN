using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for clsSanPham
/// </summary>
public class clsSanPham
{	
    public DataTable get_danh_sach_san_pham()
    {           
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = myConn;
        cmd.CommandText = "select ma_hang,ten_hang,dv_tinh from dm_hang_hoa";
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

    public DataTable get_danh_sach_dia_ban()
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = myConn;
        cmd.CommandText = "select id_dia_ban,ten_dia_ban,vung from dm_dia_ban";
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
    public DataTable get_danh_sach_nguoi_dung()
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = myConn;
        cmd.CommandText = "select user_id,user_name,name,address,status,user_type from users";
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

	
}