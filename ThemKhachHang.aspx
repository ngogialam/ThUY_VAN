<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Thêm khách hàng" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ThemKhachHang.aspx.cs" Inherits="ThemKhachHang" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <script>

    </script>
   
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-12">
            
        </div>
    </div>

    <div class="card mb-3">
       
        <div>
            <fieldset style="width: 97%; font-family: Verdana; padding-top: 20px">
                <legend>
                    <div style="margin: 2px 0px 0px 0px; height: 20px;">
                        <strong>THÔNG TIN KHÁCH HÀNG</strong>
                    </div>
                </legend>
                <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana;
                    color: #000000;">
                  

                    <tr>
                        <td class="auto-style6">
                            <span style="font-family: Arial">Tên KH (<span style="color: red">*</span>):</span></span></td>
                           
                        <td align="left" style="text-align: left;" class="auto-style7">
                            <asp:TextBox ID="txtTenKh" runat="server" Width="200px" Font-Names="Arial" MaxLength="50"></asp:TextBox>
                            </td>
                        
                            <td align="left" class="auto-style6" >
                                <span style="font-family: Arial">Địa chỉ (<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left;" class="auto-style6">
                            <asp:TextBox ID="txtDiaChi" runat="server" Width="292px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td class="auto-style6">
                            <span style="font-family: Arial">Huyện (<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left;" class="auto-style7">
                            <asp:DropDownList ID="ddlHuyen" runat="server" DataTextField="ten_huyen" DataValueField="id_Huyen" Width="200px" Height="27px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style6">
                            <span style="font-family: Arial">Phường/Xã (<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left" class="auto-style6">
                            <asp:DropDownList ID="ddlPhuongXa" runat="server" DataTextField="ten_phuong_xa" DataValueField="id_phuong_xa" Width="200px" Height="27px">
                            </asp:DropDownList>
                            </td>
                    </tr>
                    

                    
                    <tr>
                        <td class="auto-style6">
                            Khu<span style="font-family: Arial"> (<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left;" class="auto-style7">
                            <asp:DropDownList ID="cbKhu" runat="server" DataTextField="ten_khu" DataValueField="id_khu" Width="200px" Height="27px">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style6">
                            Số<span style="font-family: Arial"> điện thoại (<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left" class="auto-style6">
                            <asp:TextBox ID="txtSoDT" runat="server" Width="200px" Font-Names="Arial" 
                                MaxLength="255"></asp:TextBox>
                            </td>
                    </tr>
                    
                   
                    <tr style="font-size: 13px">
                        <td class="auto-style6">
                             Trạm biến áp</td></td>
                        <td class="auto-style6"><asp:DropDownList ID="ddlTramBA"
                            runat="server" DataTextField="ten_tram_bien_ap"
                            DataValueField="id_tram_bien_ap" Width="200px" Height="27px">
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style6">
                            Số hộ<span style="font-family: Arial">:</span></td>
                        <td style="text-align: left" class="auto-style6">
                            <asp:TextBox ID="txtSoHo" runat="server" Width="88px" Font-Names="Arial" 
                                MaxLength="50">1</asp:TextBox>
                            </td>
                    </tr>
                    
                    <tr style="font-size: 13px">
                        <td class="auto-style6">
                             Bảng giá điện</td></td>
                        <td class="auto-style6"><asp:DropDownList ID="ddlBangGiaDien"
                            runat="server" DataTextField="ten_bang_gia"
                            DataValueField="id_bang_gia" Width="200px" Height="27px">
                        </asp:DropDownList>
                        </td>
                        <td class="auto-style6">
                            Hệ số TI<span style="font-family: Arial">:</span></td>
                        <td style="text-align: left" class="auto-style6">
                            <asp:TextBox ID="txtHesoTI" runat="server" Width="88px" Font-Names="Arial" 
                                MaxLength="50">1</asp:TextBox>
                            </td>
                    </tr>

                     <tr>
                        <td class="auto-style6">
                            <span style="font-family: Arial">Mã số thuế(<span style="color: red">*</span>):</span></span></td>
                           
                        <td align="left" style="text-align: left;" class="auto-style7">
                            <asp:TextBox ID="txtMST" runat="server" Width="200px" Font-Names="Arial" MaxLength="50"></asp:TextBox>
                            </td>
                        
                            <td align="left" class="auto-style6" >
                                <span style="font-family: Arial">Cột điện số(<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left;" class="auto-style6">
                            <asp:TextBox ID="txtCotDienSo" runat="server" Width="200px" Font-Names="Arial"
                                MaxLength="555">0</asp:TextBox>&nbsp;</td>
                    </tr>

                    <tr>
                        <td class="auto-style6">
                            <span style="font-family: Arial">SL đồng hồ(<span style="color: red">*</span>):</span></span></td>
                           
                        <td align="left" style="text-align: left;" class="auto-style7">
                            <asp:TextBox ID="txtSLDH" runat="server" Width="200px" Font-Names="Arial" MaxLength="50">1</asp:TextBox>
                            </td>
                        
                            <td align="left" class="auto-style6" >
                                <span style="font-family: Arial">Mã công tơ (phân tách bởi dấu '|') (<span style="color: red">*</span>) :</span></span></td>
                        <td style="text-align: left;" class="auto-style6">
                            <asp:TextBox ID="txtMaCongTo" runat="server" Width="200px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;</td>
                    </tr>

                    <tr>
                        <td class="auto-style6">
                            <span style="font-family: Arial">Trạng thái(<span style="color: red">*</span>):</span></span></td>
                           
                        <td align="left" style="text-align: left;" class="auto-style7">
                            <asp:TextBox ID="txtTrangThai" runat="server" Width="200px" Font-Names="Arial" MaxLength="50">1</asp:TextBox>
                            </td>
                        
                            <td align="left" class="auto-style6" >
                                <span style="font-family: Arial">Thứ tự(<span style="color: red">*</span>):</span></span></td>
                        <td style="text-align: left;" class="auto-style6">
                            <asp:TextBox ID="txtThuTu" runat="server" Width="200px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;</td>
                    </tr>

                    <tr>
                        <td class="auto-style6">
                            <input type="checkbox" runat="server" id="ckSms" /> Gửi sms khi xuất hóa đơn
                        </td>
                    </tr>
                    <tr style="font-size: 13px">
                        <td >
                            &nbsp;</td>
                        <td style="text-align: left;" class="auto-style5" >
                            &nbsp;</td>
                        <td style="width: 120px; " align="right">
                            &nbsp;</td>                       
                    </tr>                     
                </table>
            </fieldset>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                ShowSummary="False" />
            <span style="font-family: Verdana"></span>
        </div>


         <div class="card-header">
           <asp:Button ID="btnThemMoi" runat="server" Text="Lưu" OnClick="ThemMoiKhachHang"
                CssClass="btn btn-primary" />
        </div>
         <div class="form-group" style="clear: both;">
            <asp:Label ID="txtErr" runat="server" ForeColor="#FF3300"></asp:Label>
        </div>


       

    </div>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style5
        {
            width: 311px;
        }
        .auto-style6
        {
            height: 35px;
        }
        .auto-style7
        {
            height: 35px;
            width: 311px;
        }
        .auto-style6
        {
            width: 120px;
            height: 35px;
        }
    </style>
</asp:Content>


