<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Danh mục nhân viên" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DanhMucNhanVien.aspx.cs" Inherits="DanhMucNhanVien" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">

    <script type="text/javascript">

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
            <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" PostBackUrl="~/ThemNhanVien.aspx"
                CssClass="btn btn-primary" />
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <asp:GridView ID="GridViewEman" ClientIDMode="Static" runat="server" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline" AutoGenerateColumns="False" OnRowCommand="GridView_OnRowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Mã nhân viên" ItemStyle-CssClass="text-center">
                            <ItemTemplate>
                                <asp:Label ID="lblMaNV" runat="server" Text='<%# Eval("ma_nv") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên nhân viên">
                            <ItemTemplate>
                                <asp:Label ID="lblTenNV" runat="server" Text='<%# Eval("ten_nv") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Địa chỉ">
                            <ItemTemplate>
                                <asp:Label ID="lblDiaChi" runat="server" Text='<%# Eval("dia_chi") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Điện thoại">
                            <ItemTemplate>
                                <asp:Label ID="lblDienThoai" runat="server" Text='<%# Eval("dien_thoai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ghi chú">
                            <ItemTemplate>
                                <asp:Label ID="lblGhiChu" runat="server" Text='<%# Eval("ghi_chu") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Thao tác" ItemStyle-Width="100px" ItemStyle-CssClass="text-center">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-success" ID="btnSua" runat="server" CommandName="suaNhanVien" Text="Sửa"></asp:Button>
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
                            <h5 class="modal-title" id="huyModalLable">Sửa thông tin</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <!-- end modal header -->
                        <div class="modal-body m-xl-3">
                            <div class="user-info-row" style="border: none">
                                <label class="key">Mã nhân viên:</label>
                                <div class="value">
                                    <asp:TextBox ID="txtMaNV" runat="server" CssClass="form-control input-lg" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Tên nhân viên:</label>
                                <div class="value">
                                    <asp:TextBox ID="txtTeNV" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Địa chỉ:</label>
                                <div class="value">
                                    <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Điện thoại:</label>
                                <div class="value">
                                    <asp:TextBox ID="txtDienThoai" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Ghi chú:</label>
                                <div class="value">
                                    <asp:TextBox ID="txtGhiChu" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <!-- end modal body -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                            <asp:Button ID="Button1" runat="server" OnClick="btnSave_Click" CssClass="btn btn-success" UseSubmitBehavior="false" Text="Cập nhật" data-dismiss="modal" />
                        </div>
                        <!-- end modal footer -->
                    </div>
                    <!--<div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                        <asp:Button ID="btn1Save" runat="server" OnClick="btnSave_Click" CssClass="btn btn-success" UseSubmitBehavior="false" Text="Sửa nhân viên" data-dismiss="modal" />
                    </div>-->
                </div>
            </div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="GridViewEman" EventName="RowCommand" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
