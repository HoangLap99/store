<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="quanlycuahang.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:40%;margin:150px auto auto auto;height:300px; border:1px solid black">
      <table style="width:100%;height:100%">
          <tr>
              <td>
                  <asp:Label runat="server" Text="Số Điện Thoại : "></asp:Label>
              </td>
              <td>
                  <asp:TextBox runat="server" ID="txtusername"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td>
                  <asp:Label runat="server" Text="Mật khẩu : "></asp:Label>
              </td>
              <td>
                  <asp:TextBox runat="server" ID="txtpassword" TextMode="Password"></asp:TextBox>
              </td>
          </tr>
          <tr>
             <td style="text-align:center">
                  <asp:Button runat="server" ID="btndangnhap" Text="Đăng nhập" OnClick="btndangnhap_Click" />
              </td>
              <td style="text-align:center">
                  <asp:Button runat="server" ID="btndangki" Text="Đăng kí" PostBackUrl="~/Dangki.aspx" />
              </td>
          </tr>
      </table>
            </div>
    </form>
</body>
</html>
