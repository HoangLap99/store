<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/Sever.Master" AutoEventWireup="true" CodeBehind="DanhSachCus.aspx.cs" Inherits="quanlycuahang.admin.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2 style="margin:40px 50px 40px 400px">Danh Sách Tất Cả Khách Hàng</h2>
    <div style="margin:10px 50px 40px 400px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cusPhone" DataSourceID="SqlDataSource14">
            <Columns>
                <asp:BoundField DataField="cusPhone" HeaderText="cusPhone" ReadOnly="True" SortExpression="cusPhone" />
                <asp:BoundField DataField="cusFullName" HeaderText="cusFullName" SortExpression="cusFullName" />
                <asp:BoundField DataField="cusEmail" HeaderText="cusEmail" SortExpression="cusEmail" />
                <asp:BoundField DataField="cusAddress" HeaderText="cusAddress" SortExpression="cusAddress" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource14" runat="server" ConnectionString="<%$ ConnectionStrings:DataShopConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
    </div>
</asp:Content>
