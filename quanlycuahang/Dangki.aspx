<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangki.aspx.cs" Inherits="quanlycuahang.Dangki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box}* {
	margin: 0px;
	padding: 0px;
	box-sizing: border-box;
}

button,input{overflow:visible}button,input,optgroup,select,textarea{margin:0;font-family:inherit;font-size:inherit;line-height:inherit}
        .auto-style1 {
            height: 36px;
        }
        .auto-style2 {
            width: 290px;
        }
        .auto-style3 {
            height: 36px;
            width: 290px;
        }
        .auto-style4 {
            margin-left: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 382px; width:60%;margin:100px auto auto auto; border:1px solid black">
            <h2 style="margin:20px auto auto auto; text-align:center">Đăng Kí tài khoản</h2>
            <table style="width:100%; height:90%; margin:auto">
                <tr>
                    <td style="text-align:center" class="auto-style2"><asp:Label ID="Label3" runat="server" Text="Họ Tên :"></asp:Label></td>
                    <td style="text-align:center"><asp:TextBox ID="Txthoten" runat="server" Width="170px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:center" class="auto-style2"><asp:Label ID="Label7" runat="server" Text="Số điện thoại :"></asp:Label></td>
                    <td style="text-align:center"><asp:TextBox ID="txtsdt" runat="server" Width="170px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:center" class="auto-style3"><asp:Label ID="Label8" runat="server" Text="Email :"></asp:Label></td>
                    <td style="text-align:center" class="auto-style1"><asp:TextBox ID="Txtemail" runat="server" Width="170px" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:center" class="auto-style2"><asp:Label ID="Label9" runat="server" Text="Địa chỉ :"></asp:Label></td>
                    <td style="text-align:center"><asp:TextBox ID="txtdiachi" runat="server" Width="170px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:center" class="auto-style2"> <asp:Label ID="Label10" runat="server" Text="Mật Khẩu :"></asp:Label></td>
                    <td style="text-align:center"> <asp:TextBox ID="Txtpass" runat="server" Width="170px" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:right" class="auto-style2">
                     <asp:Button ID="Button1" runat="server" Text="Đăng Nhập" PostBackUrl="~/DangNhap.aspx" CssClass="auto-style4" Height="30px" Width="150px" />
                    </td>
                    <td style="text-align:left">
                     &nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="Button2" runat="server" Text="Đăng Ký" OnClick="Button2_Click" Height="30px" Width="150px" />
                    </td>
                </tr>
            </table> 
        </div>
    </form>
</body>
</html>
