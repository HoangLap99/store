<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/Sever.Master" AutoEventWireup="true" CodeBehind="editcate.aspx.cs" Inherits="quanlycuahang.admin.editcate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table style="width:50%;height:400px;margin:auto">
              <tr>
                  <td  style="text-align:center" colspan="2">
                      <h3> Sửa Danh Mục </h3>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Mã danh mục"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtma"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Tên Danh Mục"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtten"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td style="text-align:center">
                      <asp:Button ID="btnthem" runat="server" OnClick="btnthem_Click" Text="Cập nhật" Width="75px" />
                  </td>
                  <td style="text-align:center">
                      <asp:Button ID="btnquaylai" runat="server" PostBackUrl="~/admin/DanhSachcate.aspx"  Text="Quay Lại" Width="75px" />
                  </td>
              </tr>
              <tr>
                  <td style="text-align:center" colspan="2">
                      <asp:Label ID="msg" runat="server"></asp:Label>
                  </td>
              </tr>
          </table>
</asp:Content>
