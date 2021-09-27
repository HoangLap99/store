<%@ Page Title=" Giỏ Hàng" Language="C#" MasterPageFile="~/marterpage/client.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="quanlycuahang.client.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h3 style="margin:50px 50px 0px 50px; text-align:center;width:100%">Giỏ Hàng</h3>
     <p style="text-align:center; width:100%"><asp:Label ID="lblThongBao" runat="server"></asp:Label></p>
    <br />
    <p style="text-align:center"><asp:Image ID="nocart" runat="server" ImageUrl="~/images/nocart.jpg" Width="100px"/></p>
    <br />
    <div style="margin:20px 50px 50px 50px">
       
        <asp:DataList ID="dlGioHang" runat="server" Width="100%">
        <ItemTemplate>
            <table>
                <tr>
                    <td>    <a href='<%# "Xemsanpham?num="+ Eval("proID.proID") %>'>
                            <asp:Image ID="anh" runat="server" ImageUrl='<%# "~/images/" + Eval("proID.proPhoto") %>' AlternateText="Ảnh sản phẩm" Width="100px" /></a>
                    </td>
                    <td style="width: 600px;">
                        <a href='<%# "Xemsanpham?num="+ Eval("proID.proID") %>'><%# Eval("proID.proName") %></a><br />
                            <asp:Label ID="lblDonGiaX" Text='<%# "Giá Tiền :"+Eval("ordtsThanhTien")+"VND" %>' runat="server"></asp:Label><br />
                        <asp:Label ID="lblSoLuongX" Text='<%# "Số lượng:"+Eval("ordtsQuantity") %>' runat="server"></asp:Label>
                        
                    </td>
                    <td>
                        <asp:ImageButton ID="btnXoa" ImageUrl="~/images/del.png" runat="server" Width="80" 
                            CommandArgument='<%#Eval("proID.proID") %>' CommandName="Xoa" OnCommand="btnXoa_Command" 
                            OnClientClick="return confirm('Bạn có chắc muốn xóa sản phẩm khỏi giỏ hàng?');" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
     </div>
    </div>
      <div style="width:60%; margin:150px auto auto 100px">
      <table style="width:100%; margin-left:30px;">
          <tr>
              <td>
                  <asp:Label runat="server" Text="Họ Và Tên : "></asp:Label>
              </td>
              <td>
                  <asp:TextBox runat="server" ID="txthoten"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="auto-style1">
                  <asp:Label runat="server" Text="Số Điện Thoại :"></asp:Label>
              </td>
              <td class="auto-style1">
                  <asp:TextBox runat="server" ID="txtSDT"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label runat="server" Text="Email :"></asp:Label>
              </td>
              <td>
                  <asp:TextBox runat="server" ID="txtemail"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label runat="server" Text="Địa chỉ :"></asp:Label>
              </td>
              <td>
                  <asp:TextBox runat="server" ID="txtdiachi"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="auto-style2">
                  <asp:label runat="server" Text="Chú Thích :"></asp:label>
                  
              </td>
              <td class="auto-style2">
                  <asp:TextBox runat="server" ID="size"></asp:TextBox>
              </td>
          </tr>
      </table>
  </div>
        <div style="text-align: center">
        <asp:ImageButton ID="btnDatMua" ImageUrl="~/images/buy.png" 
             OnClick="mua_click" runat="server" Height="80" />
    </div>
</asp:Content>
