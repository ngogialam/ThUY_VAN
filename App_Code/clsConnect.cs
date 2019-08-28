using System;
using System.Collections.Generic;

using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Net;
/// <summary>
/// Summary description for clsConnect
/// </summary>
public class clsConnect
{
    
    public SqlConnection ConnectSQL()
    {
        string constr = "Data Source=10.24.30.12;Initial Catalog=VNPT_EMAN;user id=eman;password=Eman@2019;";
        // string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlConnection myConn = new SqlConnection(constr);
        return myConn;

    }
    public static string MD5Hash(string text)
    {
        MD5 md5 = new MD5CryptoServiceProvider();

        //compute hash from the bytes of text  
        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

        //get hash result after compute it  
        byte[] result = md5.Hash;

        StringBuilder strBuilder = new StringBuilder();
        for (int i = 0; i < result.Length; i++)
        {
            //change it into 2 hexadecimal digits  
            //for each byte  
            strBuilder.Append(result[i].ToString("x2"));
        }

        return strBuilder.ToString();
    }
    public int Authenticate(string ten_dang_nhap, string mat_khau)
    {
        int loginSuccess = 0;
        string pass = MD5Hash(mat_khau);
        try
        {
            clsConnect cnstr = new clsConnect();
            SqlConnection myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select * from users where user_name='" + ten_dang_nhap + "' and password='" + pass + "' and status=1 ";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter myData = new SqlDataAdapter(cmd);
            DataSet dts = new DataSet();
            myConn.Open();
            myData.Fill(dts);
            myData.Dispose();
            cmd.Parameters.Clear();
            cmd.Connection.Close();
            myConn.Close();
            if (dts.Tables[0].Rows.Count == 1)
                loginSuccess = 1;
            else
                loginSuccess = 0;
        }
        catch (SqlException)
        { 
        
        }

        return loginSuccess;
    }

    public DataTable getUser(string ten_dang_nhap)
    {
        DataTable tableUser = new DataTable();
        try
        {
            clsConnect cnstr = new clsConnect();
            SqlConnection myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select users.*, doanh_nghiep.ten_doanh_nghiep from users, doanh_nghiep where users.user_name='" + ten_dang_nhap + "'and users.status=1 and users.id_doanh_nghiep = doanh_nghiep.id_doanh_nghiep";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter myData = new SqlDataAdapter(cmd);
            myConn.Open();
            myData.Fill(tableUser);
            myData.Dispose();
            cmd.Parameters.Clear();
            cmd.Connection.Close();
            myConn.Close();
        }
        catch (SqlException)
        {

        }

        return tableUser;
    }


    public int change_pass(string user_name,string passnew)
    {
        int recordsAffected = 0;
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        string passnew5 = MD5Hash(passnew);
        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "update users set password='" + passnew5 + "' where user_name='" + user_name + "' ";
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
    protected string GetIPAddress()
    {
        System.Web.HttpContext context = System.Web.HttpContext.Current;
        string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        if (!string.IsNullOrEmpty(ipAddress))
        {
            string[] addresses = ipAddress.Split(',');
            if (addresses.Length != 0)
            {
                return addresses[0];
            }
        }

        return context.Request.ServerVariables["REMOTE_ADDR"];
    }

    // loai =1 dang nhap
    //loai = 2 ban hang
    //loai = 3 huy don
    //loai = 4 them kh
    //loai = 5 chot ca

    public void save_log(string user_name,string thao_tac,string loai)
    {
        int recordsAffected = 0;
        string IPAddress = GetIPAddress();
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = myConn;
            cmd.CommandText = "insert into ghi_log(user_name,thao_tac,ip,loai,thoigian) values(N'" + user_name + "',N'" + thao_tac + "','" + IPAddress + "','" + loai + "',CONVERT( Datetime, GETDATE() ,103)) ";
            cmd.CommandType = CommandType.Text;
            myConn.Open();
            recordsAffected = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            
                myConn.Close();
            
        }
        
    }
    public string get_tenND(string user_name)
    {
        SqlConnection myConn = null;
        try{
        clsConnect cnstr = new clsConnect();
        myConn = cnstr.ConnectSQL();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = myConn;
        cmd.CommandText = "select name from users where user_name='" + user_name +"'";
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter myData = new SqlDataAdapter(cmd);
        DataSet dts = new DataSet();
        myConn.Open();
        myData.Fill(dts);
        myData.Dispose();
        cmd.Parameters.Clear();
        cmd.Connection.Close();
        return dts.Tables[0].Rows[0]["name"].ToString();
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
