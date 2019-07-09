<%@ Page Language="C#" Title="Thêm Bảng Giá Điện" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ThemBangGiaDien.aspx.cs" Inherits="ThemBangGiaDien" %>

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
                        <strong>THÔNG TIN BẢNG GIÁ ĐIỆN/strong>
                    </div>
                </legend>
                <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana; color: #000000;">


                    <tr>
                        <td class="auto-style2">
                            <span style="font-family: Arial">Id bảng giá (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:TextBox ID="txtId" runat="server" Width="200px" Font-Names="Arial" MaxLength="50" ReadOnly="true"></asp:TextBox>

                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Tên bảng giá (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:TextBox ID="txtTenBangGia" runat="server" Width="292px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                    runat="server" ControlToValidate="txtTenBangGia" ErrorMessage="Bạn phải nhập tên bảng giá">*</asp:RequiredFieldValidator></td>
                    </tr>

                    <tr>
                        <td class="auto-style2">
                            <span style="font-family: Arial">Tên viết tắt (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:TextBox ID="txtTenVietTat" runat="server" Width="200px" Font-Names="Arial" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenVietTat"
                                ErrorMessage="Bạn phải nhập tên viết tắt">*</asp:RequiredFieldValidator></td>

                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Đơn giá (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:TextBox ID="txtDonGia" runat="server" Width="292px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                    runat="server" ControlToValidate="txtDonGia" ErrorMessage="Bạn phải nhập đơn giá">*</asp:RequiredFieldValidator></td>
                    </tr>

                    <tr>
                        <td class="auto-style2">
                            <span style="font-family: Arial">Tiền thuế VAT (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:TextBox ID="txtTienThue" runat="server" Width="200px" Font-Names="Arial" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTienThue"
                                ErrorMessage="Bạn phải nhập tiền thuế VAT">*</asp:RequiredFieldValidator></td>

                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Phần trăm thuế (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:TextBox ID="txtPhanTramThue" runat="server" Width="292px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                                    runat="server" ControlToValidate="txtPhanTramThue" ErrorMessage="Bạn phải nhập phần trăm thuế">*</asp:RequiredFieldValidator></td>
                    </tr>

                    <tr>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:TextBox ID="txtGiaBan" runat="server" Width="292px" Font-Names="Arial"
                                MaxLength="555"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6"
                                    runat="server" ControlToValidate="txtGiaBan" ErrorMessage="Bạn phải nhập giá bán">*</asp:RequiredFieldValidator></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:CheckBox ID="CkbKichHoat" runat="server" Text="Kích hoạt" />
                        </td>
                    </tr>
                </table>
            </fieldset>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                ShowSummary="False" />
            <span style="font-family: Verdana"></span>
        </div>

        <div class="card-header">
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" OnClick="ThemBangGiaDien_Click"
                CssClass="btn btn-primary" />
        </div>
        <div class="form-group" style="clear: both;">
            <asp:Label ID="txtErr" runat="server" ForeColor="#FF3300"></asp:Label>
        </div>




    </div>
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
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


