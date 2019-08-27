<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Danh mục bảng giá điện" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DanhMucBangGiaDien.aspx.cs" Inherits="DanhMucBangGiaDien" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <script>
</script>
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
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" PostBackUrl="~/ThemBangGiaDien.aspx"
                CssClass="btn btn-primary" />
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <asp:GridView ID="GridViewEman" ClientIDMode="Static" runat="server" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline" AutoGenerateColumns="False" OnRowCommand="GridView_OnRowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="ID">
                            <ItemTemplate>
                                <asp:Label ID="lblId" runat="server" Text='<%# Eval("id_bang_gia") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên bảng giá">
                            <ItemTemplate>
                                <asp:Label ID="lblTenBangGia" runat="server" Text='<%# Eval("ten_bang_gia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên viết tắt">
                            <ItemTemplate>
                                <asp:Label ID="lblTenVT" runat="server" Text='<%# Eval("ten_viet_tat") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đơn Giá">
                            <ItemTemplate>
                                <asp:Label ID="lblDonGia" runat="server" Text='<%# Eval("don_gia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tiền thuế VAT">
                            <ItemTemplate>
                                <asp:Label ID="lblThueVat" runat="server" Text='<%# Eval("tien_thue_vat") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Phần trăm thuế">
                            <ItemTemplate>
                                <asp:Label ID="lblPhanTramThue" runat="server" Text='<%# Eval("phan_tram_thue") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Giá bán">
                            <ItemTemplate>
                                <asp:Label ID="lblGiaBan" runat="server" Text='<%# Eval("gia_ban") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Trạng thái">
                            <ItemTemplate>
                                <asp:Label ID="lblTrangThai" runat="server" Text='<%# Eval("kich_hoat") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Thao tác" ItemStyle-Width="100px" ItemStyle-CssClass="text-center">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-success" ID="btnSua" runat="server" CommandName="suaGiaDien" Text="Sửa"></asp:Button>
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
                            <h5 class="modal-title" id="huyModalLable">Sửa thông tin bảng giá điện</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body m-xl-3">
                            <div class="row mx5">
                                <label>Id</label>
                                <asp:TextBox ID="txtId" runat="server" CssClass="form-control input-lg" ReadOnly="true"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Tên bảng giá</label>
                                <asp:TextBox ID="txtTenBangGia" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Tên viết tắt</label>
                                <asp:TextBox ID="txtTenVietTat" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Đơn giá</label>
                                <asp:TextBox ID="txtDonGia" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Tiền thuế VAT</label>
                                <asp:TextBox ID="txtTienThue" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Phần trăm thuế</label>
                                <asp:TextBox ID="txtPhanTramThue" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Giá bán</label>
                                <asp:TextBox ID="txtGiaBan" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                            <div class="row mx5">
                                <label>Trạng thái</label>
                                <div style="text-align: left;" class="auto-style2" id=" trangthai">
                                    <asp:CheckBox ID="ckbTrangThai" runat="server" Text="Kích hoạt" Width="200px" TextAlign="right" />
                                </div>
                            </div>
                        </div>
                        <!-- end modal body -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                            <asp:Button ID="Button1" runat="server" OnClick="btnSave_Click" CssClass="btn btn-success" UseSubmitBehavior="false" Text="Sửa bảng giá điện" data-dismiss="modal" />
                        </div>
                        <!-- end modal footer -->
                    </div>
                </div>
            </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="GridViewEman" EventName="RowCommand" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
