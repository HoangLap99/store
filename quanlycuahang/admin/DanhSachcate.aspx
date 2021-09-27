<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/Sever.Master" AutoEventWireup="true" CodeBehind="DanhSachcate.aspx.cs" Inherits="quanlycuahang.admin.DanhSachcate" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="width:80%; margin:50px auto auto auto">
          <table>
              <tr>
                  <td  style="text-align:center" colspan="2">
                      <h3> Thêm Mới Danh Mục </h3>
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
                  <td style="text-align:center" colspan="2">
                      <asp:Button ID="btnthem" runat="server" OnClick="btnthem_Click" Text="Thêm mới" Width="75px" />
                  </td>
              </tr>
              <tr>
                  <td style="text-align:center" colspan="2">
                      <asp:Label ID="msg" runat="server"></asp:Label>
                  </td>
              </tr>
          </table>
        <h3 style="text-align:center" >Danh Sách Categories</h3>
        <div style="width:100%; margin:20px auto auto 200px">
            <asp:GridView ID="grv" runat="server" Width="590px" AutoGenerateColumns="false">
                <Columns>
                 <asp:BoundField DataField="cateID" HeaderText="Mã Danh Mục" /> 
                    <asp:BoundField DataField="cateName" HeaderText="Tên Danh Mục" />
                     <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button ID="xoa" CommandName="xoa" CommandArgument='<%#Bind("cateID")%>' 
                        Text="Xóa" OnCommand="Xoa_click" runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button ID="sua" CommandName="sua" CommandArgument='<%#Bind("cateID")%>' 
                        Text="Sửa" OnCommand="Sua_click" runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
     </div>
</asp:Content>
