<%@ Page Language="C#" Title="Thêm nhân viên" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ThemNhanVien.aspx.cs" Inherits="ThemNhanVien" %>

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
                        <strong>THÔNG TIN NHÂN VIÊN</strong>
                    </div>
                </legend>
                <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana; color: #000000;">


                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Mã nhân viên (*):</span></span>
                        </td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtMaNV" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator8"
                                runat="server" controltovalidate="txtMaNV" errormessage="Bạn phải nhập mã nhân viên">*</asp:requiredfieldvalidator>

                        </td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Tên nhân viên (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:textbox id="txtTenNV" runat="server" width="200px" font-names="Arial" maxlength="50"></asp:textbox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" controltovalidate="txtTenNV"
                                errormessage="Bạn phải nhập tên nhân viên">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Địa chỉ (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtDiaChi" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator1"
                                runat="server" controltovalidate="txtDiaChi" errormessage="Bạn phải nhập địa chỉ">*</asp:requiredfieldvalidator></td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Điện thoại (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:textbox id="txtDienThoai" runat="server" width="200px" font-names="Arial" maxlength="50"></asp:textbox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" controltovalidate="txtDienThoai"
                                errormessage="Bạn phải nhập số điện thoại">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Ghi chú (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtGhiChu" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </fieldset>
            <asp:validationsummary id="ValidationSummary1" runat="server" showmessagebox="True"
                showsummary="False" />
            <span style="font-family: Verdana"></span>
        </div>

        <div class="card-header">
            <asp:button id="btnThemMoi" runat="server" text="Thêm mới" onclick="ThemNhanVien_Click"
                cssclass="btn btn-primary" />
        </div>
        <div class="form-group" style="clear: both;">
            <asp:label id="txtErr" runat="server" forecolor="#FF3300"></asp:label>
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


