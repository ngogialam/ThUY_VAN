using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

/// </summary>
/// tuanbn.pto cls Phat Hanh Hoa Don 

public class clsHoaDon
{
    //Danh sách hóa đơn mới lập
    public DataTable get_du_lieu_hd(string id_tramba, string ky, string trangthai)
    {
        SqlConnection myConn = null;
        string sql = "";
        if (id_tramba == "0")
        {
            sql = "select d.id,d.so_hd,d.mau_so,d.ky_hieu,a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,a.mst_kh,c.ten_viet_tat,nv.dien_thoai dt_sua_chua,d.chi_so_cu,d.chi_so_moi,d.dien_nang_tt dien_nang_tt,";
            sql = sql + "d.tong_tien_truoc_thue,d.vat_rate,d.thue_gtgt,d.tong_tien_sau_thue,d.ky_hd,d.ma_cong_to,d.tu_ngay,d.den_ngay,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu,d.trang_thai,tt.ten_trang_thai";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, hoa_don d, tram_bien_ap e,dm_trang_thai_hd tt, nhan_vien nv";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and e.nguoi_phu_trach=nv.ma_nv and  d.trang_thai=tt.trang_thai_id and d.ma_kh=a.ma_kh and d.trang_thai=" + trangthai + " and d.ky_hd='" + ky + "'";
            sql = sql + " order by d.id";
        }
        else
        {
            sql = "select d.id,d.so_hd,d.mau_so,d.ky_hieu,a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,a.mst_kh,c.ten_viet_tat,nv.dien_thoai dt_sua_chua,d.chi_so_cu,d.chi_so_moi,d.dien_nang_tt dien_nang_tt,";
            sql = sql + "d.tong_tien_truoc_thue,d.vat_rate,d.thue_gtgt,d.tong_tien_sau_thue,d.ky_hd,d.ma_cong_to,d.tu_ngay,d.den_ngay,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu,d.trang_thai,tt.ten_trang_thai";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, hoa_don d, tram_bien_ap e,dm_trang_thai_hd tt, nhan_vien nv";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and e.nguoi_phu_trach=nv.ma_nv and  d.trang_thai=tt.trang_thai_id and d.ma_kh=a.ma_kh and d.trang_thai=" + trangthai + " and  a.id_tram_bien_ap='" + id_tramba + "' and d.ky_hd='" + ky + "'";
            sql = sql + " order by d.id";
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
    //Danh sách hóa đơn điện tử
    public DataTable get_danh_sach_hddt(string id_tramba, string ky, string trangthai)
    {
        SqlConnection myConn = null;
        string sql = "";
        if (id_tramba == "0")
        {
            sql = "select distinct d.id,d.so_hd,d.mau_so,d.ky_hieu,a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,a.mst_kh,c.ten_viet_tat,d.dien_nang_tt dien_nang_tt,";
            sql = sql + "d.tong_tien_truoc_thue,d.vat_rate,d.thue_gtgt,d.tong_tien_sau_thue,d.ky_hd,d.tu_ngay,d.den_ngay,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu,d.trang_thai,tt.ten_trang_thai";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, hoa_don d, tram_bien_ap e,dm_trang_thai_hd tt  ";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and  d.trang_thai=tt.trang_thai_id and d.ma_kh=a.ma_kh and d.trang_thai=" + trangthai + " and d.ky_hd='" + ky + "'";
            sql = sql + " order by d.id";
        }
        else
        {
            sql = "select distinct d.id,d.so_hd,d.mau_so,d.ky_hieu,a.ma_kh, a.ten_kh,b.ten_khu,a.dia_chi,a.dien_thoai,a.mst_kh,c.ten_viet_tat,d.dien_nang_tt dien_nang_tt,";
            sql = sql + "d.tong_tien_truoc_thue,d.vat_rate,d.thue_gtgt,d.tong_tien_sau_thue,d.ky_hd,d.tu_ngay,d.den_ngay,e.ten_tram_bien_ap, a.id_tram_bien_ap,a.id_bang_gia,a.so_ho,a.id_khu, b.id_khu,d.trang_thai,tt.ten_trang_thai";
            sql = sql + " from khach_hang a, dm_khu b,bang_gia_dien c, hoa_don d, tram_bien_ap e,dm_trang_thai_hd tt  ";
            sql = sql + " where a.id_khu = b.id_khu and a.id_bang_gia=c.id_bang_gia and  a.id_tram_bien_ap=e.id_tram_bien_ap and  d.trang_thai=tt.trang_thai_id and d.ma_kh=a.ma_kh and d.trang_thai=" + trangthai + " and  a.id_tram_bien_ap='" + id_tramba + "' and d.ky_hd='" + ky + "'";
            sql = sql + " order by d.id";
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
    //Chuyen doi hoa don
    public string PrintInvoice(string Fkey,string userName,string userPass)
    {
        PortalInvWS.PortalService portalservice = new PortalInvWS.PortalService();
        string pdf = portalservice.convertForStoreFkey(Fkey, userName, userPass);
        if (CheckConvertFor(pdf).Contains("ERR"))
        {            
            return CheckConvertFor(pdf);
        }else{


            return pdf;
        }

    }
    public string CheckConvertFor(string ReturnValue)
    {
        string error = "";
        switch (ReturnValue)
        {
            case "ERR:1":
                error = "ERR: " + "Tài khoản đăng nhập sai";

                break;
            case "ERR:2":
                error = "ERR: " + "Chuỗi token không chính xác";
                break;
            case "ERR:6":
                error = "ERR: " + "Chuỗi token không chính xác. Kiểm tra mẫu số, ký hiệu hoặc số hóa đơn.";
                break;
            case "ERR:8":
                error = "ERR: " + "Hóa đơn  đã  được chuyển đổi rồi";
                break;
        }
        return error;
    }
    //Lấy các dòng hóa đơn
    public DataTable lay_hoa_don_chi_tiet(string id_hoa_don)
    {
        SqlConnection myConn = null;
        string sql = "select * from hoa_don_chi_tiet where id_hoa_don=" + id_hoa_don;

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
    //Cap Nhat So HDDT, ngayPH, mau so, ky hieu
    public int updateEInvoice(string id, string ky, string so_hd, string mau_so, string ky_hieu)
    {
        clsConnect cnstr = new clsConnect();
        SqlConnection myConn = cnstr.ConnectSQL();
        // cmd.Connection = myConn;            
        string CommandText = "update hoa_don set thanh_toan=0,ngay_phat_hanh = CONVERT(Date, GETDATE()),trang_thai=2, so_hd = @so_hd, mau_so=@mau_so, ky_hieu=@ky_hieu where id=@id and ky_hd=@ky";
        SqlCommand cmd = new SqlCommand(CommandText, myConn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@so_hd", so_hd);
        cmd.Parameters.AddWithValue("@mau_so", mau_so);
        cmd.Parameters.AddWithValue("@ky_hieu", ky_hieu);
        cmd.Parameters.AddWithValue("@ky", ky);

        int recordsAffected = 0;
        try
        {
            myConn.Open();
            recordsAffected = cmd.ExecuteNonQuery();

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
    //Tạo xml hóa đơn
    public string ParseIInvoice(DataTable InvList)
    {
        DataTable objTable = InvList;
        StringBuilder rv = new StringBuilder();

        int i = 0;
        //tao file xml
        if (objTable.Rows.Count > 0)
        {
            rv = new StringBuilder("<Invoices>");
            StringBuilder Failed = new StringBuilder("<Invoices>");

            try
            {
                const string Fkey = "id";
                //khach hang
                //const string Buyer = "Khách hàng";
                const string CusCode = "ma_kh";
                const string CusName = "ten_kh";
                const string CusAddress = "dia_chi";
                const string CusPhone = "dien_thoai";
                const string CusTaxCode = "mst_kh";
                const string KindOfService = "ky_hd";
                const string DTSuaChua = "dt_sua_chua";

                //Core mo rong 
                const string StartDate = "tu_ngay";
                const string ToDate = "den_ngay";
                const string SoHo = "so_ho";
                const string CHI_SO_DAU_KY = "chi_so_cu";
                const string CHI_SO_CUOI_KY = "chi_so_moi";
                const string SAN_LUONG = "dien_nang_tt";
                //CongTo
                //Product-Dòng hóa đơn            

                const string ProdCode = "dong";
                const string ProdName = "dien_giai";
                //const string ProdUnit = "DonViTinh";
                const string ProdQuantity = "so_luong";
                const string ProdPrice = "don_gia";
                const string ProdTotal = "thanh_tien";

                //tien thue
                const string Total = "tong_tien_truoc_thue";
                const string VATAmount = "thue_gtgt";
                const string Amount = "tong_tien_sau_thue";
                const string VATRate = "vat_rate";

                do
                {
                    DataRow dr = objTable.Rows[i];

                    string key = dr[Fkey].ToString();
                    StringBuilder sb = new StringBuilder("<Inv><key>");
                    sb.Append(key);
                    sb.Append("</key><Invoice>");
                    string makh = dr[CusCode].ToString();
                    if (string.IsNullOrEmpty(dr[CusCode].ToString()) || string.IsNullOrEmpty(dr[CusName].ToString()))
                    {

                        return null;
                    }
                    else
                    {
                        sb.Append("<CusCode>");
                        sb.Append(convertSpecialCharacter(dr[CusCode].ToString().Trim()));
                        sb.Append("</CusCode>");
                        sb.Append("<CusName>");
                        sb.Append(convertSpecialCharacter(dr[CusName].ToString().Trim()));
                        sb.Append("</CusName>");
                        sb.Append("<Buyer>");
                        //sb.Append(convertSpecialCharacter(dr[Buyer].ToString().Trim()));
                        sb.Append("</Buyer>");
                    }
                    sb.Append("<CusAddress>");
                    if (dr.Table.Columns.Contains(CusAddress))
                    {
                        sb.Append(convertSpecialCharacter(dr[CusAddress].ToString().Trim()));
                    }
                    sb.Append("</CusAddress><CusPhone>");
                    if (dr.Table.Columns.Contains(CusPhone))
                    {
                        sb.Append(dr[CusPhone].ToString().Trim());
                    }
                    sb.Append("</CusPhone><CusTaxCode>");
                    if (dr.Table.Columns.Contains(CusTaxCode))
                    {
                        sb.Append(dr[CusTaxCode].ToString().Trim());
                    }
                    sb.Append("</CusTaxCode><PaymentMethod>");
                    sb.Append(convertSpecialCharacter("TM/CK"));
                    sb.Append("</PaymentMethod>");
                    sb.Append("<KindOfService>");
                    if (dr.Table.Columns.Contains(KindOfService))
                    {
                        sb.Append(dr[KindOfService].ToString().Trim());
                    }
                    sb.Append("</KindOfService>");

                    sb.Append("<Extra>");
                    sb.Append(key);
                    sb.Append("</Extra>");

                    sb.Append("<Extra1>");
                        sb.Append(dr[DTSuaChua].ToString().Trim());
                    sb.Append("</Extra1>");
                    //Tunga-denngay
                    sb.Append("<FromDate>");
                    if (dr.Table.Columns.Contains(StartDate))
                    {
                        sb.Append(dr[StartDate].ToString().Trim());
                    }
                    sb.Append("</FromDate><ToDate>");
                    if (dr.Table.Columns.Contains(ToDate))
                    {
                        sb.Append(dr[ToDate].ToString().Trim());
                    }
                    sb.Append("</ToDate>");

                    //số hộ
                    sb.Append("<SoHo>");
                    if (dr.Table.Columns.Contains(SoHo))
                    {
                        sb.Append(dr[SoHo].ToString().Trim());
                    }
                    sb.Append("</SoHo>");

                    //ĐN Tiêu thụ
                    sb.Append("<DNSD>");
                    if (dr.Table.Columns.Contains(SAN_LUONG))
                    {
                        sb.Append(dr[SAN_LUONG].ToString().Trim());
                    }
                    sb.Append("</DNSD>");
                    sb.Append("<ChiSoCu></ChiSoCu><ChiSoMoi></ChiSoMoi>");
                    //Cong to
                    sb.Append("<Sumptions>");
                    int j = i;
                    do
                    {
                        DataRow drSumtion = objTable.Rows[j];
                        sb.Append("<Sumption>");
                        sb.Append("<CHI_SO_DAU_KY>");
                        sb.Append(drSumtion[CHI_SO_DAU_KY].ToString().Trim());
                        sb.Append("</CHI_SO_DAU_KY>");
                        sb.Append("<CHI_SO_CUOI_KY>");
                        sb.Append(drSumtion[CHI_SO_CUOI_KY].ToString().Trim());
                        sb.Append("</CHI_SO_CUOI_KY>");
                        sb.Append("<SAN_LUONG></SAN_LUONG><MA_TINH_TRANG_DH></MA_TINH_TRANG_DH>");
                        sb.Append("</Sumption>");
                        j++;
                    } while (j < objTable.Rows.Count && string.Compare(objTable.Rows[j][Fkey].ToString(), objTable.Rows[j - 1][Fkey].ToString()) == 0);
                    sb.Append("</Sumptions>");
                    //bat dau den san pham
                    sb.Append("<Products>");
                    DataTable dtbInvLine = lay_hoa_don_chi_tiet(key);
                    int k = 0;
                    for (k = 0; k < dtbInvLine.Rows.Count; k++)
                    {
                        DataRow drProduct = dtbInvLine.Rows[k];
                        sb.Append("<Product>");
                        // sb.Append(convertSpecialCharacter(drProduct[ProdCode].ToString().Trim()));
                        sb.Append("<ProdName>");
                        sb.Append(drProduct[ProdName].ToString().Trim());
                        sb.Append("</ProdName><ProdUnit>");
                        //sb.Append(convertSpecialCharacter(drProduct[ProdUnit].ToString().Trim()));
                        sb.Append("kWh");
                        sb.Append("</ProdUnit><ProdQuantity>");
                        sb.Append(drProduct[ProdQuantity].ToString().Replace(",", ""));
                        sb.Append("</ProdQuantity><ProdPrice>");
                        sb.Append(drProduct[ProdPrice].ToString().Trim().Replace(",", ""));
                        sb.Append("</ProdPrice><Amount>");
                        sb.Append(drProduct[ProdTotal].ToString().Trim().Replace(",", ""));
                        sb.Append("</Amount>");

                        //end
                        sb.Append("</Product>");
                    }
                    sb.Append("</Products><Total>");
                    sb.Append(dr[Total].ToString().Trim().Replace(",", ""));
                    sb.Append("</Total><DiscountAmount></DiscountAmount><VATRate>");
                    sb.Append(dr[VATRate].ToString().Trim());
                    sb.Append("</VATRate><VATAmount>");
                    sb.Append(dr[VATAmount].ToString().Trim().Replace(",", ""));
                    sb.Append("</VATAmount><Amount>");
                    sb.Append(dr[Amount].ToString().Trim().Replace(",", ""));
                    sb.Append("</Amount><AmountInWords>");
                    Int64 tongtien;
                    string tienBangChu = "";
                    NumberToLeter numToLetter = new NumberToLeter();
                    if (Int64.TryParse(dr[Amount].ToString().Trim().Replace(",", ""), out tongtien))
                        tienBangChu = numToLetter.DocTienBangChu(tongtien, tienBangChu);
                    sb.Append(tienBangChu);
                    sb.Append("</AmountInWords>");
                    sb.Append("</Invoice></Inv>");
                    rv.AppendLine(sb.ToString());
                    i = j;
                } while (i < objTable.Rows.Count);
            }

            catch (Exception ex)
            {
                return null;
            }

            rv.Append("</Invoices>");
        }
        return rv.ToString();
    }
    private string convertSpecialCharacter(string xmlData)
    {
        return "<![CDATA[" + xmlData + "]]>";
    }

}