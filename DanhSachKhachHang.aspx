
<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Danh mục khách hàng" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DanhSachKhachHang.aspx.cs" Inherits="DanhSachKhachHang" %>

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
                         <asp:TemplateField HeaderText="Id bảng giá">
                            <ItemTemplate>
                                <asp:Label ID="lblIdBangGia" runat="server" Text='<%# Eval("id_bang_gia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Địa chỉ">
                            <ItemTemplate>
                                <asp:Label ID="lblDiaChi" runat="server" Text='<%# Eval("dia_chi") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Id khu">
                            <ItemTemplate>
                                <asp:Label ID="lblKhu" runat="server" Text='<%# Eval("id_khu") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Id trạm biến áp">
                            <ItemTemplate>
                                <asp:Label ID="lblIdBA" runat="server" Text='<%# Eval("id_tram_bien_ap") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số hộ">
                            <ItemTemplate>
                                <asp:Label ID="lblsoHo" runat="server" Text='<%# Eval("so_ho") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hệ số ti" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lbldHeSoti" runat="server" Text='<%# Eval("he_so_ti") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Điện thoại">
                            <ItemTemplate>
                                <asp:Label ID="lblDienThoai" runat="server" Text='<%# Eval("dien_thoai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mst khách hàng" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblMtsKH" runat="server" Text='<%# Eval("mst_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cột điện số" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblCotDienSo" runat="server" Text='<%# Eval("cot_dien_so") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số lượng đồng hồ" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblSLDongHo" runat="server" Text='<%# Eval("sl_dong_ho") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Người liên hệ" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblNguoiLH" runat="server" Text='<%# Eval("nguoi_lien_he") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Trạng thái" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblTrangThai" runat="server" Text='<%# Eval("trang_thai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Thứ tự" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblThuTu" runat="server" Text='<%# Eval("thu_tu") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Id phường xã" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblIdPhuongXa" runat="server" Text='<%# Eval("id_phuong_xa") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Id huyện" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblMIdHuyen" runat="server" Text='<%# Eval("id_huyen") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Thao tác" ItemStyle-Width="100px">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-success" ID="btnHuy" runat="server" CommandName="suaKH" Text="Sửa"></asp:Button>
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
                                <label>Khu</label>
                                <asp:DropDownList ID="cbKhu" runat="server" CssClass="form-control input-lg" DataTextField="ten_khu" DataValueField="id_khu">
                                </asp:DropDownList>
                            </div>
                            <div class="row mx5">
                                <label>Phường/Xã</label>
                                <asp:DropDownList ID="cbVung" runat="server" CssClass="form-control input-lg" DataTextField="ten_phuong_xa" DataValueField="id_phuong_xa">
                                </asp:DropDownList>
                            </div>
                            <div class="row mx5">
                                <label>Huyện</label>
                                <asp:DropDownList ID="cbHuyen" runat="server" CssClass="form-control input-lg" DataTextField="ten_huyen" DataValueField="id_huyen">
                                </asp:DropDownList>
                            </div>
                            <div class="row mx5">
                                <label>Bảng giá</label>
                                <asp:DropDownList ID="cbBangGia" runat="server" CssClass="form-control input-lg" DataTextField="ten_bang_gia" DataValueField="id_bang_gia">
                                </asp:DropDownList>
                            </div>
                            <div class="row mx5">
                                <label>Trạm biến áp/label>
                                <asp:DropDownList ID="cbTramBienAp" runat="server" CssClass="form-control input-lg" DataTextField="ten_tram_bien_ap" DataValueField="id_tram_bien_ap">
                                </asp:DropDownList>
                            </div>
                            <div class="row mx5">
                                <label>Số hộ</label>
                                <asp:TextBox ID="txtSoHo" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Hệ số ti</label>
                                <asp:TextBox ID="txtHSTi" runat="server" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                            <div class="row mx5">
                                <label>Điện thoại</label>
                                <asp:TextBox ID="txtSoDT" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                            <div class="row mx5">
                                <label>Mã Mst KH</label>
                                <asp:TextBox ID="txtMstKH" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                            <div class="row mx5">
                                <label>Số cột</label>
                                <asp:TextBox ID="txtSoCot" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                            <div class="row mx5">
                                <label>Số lượng đồng hồ</label>
                                <asp:TextBox ID="txtSoDongHo" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                            <div class="row mx5">
                                <label>Người liên hệ/label>
                                <asp:TextBox ID="txtNguoiLH" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                             <div class="row mx5">
                                <label>Trạng thái</label>
                                <div style="text-align: left;" class="auto-style2" id=" trangthai">
                                    <asp:CheckBox ID="ckbTrangThai" runat="server" Text="Kích hoạt" Width="200px" TextAlign="right" />
                                </div>
                            </div>
                            <div class="row mx5">
                                <label>Thứ tự</label>
                                <asp:TextBox ID="txtThuTu" runat="server" CssClass="form-control input-lg"></asp:TextBox>
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

