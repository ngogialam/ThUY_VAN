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
                        <strong>THÔNG TIN BẢNG GIÁ ĐIỆN</strong>
                    </div>
                </legend>
                <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana; color: #000000;">


                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Tên bảng giá (*):</span></span>
                        </td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtTenBangGia" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator8"
                                runat="server" controltovalidate="txtTenBangGia" errormessage="Bạn phải nhập tên bảng giá">*</asp:requiredfieldvalidator>

                        </td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Tên viết tắt (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:textbox id="txtTenVietTat" runat="server" width="200px" font-names="Arial" maxlength="50"></asp:textbox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" controltovalidate="txtTenVietTat"
                                errormessage="Bạn phải nhập tên viết tắt">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Đơn giá (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtDonGia" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator1"
                                runat="server" controltovalidate="txtDonGia" errormessage="Bạn phải nhập đơn giá">*</asp:requiredfieldvalidator></td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Tiền thuế VAT (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:textbox id="txtTienThue" runat="server" width="200px" font-names="Arial" maxlength="50"></asp:textbox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" controltovalidate="txtTienThue"
                                errormessage="Bạn phải nhập tiền thuế VAT">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Phần trăm thuế (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtPhanTramThue" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator4"
                                runat="server" controltovalidate="txtPhanTramThue" errormessage="Bạn phải nhập phần trăm thuế">*</asp:requiredfieldvalidator>

                        </td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Giá bán (*):</span></span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:textbox id="txtGiaBan" runat="server" width="200px" font-names="Arial" maxlength="50"></asp:textbox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" controltovalidate="txtGiaBan"
                                errormessage="Bạn phải nhập giá bán">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Trạng thái (*):</span></span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:CheckBox ID="ckbTrangThai" runat="server" text ="Kích hoạt" width ="200px" TextAlign ="right"/>  
                        </td>
                    </tr>
                </table>
            </fieldset>
            <asp:validationsummary id="ValidationSummary1" runat="server" showmessagebox="True"
                showsummary="False" />
            <span style="font-family: Verdana"></span>
        </div>

        <div class="card-header">
            <asp:button id="btnThemMoi" runat="server" text="Thêm mới" onclick="ThemBangGiaDien_Click"
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


