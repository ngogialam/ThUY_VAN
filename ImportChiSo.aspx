<%@ Page Language="C#" Title="Import CS Excel" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ImportChiSo.aspx.cs" Inherits="ImportChiSo" ResponseEncoding="utf-8" %>

<asp:Content runat="server" ID="head" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-12">
            <h2>Import CS từ Excel</h2>
        </div>
    </div>
    <div class="card mb-3">
        <div class="card-header">
            <div class="row">
                <div class="col-sm-12">
                    <p class="text-info">
                        <strong>Hướng dẫn:</strong> File Excel phải có định dạng .xls với cột C là seri công tơ và cột E là chỉ số mới. Dữ liệu bắt đầu từ dòng 3.
                    </p>
                </div>
            </div>
        </div>
        <div class="card-body">
            <div class="form-group row">
                <label class="col-sm-2 col-form-label">Chọn kỳ import:</label>
                <div class="col-sm-4">
                    <asp:DropDownList runat="server" ID="drpKy" DataValueField="id" DataTextField="ky" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-sm-2 col-form-label">Chọn file Excel:</label>
                <div class="col-sm-6">
                    <asp:FileUpload ID="fileUpload" runat="server" CssClass="form-control-file" accept=".xls" />
                </div>
            </div>
            <div class="form-group row">
                <div class="col-sm-12">
                    <asp:Button ID="btnImport" runat="server" Text="Import dữ liệu" CssClass="btn btn-primary btn-lg" OnClick="btnImport_Click" />
                </div>
            </div>
        </div>
    </div>

    <asp:Panel ID="pnlResults" runat="server" Visible="false" CssClass="card mb-3">
        <div class="card-header bg-success text-white">
            <h4>Kết quả Import</h4>
        </div>
        <div class="card-body">
            <div class="alert alert-info">
                <strong>Tổng số dòng xử lý:</strong> <asp:Label ID="lblTotalRows" runat="server"></asp:Label><br />
                <strong>Số bản ghi thành công:</strong> <asp:Label ID="lblSuccessCount" runat="server"></asp:Label><br />
                <strong>Số bản ghi lỗi:</strong> <asp:Label ID="lblErrorCount" runat="server"></asp:Label>
            </div>
            
            <asp:Panel ID="pnlErrors" runat="server" Visible="false" CssClass="mt-3">
                <h5 class="text-danger">Danh sách lỗi:</h5>
                <div class="table-responsive">
                    <asp:GridView ID="gvErrors" runat="server" CssClass="table table-striped table-bordered" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="RowNumber" HeaderText="Dòng" />
                            <asp:BoundField DataField="MeterSerial" HeaderText="Seri công tơ" />
                            <asp:BoundField DataField="Reading" HeaderText="Chỉ số" />
                            <asp:BoundField DataField="ErrorMessage" HeaderText="Lỗi" />
                        </Columns>
                    </asp:GridView>
                </div>
            </asp:Panel>
        </div>
    </asp:Panel>
</asp:Content>

