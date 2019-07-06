<%@ Page Language="C#" Title="Quản lý phiếu thu" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ChotCa.aspx.cs" Inherits="ChotCa" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">     
  
 <script type="text/javascript">
     function CheckAll(oCheckbox) {
         var GridView1 = document.getElementById("<%=GirdViewNoPaGE.ClientID%>");        
         for (i = 1; i < GridView1.rows.length; i++) {
             GridView1.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
         }
     }
    </script>

</asp:Content>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
  
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div id="page-wrapper">  
        <div class="row">
            <div class="col-xl-3 col-sm-4 mb-2">
                <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCa">
                    <asp:ListItem Selected="True" Value="0">--Chọn ca--</asp:ListItem>
                    <asp:ListItem Value="3">Ca 3</asp:ListItem>
                    <asp:ListItem Value="1">Ca 1</asp:ListItem>
                    <asp:ListItem Value="2">Ca 2</asp:ListItem>
                </asp:DropDownList>
            
            </div>
            <div class="col-xl-3 col-sm-4 mb-2">
                <asp:DropDownList CssClass="form-control" runat="server" ID="ddlNguoiBan">                    
                </asp:DropDownList>
                         
            </div>

            <div class="col-xl-3 col-sm-2 mb-2">                
                <asp:Button ID="btnChotCa" runat="server" class="btn btn-danger" Text="Chốt ca" OnClick="btnChotCa_Click" OnClientClick="return confirm('Sau khi chốt ca sẽ không thể sửa. Bạn có chắc chắn chốt ca?')" />
            </div>
        </div>
        <div class="row">
                <div class="col-sm-12 mb-2">
                <asp:Label runat="server" ID="txtErr" Font-Size="14px" ></asp:Label>
            </div>
        </div>
      
    <div class="card mb-3">
        <div class="card-header">
            Chọn phiếu thu chưa chốt ca - <b>Các phiếu thu nhập sau 21h00 sẽ tính vào ngày hôm sau</b>
        </div>
        <div class="card-body-5">
            <div class="table-responsive">
                <asp:GridView ID="GirdViewNoPaGE" ClientIDMode="Static" runat="server" CssClass="table table-responsive table-bordered" AutoGenerateColumns="false">
                    <Columns>                         
                        <asp:TemplateField HeaderText="Lựa chọn">
                            <HeaderTemplate>
                                <input id="Checkbox2" class="checkbox" type="checkbox" onclick="CheckAll(this)" runat="server" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="ChkBox" CssClass="checkbox" runat="server" AutoPostBack="false" OnCheckedChanged="ChkBox_CheckedChanged"/>
                            </ItemTemplate>
                        </asp:TemplateField>                                
                        <asp:TemplateField HeaderText="Số phiếu">
                            <ItemTemplate>
                                <asp:Label ID="lblSoHD" runat="server" Text='<%# Eval("ma_hd") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>   
                        <asp:TemplateField HeaderText="Tên khách hàng" >
                            <ItemTemplate>
                                <asp:Label ID="lblTenKH" runat="server" Text='<%# Eval("ten_kh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Bia hơi (lít)">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBH" runat="server" Text='<%# Eval("tong_bh") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  
                         <asp:TemplateField HeaderText="Bia keg 2L (keg)">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBK2" runat="server" Text='<%# Eval("tong_bk2") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:TemplateField HeaderText="Bia keg 1L (keg)">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBK1" runat="server" Text='<%# Eval("tong_bk1") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>                        
                        <asp:TemplateField HeaderText="Bia chai 1L (lít)">
                            <ItemTemplate>
                                <asp:Label ID="lblTongBC" runat="server" Text='<%# Eval("tong_bc") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  
                       <%-- <asp:TemplateField HeaderText="Người bán">
                            <ItemTemplate>
                                <asp:Label ID="lblNguoiBan" runat="server" Text='<%# Eval("nguoiban") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>  --%>
                        <asp:TemplateField HeaderText="Ngày bán">
                            <ItemTemplate>
                                <asp:Label ID="lblNgayBan" runat="server" Text='<%# Eval("ngayban") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Trạng thái">
                            <ItemTemplate>
                                <asp:Label ID="lbltt" CssClass="" runat="server" Text='<%# Eval("ten_trangthai") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>  
        </div>
        
</asp:Content>