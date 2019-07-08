<%@ Page Language="C#" Title="Bán hàng" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="NhapChiSo.aspx.cs" Inherits="NhapChiSo" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">  
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="row">
        <div class="col-12">
        </div>
    </div>

    <div class="card mb-3">
        <div class="card-header">
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" PostBackUrl="~/ThemKhachHang.aspx"
                CssClass="btn btn-primary" />
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <asp:GridView ID="GirdView" ClientIDMode="Static" runat="server" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline" AutoGenerateColumns="False" OnRowCommand="GridView_OnRowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Mã">
                            <ItemTemplate>
                                <asp:Label ID="lblMaKH" runat="server" Text='<%# Eval("ma_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên khách hàng">
                            <ItemTemplate>
                                <asp:Label ID="lblTenKH" runat="server" Text='<%# Eval("ten_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Khu">
                            <ItemTemplate>
                                <asp:Label ID="lblDB" runat="server" Text='<%# Eval("ten_khu") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>                                            
                        <asp:TemplateField HeaderText="Số hộ">
                            <ItemTemplate>
                                <asp:Label ID="lblSoHo" runat="server" Text='<%# Eval("so_ho") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CS đầu kỳ">
                            <ItemTemplate>
                                <asp:Label ID="lblSoHo" runat="server" Text='<%# Eval("so_ho") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                       

                         <asp:TemplateField HeaderText="idkhu" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblidKhu" runat="server" Text='<%# Eval("id_khu") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="idTram"  Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblidTram" runat="server" Text='<%# Eval("id_tram_bien_ap") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      <asp:TemplateField HeaderText="idDiaban" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblidDiaBan" runat="server" Text='<%# Eval("id_tram_bien_ap") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <asp:UpdatePanel ID="upModal" runat="server">
        <ContentTemplate>
            <div class="modal fade" id="EditModal" tabindex="-1" role="dialog" aria-labelledby="EditModal" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="huyModalLable">Sửa thông tin khách hàng</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body m-xl-3">
                            <div class="row mx5">
                                <label>Mã khách hàng</label>
                                <asp:TextBox ID="txtMaKH" runat="server" CssClass="form-control input-lg" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="row mx5">
                                <label>Tên khách hàng</label>
                                <asp:TextBox ID="txtTenKh" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Địa chỉ</label>
                                <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Phường/Xã</label>
                                <asp:DropDownList ID="cbVung" runat="server" CssClass="form-control input-lg" DataTextField="ten_dia_ban" DataValueField="id_dia_ban">
                                </asp:DropDownList>
                            </div>
                            <div class="row mx5">
                                <label>Điện thoại</label>
                                <asp:TextBox ID="txtSoDT" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Năm bán hàng</label>
                                <asp:TextBox ID="txtNamBH" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" CssClass="btn btn-success" UseSubmitBehavior="false" Text="Sửa khách hàng" data-dismiss="modal" />
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="GirdView" EventName="RowCommand" />
        </Triggers>
    </asp:UpdatePanel>

</asp:Content>