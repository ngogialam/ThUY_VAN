<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThongKeBangThong.aspx.cs" Inherits="BaoCao_ThongKeBangThong" %>--%>

<%@ Page Language="C#" Title="Báo cáo theo ca" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="BaoCaoTheoCa.aspx.cs" Inherits="BaoCaoTheoCa" %>

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
                        <td class="auto-style8">
                            <span >Chọn báo cáo (*):</span><asp:DropDownList ID="cbLoaiBC" runat="server" DataTextField="ten_bc" 
                                DataValueField="id_dia_ban" Width="264px" Height="26px">
                                                <asp:ListItem Value="0">Báo cáo sản lượng theo ca</asp:ListItem>
                                                
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
                                    Từ Ngày:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      <input type="text" id="txtTuNgay" autocomplete="off">
                                    <input type="hidden" id="strTuNgay" name="strTuNgay" value="-1" />
                                </label>
                         </td>
                         <td class="auto-style2">
                                <label>
                                    Đến Ngày:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input type="text" id="txtDenNgay" autocomplete="off">
                                    <input type="hidden" id="strDenNgay" name="strDenNgay" value="-1" />

                                </label>
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
                                    Tổng số bia hơi 50L : <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBH50L" runat="server" Text=""></asp:Label></span>.</label>
                                </td>
                                <td style="width: 50%">
                                <label>
                                    Tổng số bia hơi 30L : <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBH30L" runat="server" Text=""></asp:Label></span>.</label>
                                </td>
                                <td style="width: 50%">
                                <label>
                                    Tổng số bia hơi 20L : <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBH20L" runat="server" Text=""></asp:Label></span>.</label>
                                </td>
                            <td style="width: 50%">
                               <label>
                                    Tổng số bia lẻ: <span class="style2" style="color: red">
                                        <asp:Label ID="lblBiaLe" runat="server" Text=""></asp:Label></span>.</label>
                               </td>
                                <td style="width: 50%">
                               <label>
                                    Tổng số bia keg 2L: <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBK2" runat="server" Text=""></asp:Label></span>.</label>
                               </td>
                               <td style="width: 50%">
                                <label>
                                    Tổng số bia keg 1L: <span class="style2" style="color: red">
                                        <asp:Label ID="lblTongBK" runat="server" Text=""></asp:Label></span>.</label>
                               </td>
                               
                               
                               <td style="width: 50%">
                               <label>
                                    Tổng số bia chai 1L: <span class="style2" style="color: red">
                                        <asp:Label ID="lblBiaChai" runat="server" Text=""></asp:Label></span>.</label>
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
                                            <asp:BoundField DataField="ca" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" HeaderText="Ca" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="bia_hoi50L" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia hơi 50L" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="bia_hoi30L" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia hơi 30L" />
                                        </Columns>
                                         <Columns>
                                            <asp:BoundField DataField="bia_hoi20L" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia hơi 20L" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="bia_le" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia lẻ" />
                                        </Columns>
                                         <Columns>
                                            <asp:BoundField DataField="bia_keg2L" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia keg 2L" />
                                        </Columns>
                                        <Columns>
                                            <asp:BoundField DataField="bia_keg1L" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia keg 1L" />
                                        </Columns>                                       
                                        
                                        <Columns>
                                            <asp:BoundField DataField="bia_chai" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderText="Bia chai 1L" />
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


