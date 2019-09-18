using System.Data;

public class clsSanPham
{
    clsConnect cnstr = new clsConnect();

    public DataTable get_danh_sach_san_pham()
    {           
        string sqlQuery = "select ma_hang, ten_hang, dv_tinh from dm_hang_hoa";
        DataTable new_table = cnstr.GetDataTable(sqlQuery);
        return new_table;
    }

    public DataTable get_danh_sach_ky_hd()
    {
        string sqlQuery = "select * from ky order by id";
        DataTable new_table = cnstr.GetDataTable(sqlQuery);
        return new_table;
    }

    public DataTable get_danh_sach_nguoi_dung()
    {
        string sqlQuery = "select user_id, user_name, name, address, status, user_type from users";
        DataTable new_table = cnstr.GetDataTable(sqlQuery);
        return new_table;
    }
}