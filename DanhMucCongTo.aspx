<%@ Page Language="C#" Title="Danh mục công tơ" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DanhMucCongTo.aspx.cs" Inherits="DanhMucCongTo" %>

<%@ Register Assembly="DevExpress.Web.v12.1, Version=12.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <script>
        //Thêm mới
        function ThemMoi() {
            $('#AddModal').modal('show');
        }
        function onClickThemMoi() {
            var re = /d+/;
            var txtTenBangGia = $('#txtTenBangGia_AddModal').val();
            var txtTenVietTat = $('#txtTenVietTat_AddModal').val();
            var txtDonGia = $('#txtDonGia_AddModal').val();
            var txtTienThue = $('#txtTienThue_AddModal').val();
            var txtPhanTramThue = $('#txtPhanTramThue_AddModal').val();
            var txtGiaBan = $('#txtGiaBan_AddModal').val();
            if (txtTenBangGia === "") {
                alert("Vui lòng nhập tên bảng giá!");
                $('#txtTenBangGia_AddModal').focus();
                return false
            }
            if (txtTenVietTat === "") {
                alert("Vui lòng nhập tên viết tắt!");
                $('#txtTenVietTat_AddModal').focus();
                return false
            }
            if (txtDonGia === "") {
                alert("Vui lòng nhập đơn giá!");
                $('#txtDonGia_AddModal').focus();
                return false;
            }
            var isDonGia = re.test(txtDonGia);
            if (isDonGia) {
                alert("Bạn chỉ được nhập số!");
                $('#txtDonGia_AddModal').focus();
                return false;
            }
            if (txtTienThue === "") {
                alert("Vui lòng nhập tiền thuế!");
                $('#txtTienThue_AddModal').focus();
                return false;
            }
            var isTienThue = re.test(txtTienThue);
            if (isTienThue) {
                alert("Bạn chỉ được nhập số!");
                $('#txtTienThue_AddModal').focus();
                return false;
            }
            if (txtPhanTramThue === "") {
                alert("Vui lòng nhập phần trăm thuế!");
                $('#txtPhanTramThue_AddModal').focus();
                return false;
            }
            var isPhanTramThue = re.test(txtPhanTramThue);
            if (isPhanTramThue) {
                alert("Bạn chỉ được nhập số!");
                $('#txtPhanTramThue_AddModal').focus();
                return false;
            }
            if (txtGiaBan === "") {
                alert("Vui lòng nhập giá bán!");
                $('#txtGiaBan_AddModal').focus();
                return false;
            }
            var isGiaBan = re.test(txtGiaBan);
            if (isGiaBan) {
                alert("Bạn chỉ được nhập số!");
                $('#txtGiaBan_AddModal').focus();
                return false;
            }
            cbThemMoi.PerformCallback()
        }
        function onClickThemMoiComplete(s, e) {
            if (e.result == "1") {
                alert("Thêm mới bảng giá điện thành công");
                location.href = "./DanhMucBangGiaDien.aspx";
            } else {
                alert("Thêm mới thất bại. Vui lòng thử lại!");
            }
        }
        //Sửa thông tin
        function onClickCapNhat() {
            var re = /d+/;
            var txtTenBangGia = $('#txtTenBangGia').val();
            var txtTenVietTat = $('#txtTenVietTat').val();
            var txtDonGia = $('#txtDonGia').val();
            var txtTienThue = $('#txtTienThue').val();
            var txtPhanTramThue = $('#txtPhanTramThue').val();
            var txtGiaBan = $('#txtGiaBan').val();

            if (txtTenBangGia === "") {
                alert("Vui lòng nhập tên bảng giá!");
                $('#txtTenBangGia').focus();
                return false
            }
            if (txtTenVietTat === "") {
                alert("Vui lòng nhập tên viết tắt!");
                $('#txtTenVietTat').focus();
                return false
            }
            var isDonGia = re.test(txtDonGia);
            if (isDonGia) {
                alert("Bạn chỉ được nhập số!");
                $('#txtDonGia').focus();
                return false;
            }
            var isTienThue = re.test(txtTienThue);
            if (isTienThue) {
                alert("Bạn chỉ được nhập số!");
                $('#txtTienThue').focus();
                return false;
            }
            var isPhanTramThue = re.test(txtPhanTramThue);
            if (isPhanTramThue) {
                alert("Bạn chỉ được nhập số!");
                $('#txtPhanTramThue').focus();
                return false;
            }
            var isGiaBan = re.test(txtGiaBan);
            if (isGiaBan) {
                alert("Bạn chỉ được nhập số!");
                $('#txtGiaBan').focus();
                return false;
            }
            cbCapNhat.PerformCallback()
        }
        function onClickCapNhatComplete(s, e) {
            if (e.result == "1") {
                alert("Cập nhật thành công");
                location.href = "./DanhMucBangGiaDien.aspx";
            } else {
                alert("Cập nhật thất bại. Vui lòng thử lại!");
            }
        }
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
            <button class="btn btn-primary" type="button" onclick="ThemMoi()">Thêm mới</button>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <asp:GridView ID="GridViewEman" ClientIDMode="Static" runat="server" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline" AutoGenerateColumns="False" OnRowCommand="GridView_OnRowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Mã công tơ">
                            <ItemTemplate>
                                <asp:Label ID="lblMaCTo" runat="server" Text='<%# Eval("ma_cong_to") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mã khách hàng">
                            <ItemTemplate>
                                <asp:Label ID="lblMaKh" runat="server" Text='<%# Eval("ma_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Chủng loại">
                            <ItemTemplate>
                                <asp:Label ID="lblChungLoai" runat="server" Text='<%# Eval("chung_loai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Hệ số ti">
                            <ItemTemplate>
                                <asp:Label ID="lblHeSoTi" runat="server" Text='<%# Eval("he_so_ti") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nhà sản xuất">
                            <ItemTemplate>
                                <asp:Label ID="lblNhaSanXuat" runat="server" Text='<%# Eval("nha_san_xuat") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ngày sử dụng">
                            <ItemTemplate>
                                <asp:Label ID="lblNgaySuDung" runat="server" Text='<%# Eval("ngay_sd") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ngày hết hạn">
                            <ItemTemplate>
                                <asp:Label ID="lblNgayHetHan" runat="server" Text='<%# Eval("ngay_het_han") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Trạng thái">
                            <ItemTemplate>
                                <asp:Label ID="lblTrangThai" runat="server" Text='<%# (int)Eval("trang_thai") == 1 ? "Active": "Deactive" %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID Trạng thái" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="lblIDTrangThai" runat="server" Text='<%# (int)Eval("trang_thai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Thao tác" ItemStyle-Width="100px" ItemStyle-CssClass="text-center" HeaderStyle-CssClass="text-center">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-success" ID="btnSua" runat="server" CommandName="suaGiaDien" Text="Sửa"></asp:Button>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <%--Thêm--%>
    <div class="modal fade" id="AddModal" tabindex="-1" role="dialog" aria-labelledby="EditModal" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Thêm công tơ</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="user-info-row" style="border: none">
                        <label class="key">Mã công tơ (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtMaCTo_AddModal" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Mã công tơ (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtMaKh_AddModal" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Chủng loại (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtChungLoai_AddModal" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Hệ số ti (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtHeSoTi_AddModal" ClientIDMode="Static" runat="server" type="number" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Nhà sản xuất (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtNhaSanXuat_AddModal" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Ngày sử dụng (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtNgaySD_AddModal" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Ngày hết hạn (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:TextBox ID="txtNgayHetHan_AddModal" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                    </div>
                    <div class="user-info-row">
                        <label class="key">Trạng thái (<span style="color: red">*</span>):</label>
                        <div class="value">
                            <asp:DropDownList runat="server" ClientIDMode="Static" ID="drpTrangThai_AddModal" DataValueField="ma_tt" DataTextField="ten_tt" CssClass="form-control input-lg"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" id="btnThem_AddModal" class="btn btn-success" onclick="onClickThemMoi();">Thêm mới</button>
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                    <dx:aspxcallback id="cbThemMoi" clientinstancename="cbThemMoi" clientidmode="Static" runat="server" oncallback="btnThemMoi_Callback">
                                  <ClientSideEvents CallbackComplete="onClickThemMoiComplete" />
                            </dx:aspxcallback>
                </div>
            </div>
        </div>
    </div>

    <%--Sửa--%>
    <asp:UpdatePanel ID="upModal" runat="server">
        <ContentTemplate>
            <div class="modal fade" id="EditModal" tabindex="-1" role="dialog" aria-labelledby="EditModal" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title">Sửa thông tin</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="user-info-row" style="border: none">
                                <label class="key">Mã công tơ (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtMaCTo" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Mã công tơ (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtMaKh" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Chủng loại (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtChungLoai" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Hệ số ti (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtHeSoTi" ClientIDMode="Static" runat="server" type="number" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Nhà sản xuất (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtNhaSanXuat" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Ngày sử dụng (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtNgaySD" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Ngày hết hạn (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:TextBox ID="txtNgayHetHan" ClientIDMode="Static" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                                </div>
                            </div>
                            <div class="user-info-row">
                                <label class="key">Trạng thái (<span style="color: red">*</span>):</label>
                                <div class="value">
                                    <asp:DropDownList runat="server" ClientIDMode="Static" ID="drpTrangThai" DataValueField="ma_tt" DataTextField="ten_tt" CssClass="form-control input-lg"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" id="btnCapNhat" class="btn btn-success" onclick="onClickCapNhat();">Cập nhập</button>
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                            <dx:aspxcallback id="cbCapNhat" clientinstancename="cbCapNhat" clientidmode="Static" runat="server" oncallback="btnSave_Callback">
                                <ClientSideEvents CallbackComplete="onClickCapNhatComplete" />
                            </dx:aspxcallback>
                        </div>
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
