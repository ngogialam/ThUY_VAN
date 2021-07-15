<%@ Page Language="C#" Title="Bảng kê hóa đơn điện tử" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="BangKeHDDT.aspx.cs" Inherits="BangKeHDDT" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">
   
    <script type="text/javascript">
        $(function () {
            $('#txtTuNgay').datepicker(
            {
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                yearRange: '1950:2100',
                onSelect: function () {
                    var date = $.datepicker.formatDate('yymmdd', $(this).datepicker('getDate'));
                    $("#strTuNgay").val(date);

                }
            });
            $('#txtDenNgay').datepicker(
           {
               dateFormat: 'dd/mm/yy',
               changeMonth: true,
               changeYear: true,
               yearRange: '1950:2100',
               onSelect: function () {
                   var date = $.datepicker.formatDate('yymmdd', $(this).datepicker('getDate'));
                   $("#strDenNgay").val(date);
               }
           });

        })
      
    </script>
</asp:Content>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <div class="card mb-3">
        <div class="card-header">
            <div class="row">
                <div class="col-sm-4 mb-1">
                    <label>
                        Từ ngày
                    </label>
                    <br />
                    <input type="text" class="form-group" id="txtTuNgay" autocomplete="off">
                    <input type="hidden" id="strTuNgay" name="strTuNgay" value="-1" />
                </div>
                <div class="col-sm-4 mb-1">
                    <label>
                        Đến ngày
                    </label>
                    <br />

                    <input type="text" id="txtDenNgay" autocomplete="off">
                    <input type="hidden" id="strDenNgay" name="strDenNgay" value="-1" />
                </div>
                <div class="col-sm-4 mb-1">
                    <asp:Button ID="btnLayPT" runat="server" Text="Xem bảng kê" CssClass="btn btn-primary top30" OnClick="btnLayPT_Click" />
                </div>
            </div>
            <div class="row">
                <asp:Label ID="txtErr" runat="server" ForeColor="#FF3300"></asp:Label>
            </div>
        </div>
        <div class="card-body-5">
            <div class="table-responsive">
                <asp:GridView ID="GridViewBangKe" ClientIDMode="Static" runat="server" CssClass="table table-responsive table-bordered"  AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="Ngày phát hành">
                            <ItemTemplate>
                                <asp:Label ID="lblNgayPH" runat="server" Text='<%# Eval("ngay_ph") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số hóa đơn">
                            <ItemTemplate>
                                <asp:Label ID="lblSoHD" runat="server" Text='<%# Eval("so_hd") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Mã khách hàng">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ma_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Người mua" HeaderStyle-CssClass="min-width200">
                            <ItemTemplate>
                                <asp:Label ID="lblTenKH" runat="server" Text='<%# Eval("nguoi_mua") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đơn vị" HeaderStyle-CssClass="min-width200">
                            <ItemTemplate>
                                <asp:Label ID="lblDonVi" runat="server" Text='<%# Eval("don_vi") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                           <asp:TemplateField HeaderText="Mã sản phẩm">
                            <ItemTemplate>
                                <asp:Label ID="lblMaSP" runat="server" Text='<%# Eval("ma_sp") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sản phẩm">
                            <ItemTemplate>
                                <asp:Label ID="lblSP" runat="server" Text='<%# Eval("san_pham") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đơn vị tính">
                            <ItemTemplate>
                                <asp:Label ID="lblSP" runat="server" Text='<%# Eval("dvt") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Số lượng">
                            <ItemTemplate>
                                <asp:Label ID="lblSo_luong" runat="server" Text='<%# Eval("so_luong") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Đơn giá">
                            <ItemTemplate>
                                <asp:Label ID="lblDonGia" runat="server" Text='<%# string.Format("{0:#,0}",Eval("don_gia")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField HeaderText="Doanh thu">
                            <ItemTemplate>
                                <asp:Label ID="lblDoanhthu" runat="server" Text='<%# string.Format("{0:#,0}",Eval("thanh_tien")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tiền thuế">
                            <ItemTemplate>
                                <asp:Label ID="lblTienthue" runat="server" Text='<%# string.Format("{0:#,0}",Eval("tien_thue")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tổng tiền">
                            <ItemTemplate>
                                <asp:Label ID="lblTongTien" runat="server" Text='<%# string.Format("{0:#,0}",Eval("tong_tien")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>                      
                                               
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

   
</asp:Content>
