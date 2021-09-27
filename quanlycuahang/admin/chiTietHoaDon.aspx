<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/Sever.Master" AutoEventWireup="true" CodeBehind="chiTietHoaDon.aspx.cs" Inherits="quanlycuahang.admin.chiTietHoaDon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="margin:50px auto auto auto; text-align:center;width:80%">CHI TIẾT ĐƠN HÀNG</h2>
    <div style="width:80%; margin:20px auto auto auto; display:flex">
        
        <table style="width:60%;">
            <tr>
                <td> <asp:Label ID="Label5" runat="server" Text="Họ Tên: "></asp:Label></td>
                <td>  <asp:TextBox ID="txtten" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> <asp:Label ID="Label1" runat="server" Text="Số Điện Thoại"></asp:Label></td>
                <td>  <asp:TextBox ID="Txtsdt" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Size"></asp:Label></td>
                <td><asp:TextBox ID="txtsize" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Ngày tạo"></asp:Label> </td>
                <td><asp:TextBox ID="txttime" runat="server"></asp:TextBox>  </td>
            </tr>
             <tr>
                <td> <asp:Label ID="Label4" runat="server" Text="Trạng thái"></asp:Label></td>
                <td><asp:TextBox ID="txttrangthai" runat="server"></asp:TextBox></td>
            </tr>
              
            
            

        </table>
        <div style="width:40%">
            <asp:GridView ID="gvchitietdonhang" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="orderID" HeaderText="Mã đơn hàng" />
                    <asp:BoundField DataField="proIdd" HeaderText="Mã sản phẩm" />
                    <asp:BoundField DataField="ordtsQuantity" HeaderText="Số lượng" />
                    <asp:BoundField DataField="ordtsThanhTien" HeaderText="Thành tiền" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource143" runat="server" ConnectionString="<%$ ConnectionStrings:DataShopConnectionString %>" SelectCommand="SELECT [proID], [ordtsQuantity], [ordtsThanhTien] FROM [OrderDetails]"></asp:SqlDataSource>
        </div>

    </div>
</asp:Content>
