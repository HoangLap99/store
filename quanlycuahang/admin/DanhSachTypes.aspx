<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/Sever.Master" AutoEventWireup="true" CodeBehind="DanhSachTypes.aspx.cs" Inherits="quanlycuahang.admin.DanhSachTypes" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:80%; margin:50px auto auto auto">
          <table>
              <tr>
                  <td  style="text-align:center" colspan="2">
                      <h3> Thêm Mới Loại Sản Phẩm </h3>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Mã Loại Danh Mục"></asp:Label>
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
                      <asp:DropDownList runat="server" ID="ddl"></asp:DropDownList>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Tên Loại Danh Mục"></asp:Label>
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
        <h3 style="text-align:center" >Danh Sách ProductTypes</h3>
        <div style="width:100%; margin:20px auto auto 200px">
            <asp:GridView ID="grv" runat="server" Width="590px" AutoGenerateColumns="false">
                <Columns>
                 <asp:BoundField DataField="typeID" HeaderText="Mã loại sản phẩm" /> 
                    <asp:BoundField DataField="cateID" HeaderText="Mã Danh Mục" />
                    <asp:BoundField DataField="typeName" HeaderText="Tên loại sản phẩm" />
                     <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button ID="xoa" CommandName="xoa" CommandArgument='<%#Bind("typeID")%>' 
                        Text="Xóa" OnCommand="Xoa_click" runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button ID="sua" CommandName="sua" CommandArgument='<%#Bind("typeID")%>' 
                        Text="Sửa" OnCommand="Sua_click" runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
     </div>
</asp:Content>
