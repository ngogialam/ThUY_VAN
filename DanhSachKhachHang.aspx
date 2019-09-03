<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Danh mục khách hàng" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="DanhSachKhachHang.aspx.cs" Inherits="DanhSachKhachHang" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <script>
        //Thêm mới
        function ThemMoi() {
            $('#AddModal').modal('show');
        }
        function onClickThemMoi() {
            var re = /d+/;
            var txtTenKH = $('#txtTenKh_AddModal').val();
            var txtDiaChi = $('#txtDiaChi_AddModal').val();
            var txtSoHo = $('#txtSoHo_AddModal').val();
            var txtHeSoTi = $('#txtHSTi_AddModal').val();
            var txtSDT = $('#txtSoDT_AddModal').val();
            var txtMaSoThue = $('#txtMstKH_AddModal').val();
            var txtSoCot = $('#txtSoCot_AddModal').val();
            var txtMaCongTo = $('#txtMaCongTo_AddModal').val();
            var txtSoDongHo = $('#txtSoDongHo_AddModal').val();
            var txtThuTu = $('#txtThuTu_AddModal').val();
            
            if (txtTenKH === "") {
                alert("Vui lòng nhập tên khách hàng!");
                $('#txtTenKh_AddModal').focus();
                return false
            }
            if (txtDiaChi === "") {
                alert("Vui lòng nhập địa chỉ!");
                $('#txtDiaChi_AddModal').focus();
                return false
            }
            if (txtSoHo === "") {
                alert("Vui lòng nhập số hộ!");
                $('#txtSoHo_AddModal').focus();
                return false
            }
            if (txtSoHo <= 0) {
                alert("Số hộ phải lớn hơn không!");
                $('#txtSoHo_AddModal').focus();
                return false
            }
            if (txtHeSoTi === "") {
                alert("Vui lòng nhập hệ số ti!");
                $('#txtHSTi_AddModal').focus();
                return false
            }
            if (txtHeSoTi <= 0) {
                alert("Hệ số ti phải lớn hơn không!");
                $('#txtHSTi_AddModal').focus();
                return false
            }
            if (txtSDT === "") {
                alert("Vui lòng nhập số điện thoại!");
                $('#txtSoDT_AddModal').focus();
                return false
            }
            var isDienThoai = re.test(txtSDT);
            if (isDienThoai) {
                alert("Bạn chỉ được nhập số!");
                $('#txtSoDT_AddModal').focus();
                return false;
            }
            if (txtMaSoThue === "") {
                alert("Vui lòng nhập mã số thuế!");
                $('#txtMstKH_AddModal').focus();
                return false
            }
            var isMaSoThue = re.test(txtMaSoThue);
            if (isMaSoThue) {
                alert("Bạn chỉ được nhập số!");
                $('#txtMstKH_AddModal').focus();
                return false;
            }
            if (txtSoCot === "") {
                alert("Vui lòng nhập số cột!");
                $('#txtSoCot_AddModal').focus();
                return false
            }
            var isSoCot = re.test(txtSoCot);
            if (isSoCot) {
                alert("Bạn chỉ được nhập số!");
                $('#txtSoCot_AddModal').focus();
                return false;
            }
            if (txtMaCongTo === "") {
                alert("Vui lòng nhập mã công tơ!");
                $('#txtMaCongTo_AddModal').focus();
                return false
            }
            if (txtSoDongHo === "") {
                alert("Vui lòng nhập số đồng hồ!");
                $('#txtSoDongHo_AddModal').focus();
                return false
            }
            if (txtSoDongHo <= 0) {
                alert("Số đồng hồ phải lớn hơn 0!");
                $('#txtSoDongHo_AddModal').focus();
                return false
            }
            if (txtThuTu === "") {
                alert("Vui lòng nhập thứ tự!");
                $('#txtThuTu_AddModal').focus();
                return false
            }
            if (txtThuTu <= 0) {
                alert("Thứ tự phải lớn hơn 0!");
                $('#txtThuTu_AddModal').focus();
                return false
            }
            //var isMaCongTo = re.test(txtMaCongTo);
            //if (isMaCongTo) {
            //    alert("Bạn chỉ được nhập số!");
            //    $('#txtMaCongTo_AddModal').focus();
            //    return false;
            //}
            cbThemMoi.PerformCallback();
        }
        function onClickThemMoiComplete(s, e) {
            if (e.result == "1") {
                alert("Thêm mới khách hàng thành công");
                location.href = "./DanhSachKhachHang.aspx";
            } else {
                alert("Thêm mới thất bại. Vui lòng thử lại!");
            }
        }

        //Sửa thông tin
        function onClickCapNhat() {
            var re = /d+/;
            var txtTenNV = $('#txtTeNV').val();
            var txtDiaChi = $('#txtDiaChi').val();
            var txtDienThoai = $('#txtDienThoai').val();
            var txtChiChu = $('#txtGhiChu').val();
            if (txtTenNV === "") {
                alert("Vui lòng nhập tên nhân viên!");
                $('#txtTeNV').focus();
                return false
            }

            if (txtDiaChi === "") {
                alert("Vui lòng nhập địa chỉ!");
                $('#txtDiaChi').focus();
                return false
            }

            if (txtDienThoai === "") {
                alert("Vui lòng nhập số điện thoại!");
                $('#txtDienThoai').focus();
                return false
            }
            var isDienThoai = re.test(txtDienThoai);
            if (isDienThoai) {
                alert("Bạn chỉ được nhập số!");
                $('#txtDienThoai').focus();
                return false;
            }

            cbCapNhat.PerformCallback()
        }
        function onClickCapNhatComplete(s, e) {
            if (e.result == "1") {
                alert("Cập nhật thành công");
                location.href = "./DanhSachKhachHang.aspx";
            } else {
                alert("Cập nhật thất bại. Vui lòng thử lại!");
            }
        }
    </script>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <style>
        .column {
            float: left;
            width: 50%;
            padding: 5px 5px 5px 5px;
        }

        @media screen and (max-width: 600px) {
            .column {
                width: 100%;
            }
        }

        .noBorder {
            border: none;
        }

        span > label {
            margin: 0 0 0 5px;
        }
    </style>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="row">
        <div class="col-12">
        </div>
    </div>

    <div class="card mb-3">
        <div class="card-header">
            <div class="row">
                <div class="col-sm-6 mb-1">
                    <button id="btnThemMoiKhu" class="btn btn-primary" type="button" onclick="ThemMoi()">Thêm mới</button>
                </div>
                <div class="col-sm-3 mb-1">
                    <asp:DropDownList runat="server" ID="drpTramBienAp_1" DataValueField="id_tram_bien_ap" DataTextField="ten_tram_bien_ap" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="col-sm-3 mb-1">
                    <asp:Button ID="btnLaySL" runat="server" Text="Lấy số liệu" CssClass="btn btn-primary" OnClick="btnLaySL_Click" />
                </div>
            </div>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <asp:GridView ID="GridViewEman" ClientIDMode="Static" runat="server" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline" AutoGenerateColumns="false" OnRowCommand="GridView_OnRowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="STT" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center">
                            <ItemTemplate>
                                <asp:Label ID="lblStt" runat="server" Text='<%# Eval("thu_tu") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
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
                        <asp:TemplateField HeaderText="Gửi SMS">
                            <ItemTemplate>
                                <asp:Label ID="lblSms" runat="server" Text='<%# (int)Eval("sms") == 1 ? "Có": "Không" %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Trạng thái SMS" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblNumSms" runat="server" Text='<%# Eval("sms") %>'></asp:Label>
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
                        <asp:TemplateField HeaderText="Mã công tơ" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="lblMaCongTo" runat="server" Text='<%# Eval("ma_cong_to") %>'></asp:Label>
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
                        <asp:TemplateField HeaderText="Thao tác" ItemStyle-Width="100px" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-success" ID="btnHuy" runat="server" CommandName="suaKH" Text="Sửa"></asp:Button>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <%--Thêm--%>
    <div class="modal fade" id="AddModal" tabindex="-1" role="dialog" aria-labelledby="AddModal" aria-hidden="true">
        <div class="modal-dialog modal-lg" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="huyModalLable">Sửa thông tin</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="column">
                        <div class="user-info-row" style="border: none">
                            <label class="key">Tên khách hàng (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtTenKh_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row">
                            <label class="key">Địa chỉ (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtDiaChi_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Khu (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:DropDownList ID="drpKhu_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_khu" DataValueField="id_khu">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Phường/Xã (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:DropDownList ID="drpPhuongXa_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_phuong_xa" DataValueField="id_phuong_xa">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Huyện/Tp (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:DropDownList ID="drpHuyen_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_huyen" DataValueField="id_huyen">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Bảng giá (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:DropDownList ID="drpBangGia_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_bang_gia" DataValueField="id_bang_gia">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Trạm biến áp (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:DropDownList ID="drpTramBienAp_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_tram_bien_ap" DataValueField="id_tram_bien_ap">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Số hộ (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtSoHo_AddModal" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                        </div>
                    </div>
                    <div class="column">
                        <div class="user-info-row" style="border: none">
                            <label class="key">Hệ số ti (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtHSTi_AddModal" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>

                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Điện thoại (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtSoDT_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Mã Mst KH (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtMstKH_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Cột số (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtSoCot_AddModal" runat="server" ClientIDMode="Static" Text="0" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Mã công tơ (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtMaCongTo_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Số đồng hồ (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:TextBox ID="txtSoDongHo_AddModal" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Gửi sms (<span style="color: red">*</span>):</label>
                            <div class="value">
                                <asp:DropDownList ID="drpSms_AddModal" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten" DataValueField="trang_thai"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="user-info-row ">
                            <label class="key">Thứ tự:</label>
                            <div class="value">
                                <asp:TextBox ID="txtThuTu_AddModal" runat="server" type="number" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                            </div>
                        </div>
                        <div class="user-info-row " style="display: block">
                            <label class="key">Trạng thái:</label>
                            <div class="value">
                                <asp:CheckBox ID="ckbTrangThai_AddModal" runat="server" ClientIDMode="Static"/>
                                <label>Kích hoạt</label>
                            </div>
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
                <div class="modal-dialog modal-lg" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title">Sửa thông tin</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="column">
                                <div class="user-info-row" style="border: none">
                                    <label class="key">Mã khách hàng (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtMaKH" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row">
                                    <label class="key">Tên khách hàng (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtTenKh" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row">
                                    <label class="key">Địa chỉ (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtDiaChi" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Khu (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:DropDownList ID="cbKhu" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_khu" DataValueField="id_khu">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Phường/Xã (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:DropDownList ID="drpPhuongXa" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_phuong_xa" DataValueField="id_phuong_xa">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Huyện/Tp (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:DropDownList ID="drpHuyen" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_huyen" DataValueField="id_huyen">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Bảng giá (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:DropDownList ID="drpBangGia" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_bang_gia" DataValueField="id_bang_gia">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Trạm biến áp (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:DropDownList ID="drpTramBienAp" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten_tram_bien_ap" DataValueField="id_tram_bien_ap">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Số hộ (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtSoHo" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                            <div class="column">
                                <div class="user-info-row" style="border: none">
                                    <label class="key">Hệ số ti (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtHSTi" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>

                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Điện thoại (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtSoDT" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Mã Mst KH (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtMstKH" runat="server" ClientIDMode="Static" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Cột số (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtSoCot" runat="server" ClientIDMode="Static" Text="0" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Mã công tơ (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtMaCongTo" runat="server" ClientIDMode="Static" Enabled="false" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Số đồng hồ (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtSoDongHo" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Gửi sms (<span style="color: red">*</span>):</label>
                                    <div class="value">
                                        <asp:DropDownList ID="drpSms" runat="server" ClientIDMode="Static" CssClass="form-control input-lg" DataTextField="ten" DataValueField="trang_thai"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Thứ tự:</label>
                                    <div class="value">
                                        <asp:TextBox ID="txtThuTu" runat="server" ClientIDMode="Static" type="number" CssClass="form-control input-lg"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="user-info-row ">
                                    <label class="key">Trạng thái:</label>
                                    <div class="value">
                                        <asp:CheckBox ID="ckbTrangThai" runat="server" ClientIDMode="Static" CssClass="form-control input-lg noBorder" Text="Kích hoạt" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" id="btnCapNhat" class="btn btn-success" onclick="onClickCapNhat();">Cập nhật</button>
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                            <dx:aspxcallback id="cbCapNhat" clientinstancename="cbCapNhat" clientidmode="Static" runat="server" oncallback="btnCapNhat_Callback">
                                  <ClientSideEvents CallbackComplete="onClickCapNhatComplete" />
                            </dx:aspxcallback>
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

