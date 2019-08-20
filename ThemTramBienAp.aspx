<%@ Page Language="C#" Title="Thêm Trạm Biến Áp" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ThemTramBienAp.aspx.cs" Inherits="ThemTramBienAp" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <script>
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }
    </script>

</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <style>
        .txtBox {
            font-family:Arial;width:200px;
        }
    </style>
    <div class="row">
        <div class="col-12">
        </div>
    </div>

    <div class="card mb-3">

        <div>
            <fieldset style="width: 97%; font-family: Verdana; padding-top: 20px">
                <legend>
                    <div style="margin: 2px 0px 0px 0px; height: 20px;">
                        <strong>THÔNG TIN TRẠM BIẾN ÁP</strong>
                    </div>
                </legend>
                <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana; color: #000000;">


                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Id trạm biến áp (*):</span>
                        </td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtId" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator8"
                                runat="server" controltovalidate="txtId" errormessage="Bạn phải nhập id trạm biến áp">*</asp:requiredfieldvalidator>

                        </td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Tên trạm biến áp (*):</span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:textbox id="txtTenTrạmBienAp" runat="server" width="200px" font-names="Arial" maxlength="50"></asp:textbox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" controltovalidate="txtTenTrạmBienAp"
                                errormessage="Bạn phải nhập tên trạm biến áp">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Địa chỉ (*):</span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtDiaChi" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator1"
                                runat="server" controltovalidate="txtDiaChi" errormessage="Bạn phải nhập địa chỉ">*</asp:requiredfieldvalidator></td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Người phụ trách (*):</span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:DropDownList runat="server" ID="drpNguoiPhuTrach" DataValueField="ma_nv" DataTextField="ten_nv" Height="25px" width="200px" font-names="Arial" maxlength="50"></asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Mã số công tơ (*):</span></td>
                        <td style="text-align: left;" class="auto-style2">
                            <asp:textbox id="txtMaSoCT" runat="server" width="200px" font-names="Arial"
                                maxlength="555"></asp:textbox>
                            &nbsp;<asp:requiredfieldvalidator id="RequiredFieldValidator4"
                                runat="server" controltovalidate="txtMaSoCT" errormessage="Bạn phải nhập mã số công tơ">*</asp:requiredfieldvalidator>

                        </td>

                        <td class="auto-style2">
                            <span style="font-family: Arial">Hệ số nhân (*):</span></td>

                        <td align="left" style="text-align: left;" class="auto-style4">
                            <asp:TextBox ID="txtHeSoNhan" runat="server" onkeypress="return isNumberKey(event)" width="200px"></asp:TextBox>
                            <asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" controltovalidate="txtHeSoNhan"
                                errormessage="Bạn phải nhập hệ số nhân">*</asp:requiredfieldvalidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="right" class="auto-style2">
                            <span style="font-family: Arial">Trạng thái (*):</span></td>
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
            <asp:button id="btnThemMoi" runat="server" text="Thêm mới" onclick="ThemTramBienAp_Click"
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


