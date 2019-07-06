<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Báo cáo thống kê" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="BaoCaoThongKe.aspx.cs" Inherits="BaoCaoThongKe" %>

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
    <div class="card mb-3">
       <div class="card-body">           
            <div class="table-responsive">
          <fieldset style="width: 97%; font-family: Verdana; padding-top: 20px">
              <table align="center" border="0" width="100%" style="font-size: 13px; font-family: Verdana;
                    color: #000000; margin-top: 0px;">                                    
                    <tr>
                        <td class="auto-style8">
                            <span >Chọn báo cáo (*):</span><asp:DropDownList ID="cbLoaiBC" runat="server" DataTextField="ten_bc" 
                                DataValueField="id_dia_ban" Width="264px" Height="26px">
                                <asp:ListItem Value="0">Báo cáo sản lượng tiêu thụ hàng ngày</asp:ListItem>
                                                
                            </asp:DropDownList>
                        </td>
                        <td style="text-align: left;" class="auto-style4">
                             <span >Chọn địa bàn (*):</span><asp:DropDownList ID="ddlDiaBan" runat="server" DataTextField="ten_dia_ban" 
                                DataValueField="id_dia_ban" Width="264px" Height="26px">
                            </asp:DropDownList>
                        </td>
                       
                    </tr>
                    <br />            
                 
                    <tr>
                         <td class="auto-style11">
                                <label>
                                    Từ Ngày:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      <input type="text" id="txtTuNgay" autocomplete="off" autocomplete="off">
                                    <input type="hidden" id="strTuNgay" name="strTuNgay" value="-1" />
                                </label>
                         </td>
                         <td class="auto-style2">
                                <label>
                                    Đến Ngày:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input type="text" id="txtDenNgay" autocomplete="off" autocomplete="off">
                                    <input type="hidden" id="strDenNgay" name="strDenNgay" value="-1" />

                                </label>
                          </td>
                           
                    </tr>
                        
                
                    
                </table>
            </fieldset>
            </div>
        </div>


         <div class="card-header">
         <td>
           <asp:Button ID="btnBaoCao" runat="server" Text="Xem" OnClick="XemBC"
                CssClass="btn btn-primary" />
                </td>
                 
        </div>
         <div class="form-group" style="clear: both;">
            <asp:Label ID="txtErr" runat="server" ForeColor="#FF3300"></asp:Label>
        </div>     
        
       <div runat="server" id="Div1">

                    <div class="box-header">
                        <tr>
                            <td style="width: 50%">
                                <label>
                                    Số liệu <span class="style2" style="color: red">
                                        <asp:Label ID="lbl_solieu" runat="server" Text=""></asp:Label></span>
                                </label>
                            </td>
                            <br />
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                <label>
                                    Tổng số bia hơi : <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBH" runat="server" Text=""></asp:Label></span>.</label>
                                </td>
                              <td style="width: 50%">
                                <label>
                                    <label>
                                    Tổng số bia keg 2L: <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBK2" runat="server" Text=""></asp:Label></span>.</label>
                                    Tổng số bia keg 1L: <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBK" runat="server" Text=""></asp:Label></span>.</label>                               

                               
                               </td>
                                 <td style="width: 50%">
                                <label>
                                    Tổng số bia chai 1L: <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBC" runat="server" Text=""></asp:Label></span>.</label>
                                </td>
                             
                        </tr>
                    </div>
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
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="Không có dữ liệu hiển thị" CssClass="table table-striped table-bordered table-hover" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging"  CellPadding="4" ForeColor="#333333" GridLines="None">

                                        <EditRowStyle BackColor="#2461BF" />
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />

                                        <PagerSettings Mode="Numeric" Position="Bottom" PageButtonCount="20" />
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="stt" HeaderText="TT" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="ten_kh" HeaderText="Tên KH" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="dia_chi" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Địa chỉ" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="nam_bh" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Năm bh" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="so_dt" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Số ĐT" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="tong_bh" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Bia hơi" />
                                        </Columns>                                        
                                        <Columns>
                                            <asp:BoundField DataField="tong_bk2" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Bia keg 2L" />
                                        </Columns>
                                         <Columns>
                                            <asp:BoundField DataField="tong_bk1" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Bia keg 1L" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="tong_bc" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Bia chai 1L" />
                                        </Columns>
                                         <Columns>
                                            <asp:BoundField DataField="ca" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Ca" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="ten_dia_ban" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Địa bàn" />
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

                <div class="card-header">
                           <td>
                                <asp:Button ID="btnXuatExcel" runat="server" Text="Xuất excel" OnClick="XuatExcel"
                             CssClass="btn btn-primary" />
                            </td>
                </div>
         


    </div>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2
        {
            height: 50px;
        }
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
        .auto-style11
        {
            height: 50px;
            width: 268px;
        }
    </style>
</asp:Content>


