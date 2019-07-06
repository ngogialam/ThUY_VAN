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
                        <td class="auto-style2">
                            <span style="font-family: Arial">Tên KH (*):</span></span></td>
                           
                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:TextBox ID="txtTenKh" runat="server" Width="200px" Font-Names="Arial" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rqfTenPB" runat="server" ControlToValidate="txtTenKh"
                                ErrorMessage="Bạn phải nhập tên KH">*</asp:RequiredFieldValidator></td>
                        
                            <td align="right" class="auto-style2" >
                                <span style="font-family: Arial">Địa chỉ (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:TextBox ID="txtDiaChi" runat="server" Width="292px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                    runat="server" ControlToValidate="txtDiaChi" ErrorMessage="Bạn phải nhập địa chỉ">*</asp:RequiredFieldValidator></td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style2">
                            <span style="font-family: Arial">Vùng (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style4">
                            <asp:DropDownList ID="cbVung" runat="server" DataTextField="ten_dia_ban" DataValueField="id_dia_ban" Width="200px" Height="27px">
                                       
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cbVung"
                                Display="Dynamic" ErrorMessage="Chọn vùng">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style3">
                            Số<span style="font-family: Arial"> điện thoại (*):</span></span></td>
                        <td style="text-align: left" class="auto-style2">
                            <asp:TextBox ID="txtSoDT" runat="server" Width="200px" Font-Names="Arial" 
                                MaxLength="255"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSoDT"
                                ErrorMessage="Bạn phải nhập số điện thoại">*</asp:RequiredFieldValidator></td>
                    </tr>
                    
                   
                    <tr style="font-size: 13px">
                        <td class="auto-style2">
                             </td></td>
                        <td style="text-align: left;" class="auto-style4">
                            </td>
                        <td class="auto-style3">
                            <span style="font-family: Arial">Năm bán hàng:</span></td>
                        <td style="text-align: left" class="auto-style2">
                            <asp:TextBox ID="txtNamBH" runat="server" Width="88px" Font-Names="Arial" 
                                MaxLength="50">2019</asp:TextBox>
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
        .auto-style2
        {
            height: 60px;
        }
        .auto-style3
        {
            width: 120px;
            height: 60px;
        }
        .auto-style4
        {
            height: 60px;
            width: 311px;
        }
        .auto-style5
        {
            width: 311px;
        }
    </style>
</asp:Content>


