<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Báo cáo khách hàng" EnableEventValidation="false" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeFile="BaoCaoDSKhachHang.aspx.cs" Inherits="BaoCaoDSKhachHang" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
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
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-12">
        </div>
    </div>

    <div class="card mb-3">

        <div>
            <fieldset style="width: 97%; font-family: Verdana; padding-top: 20px">
                <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana;
                    color: #000000; margin-top: 0px;">

                    <tr>
                        <td class="auto-style8">Trạm biến áp<span> (*):</span><asp:DropDownList ID="ddlTramBA"
                            runat="server" DataTextField="ten_tram_bien_ap"
                            DataValueField="id_tram_bien_ap" Width="264px" Height="26px">
                        </asp:DropDownList>
                        </td>
                        <td style="text-align: left;" class="auto-style4">
                            <span>Xóm/Khu (*):</span><asp:DropDownList ID="ddlXomKhu" runat="server" DataTextField="ten_khu"
                                DataValueField="id_khu" Width="264px" Height="26px">
                            </asp:DropDownList>
                        </td>

                    </tr>
                    <br />

                    <tr>
                        <td class="auto-style8"><span>Bảng giá điện(*):</span><asp:DropDownList ID="ddlBangGiaDien"
                            runat="server" DataTextField="ten_bang_gia"
                            DataValueField="id_bang_gia" Width="264px" Height="26px">
                        </asp:DropDownList>
                        </td>


                        <td style="text-align: left;" class="auto-style4">
                            <span>Chọn tháng, năm (*):</span><asp:DropDownList ID="ddlThang" runat="server" DataTextField="ca"
                                DataValueField="ca" Width="70px" Height="26px">
                                <asp:ListItem Value="01">01</asp:ListItem>
                                <asp:ListItem Value="02">02</asp:ListItem>
                                <asp:ListItem Value="03">03</asp:ListItem>
                                <asp:ListItem Value="04">04</asp:ListItem>
                                <asp:ListItem Value="05">05</asp:ListItem>
                                <asp:ListItem Value="06">06</asp:ListItem>
                                <asp:ListItem Value="07">07</asp:ListItem>
                                <asp:ListItem Value="08">08</asp:ListItem>
                                <asp:ListItem Value="09">09</asp:ListItem>
                                <asp:ListItem Value="10">10</asp:ListItem>
                                <asp:ListItem Value="11">11</asp:ListItem>
                                <asp:ListItem Value="12">12</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlNam"
                            runat="server" DataTextField="nam"
                            DataValueField="nam" Width="137px" Height="26px">
                        </asp:DropDownList>
                        </td>
                        

                    </tr>



                </table>
            </fieldset>

        </div>


        <div class="card-header">
            <td>
                <asp:Button ID="btnBaoCao" runat="server" Text="Xem" OnClick="XemBC"
                    CssClass="btn btn-primary" />
            </td>
            <td>
                <asp:Button ID="btnXuatExcel" runat="server" Text="Xuất excel" OnClick="XuatExcel"
                    CssClass="btn btn-primary" />
            </td>
        </div>
        <div class="form-group" style="clear: both;">
            <asp:Label ID="txtErr" runat="server" ForeColor="#FF3300"></asp:Label>
        </div>
        <div runat="server" id="Div1">

            <div class="box-body">
                <div class="row">
                    <div class="col-md-2"></div>
                    <%--<div class="col-md-12" runat="server" id="divTieuDe">
                                <label>
                                    Danh sách thuê bao<span class="style2" style="color: red">
                                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label></span>.</label>
                            </div>--%>
                    <div class="col-md-12">
                        <div class="form-group">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="Không có dữ liệu hiển thị"
                                CssClass="table table-striped table-bordered table-hover" OnPageIndexChanged="GridView1_PageIndexChanged"
                                OnPageIndexChanging="GridView1_PageIndexChanging" CellPadding="4" ForeColor="#333333"
                                GridLines="None">

                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />

                                <PagerSettings Mode="Numeric" Position="Bottom" PageButtonCount="20" />
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="stt" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"
                                        HeaderText="STT" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="ma_kh" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left"
                                        HeaderText="Mã KH" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="ten_kh" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left"
                                        HeaderText="Họ tên" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="dia_chi" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left"
                                        HeaderText="Địa chỉ" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="so_ho" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Left"
                                        HeaderText="Số hộ" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="ten_viet_tat" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Left"
                                        HeaderText="Loại hình" />
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="chi_so_cu" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right"
                                        HeaderText="CSĐK" DataFormatString="{0:0,0}"/>
                                </Columns>
                                <Columns>
                                    <asp:BoundField DataField="chi_so_moi" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right"
                                        HeaderText="CSCK" DataFormatString="{0:0,0}"/>
                                </Columns>

                                <Columns>
                                    <asp:BoundField DataField="dien_nang_tt" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right"
                                        HeaderText="Tiêu thụ" DataFormatString="{0:0,0}"/>
                                </Columns>
                                
                                 <Columns>
                                    <asp:BoundField DataField="tong_tien_sau_thue" HeaderStyle-HorizontalAlign="Right" ItemStyle-HorizontalAlign="Right"
                                        HeaderText="Sau thuế" DataFormatString="{0:0,0}"/>
                                </Columns>

                                <PagerStyle BackColor="#2461BF" ForeColor="Black" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        
        .auto-style4
        {
            height: 29px;
            width: 311px;
        }

        .auto-style8
        {
            height: 29px;
            width: 268px;
        }
    </style>
</asp:Content>


