<%@ Page Title="Xem Sản Phẩm" Language="C#" MasterPageFile="~/marterpage/client.Master" AutoEventWireup="true" CodeBehind="Xemsanpham.aspx.cs" Inherits="quanlycuahang.client.Xemsanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="width:60%; margin:auto; margin-top:100px">
        <Table ID="xemsp"  style=" height:252px">
            <tr>
                <td RowSpan="6">
                     <asp:Image ID="Image1" runat="server" Height="250px" Width="200px" />
                </td>
                <td>
                    <h2 style="margin-left:50px"><asp:Label ID="lbten" runat="server" Text=""></asp:Label></h2>
                </td>
            </tr>
            <tr>
                <td>
                    <p style="margin-left:50px">
                    <asp:Label ID="Label1" runat="server" Text="Mã : "></asp:Label>
                    <asp:Label ID="lbma" runat="server" Text=""></asp:Label>
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <p  style="margin-left:50px">
                        <asp:Label ID="lbgia" runat="server" BackColor="#66FFFF" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label> VND
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <p style="margin-left:50px">  
                    <asp:Label ID="Label3" runat="server" Text="Size : "></asp:Label>
                    <asp:Label ID="lbsize" runat="server" Text=""></asp:Label>
                    </p>
                </td>
            </tr>
            <tr>
                <td>
                    <p style="margin-left:50px"> 
                      <asp:ImageButton ID="btgiohang" runat="server" ImageUrl="~/images/add_cart.png" OnClick="GioHang_click" />
        
                  </p>
                </td>
            </tr>
        </Table>
        
      <div style="margin-top:50px"> <asp:Label ID="Label2" runat="server" Text="Mô Tả : "></asp:Label>
        <asp:Label ID="lbmota" runat="server" Text=""></asp:Label>
         </div>
   </div>
</asp:Content>
