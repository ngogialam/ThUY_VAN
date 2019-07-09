<%@ Page Title="Báo cáo tổng hợp" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BaoCaoThongKe.aspx.cs" Inherits="BAO_CAO_BaoCaoThongKe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <div class="form-group row" style="margin-left:10px">
        <section class="content">
          <!-- Box danh sách -->
          <div class="box box-primary" id="box_content1">   
            <div class="box-header with-border">
                <h3 class="box-title">BÁO CÁO TỔNG HỢP </h3>
                <%--<span class="pull-right" style="font-style:italic"><strong style="color:red">Dữ liệu hệ thống từ ngày  <asp:Label ID="lblTuNgay" runat="server" Text=""></asp:Label>      đến ngày   <asp:Label ID="lblDenNgay" runat="server" Text=""></asp:Label></strong></span>--%>
            </div>         
            <div class="box-body" id="boxBody">
                
            <div class="box-footer" style="text-align:center">
            <asp:Button ID="btnInLD" runat="server" Text="In báo cáo LĐ" class="btn btn-sm btn-primary btn-flat" style="margin-top:4px" OnClick="Button3_Click" Visible="true" />
                <asp:Button ID="btnInLD_DV" runat="server" Text="In báo cáo LĐ" class="btn btn-sm btn-primary btn-flat" style="margin-top:4px" Visible="true" OnClick="btnInLD_DV_Click" />
                <asp:Button ID="btnInGiu" runat="server" Text="In báo cáo lương giữ" class="btn btn-sm btn-primary btn-flat" style="margin-top:4px" Visible="true" OnClick="btnInGiu_Click" />
                <asp:Button ID="btnInTang" runat="server" Text="In báo cáo lương tăng" class="btn btn-sm btn-primary btn-flat" style="margin-top:4px" Visible="true" OnClick="btnInTang_Click" />
                <asp:Button ID="btnInGiu_DV" runat="server" Text="In báo cáo lương giữ theo ĐV" class="btn btn-sm btn-primary btn-flat" style="margin-top:4px" Visible="true" OnClick="btnInGiu_DV_Click" />
                <asp:Button ID="btnInTang_DV" runat="server" Text="In báo cáo lương tăng theo ĐV" class="btn btn-sm btn-primary btn-flat" style="margin-top:4px" Visible="true" OnClick="btnInTang_DV_Click" />
            </div>
          </div>
          </div>
        </section>
     </div>
    <script type="text/javascript">

        </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

