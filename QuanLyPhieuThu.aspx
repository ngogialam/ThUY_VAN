<%@ Page Language="C#" Title="Quản lý phiếu thu" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="QuanLyPhieuThu.aspx.cs" Inherits="QuanLyPhieuThu" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">
    <script>
        function PrintPanel() {
            var panel = document.getElementById("pnlContents");
            var printWindow = window.open('', '', 'height=800,width=1000');
            printWindow.document.write('<html><head><title>In phiếu xuất kho</title>');
            printWindow.document.write('<link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />');
            printWindow.document.write('<style type="text/css">');
            printWindow.document.write(' .table-print > thead > tr > th, .table-print > tbody > tr > th, .table-print > tfoot > tr > th, .table-print > thead > tr > td, .table-print > tbody > tr > td, .table-print > tfoot > tr > td {');
            printWindow.document.write('border: 1px solid #000000;');
            printWindow.document.write('}</style></head><body><div style="width: 886px;display: block;margin-left: auto;margin-right: auto;font-size:18px !important">');
            printWindow.document.write(panel.innerHTML);
            printWindow.document.write('</div></body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 00);
            //printWindow.close();

        }
    </script>
   
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
            Danh sách phiếu thu
        </div>
        <div class="card-body-5">
            <div class="table-responsive">
                <asp:GridView ID="GirdView" ClientIDMode="Static" runat="server" CssClass="table table-responsive table-bordered" OnRowCommand="GridView_OnRowCommand" AutoGenerateColumns="false" >
                    <Columns>         
                        <asp:TemplateField HeaderText="Số">
                            <ItemTemplate>
                                <asp:Label ID="lblSoHD" runat="server" Text='<%# Eval("ma_hd") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>   
                        <asp:TemplateField HeaderText="Tên khách hàng" HeaderStyle-CssClass="min-width200">
                            <ItemTemplate>
                                <asp:Label ID="lblTenKH" runat="server" Text='<%# Eval("ten_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Phường/Xã">
                            <ItemTemplate>
                                <asp:Label ID="lblDC" runat="server" Text='<%# Eval("ten_dia_ban") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="B.Hơi">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBH" runat="server" Text='<%# Eval("tong_bh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  
                          <asp:TemplateField HeaderText="Keg 2L">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBK2" runat="server" Text='<%# Eval("tong_bk2") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:TemplateField HeaderText="Keg 1L">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBK1" runat="server" Text='<%# Eval("tong_bk1") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>                       
                        <asp:TemplateField HeaderText="Chai 1L">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBC" runat="server" Text='<%# Eval("tong_bc") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>                         
                        <asp:TemplateField HeaderText="Ngày bán" >
                            <ItemTemplate>
                                <asp:Label ID="lblNgayBan" runat="server" Text='<%# Eval("ngayban") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ca">
                            <ItemTemplate>
                                <asp:Label ID="lblCa" runat="server" Text='<%# Eval("ca") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Người bán" HeaderStyle-CssClass="min-width150">
                            <ItemTemplate>
                                <asp:Label ID="lblNguoiBan" runat="server" Text='<%# Eval("nguoiban") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:TemplateField HeaderText="Trạng thái">
                            <ItemTemplate>
                                <asp:Label ID="lbltt" CssClass="" runat="server" Text='<%# Eval("ten_trangthai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField  HeaderText="Thao tác" ItemStyle-Width="100px">
                            <ItemTemplate>
                                <asp:Button CssClass="btn btn-danger float-left btnpt" ID="btnHuy" runat="server" CommandName="huyHD" Text="Hủy" ></asp:Button>
                                <asp:Button CssClass="btn btn-primary float-left btnpt" ID="btnIn" runat="server" CommandName="inHD" Text="In phiếu"></asp:Button>                                
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <asp:UpdatePanel ID="upModal" runat="server">   
    <ContentTemplate>       
        <div class="modal fade" id="huyModal" tabindex="-1" role="dialog" aria-labelledby="huyModal" aria-hidden="true">
          <div class="modal-dialog" role="document">
            <div class="modal-content">
              <div class="modal-header">
                <h5 class="modal-title" id="huyModalLable">Bạn có chắc chắn muốn hủy phiếu?</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                  <span aria-hidden="true">&times;</span>
                </button>
              </div>
              <div class="modal-body">               
                   Số phiếu: <b><asp:Label ID="lblID" runat="server"></asp:Label></b>  <br />
                   Khách hàng: <b><asp:Label ID="lblName" runat="server"></asp:Label></b>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Quay lại</button>
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" CssClass="btn btn-danger" UseSubmitBehavior="false" Text="Hủy phiếu" data-dismiss="modal" />
              </div>
            </div>
          </div>
        </div>
        
    <asp:Panel ID="pnlContents" runat="server" CssClass="hidden"  ClientIDMode="Static">    
        <div style="text-align: left; height: 80px;">
            <p style="margin: 0; font-size: 20px"><b>CÔNG TY CỔ PHẦN BIA RƯỢU NƯỚC GIẢI KHÁT VIGER</b></p>
            <p style="margin-top: 5px; font-size: 18px">
                Địa chỉ: Khu 7, Phường Thanh Miếu, Thành phố Việt Trì, Phú Thọ<br />
                Điện thoại: 02103 862 721
            </p>          
        </div>
        <div class="row">
            <div class="col-sm-12 mb-3" style="text-align: center">
                    <p style="margin: 0; font-size: 30px"><b>PHIẾU XUẤT KHO</b></p>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4 mb-3" style="text-align: right">
                
            </div>
            <div class="col-sm-4 mb-3" style="text-align: center">
                <asp:Label runat="server" ID="inlblngaythang"></asp:Label>
            </div>
            <div class="col-sm-4 mb-3" style="text-align: center">
                    Số: <b><asp:Label runat="server" ID="inlblSoPhieu"></asp:Label></b>
            </div>
        </div>            
            <div class="row">
            <div class="col-sm-8 mb-3" style="text-align: left">
                <p style="margin: 0;">Khách hàng:<b> <asp:Label runat="server"  ID="inlblName"></asp:Label></b></p>
            </div>
            <div class="col-sm-4 mb-3" style="text-align: left">
                    <p style="margin: 0;">Điện thoại:<b> <asp:Label runat="server"  ID="inlblDT"></asp:Label></b></p>
            </div>           
        </div> 
        <div class="row">
            <div class="col-sm-8 mb-3" style="text-align: left">
                <p style="margin: 0;">Địa chỉ:<b> <asp:Label runat="server" ID="inlblDiaChi"></asp:Label></b></p>
            </div>
            <div class="col-sm-4 mb-3" style="text-align: left">
                    <p style="margin: 0;">Phường/Xã:<b> <asp:Label runat="server" ID="inlblDiaBan"></asp:Label></b></p>
            </div>           
        </div> 
        <table runat="server" style="width:100%; padding-top: 10px;text-align:center" id="inDSSanPham" class="table table-print">
            <thead>
                <tr>
                    <th style="width:23px">
                    STT
                    </th>
                    <th style="width:150px">
                    Sản phẩm
                    </th>
                    <th style="width:120px">
                    Đơn vị tính 
                    </th>
                    <th style="width:100px">
                    Số lượng
                    </th>  
                    <th style="width:180px">
                    Số lượng bằng chữ
                    </th>                 
                </tr>
                </thead>
            <tbody>
            </tbody>
        </table>
        <div class="row">
            <div class="col-sm-3 mb-3" style="text-align: right">                
            </div>
            <div class="col-sm-3 mb-3" style="text-align: right">                
            </div>
            <div class="col-sm-6 mb-3" style="text-align: center; height:150px;padding-top:10px;">
                    <b style="margin-left: 0px;">Người bán hàng</b><br />
                <i style="margin-left: 0px;">(Ký, ghi rõ họ, tên)</i>
            </div>           
        </div>
            <div class="row">
                <div class="col-sm-3 mb-3" style="text-align: right">                
            </div>
            <div class="col-sm-3 mb-3" style="text-align: right">                
            </div>
            <div class="col-sm-6 mb-3" style="text-align: center; padding-top:10px;">
                
            </div>
        </div>
    </asp:Panel>      
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="GirdView"  EventName="RowCommand" />  
</Triggers>
</asp:UpdatePanel>
</asp:Content>