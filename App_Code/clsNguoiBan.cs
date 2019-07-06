using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for clsNguoiBan
/// </summary>
public class clsNguoiBan
{
    public DataTable get_danh_sach_nguoi_ban()
    {
        SqlConnection myConn = null;
        try
        {
            clsConnect cnstr = new clsConnect();
            myConn = cnstr.ConnectSQL();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "select 0 ma_nguoiban, N'--Chọn người bán--' ten_nguoiban union all select ma_nguoiban,ten_nguoiban from nguoiban";
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