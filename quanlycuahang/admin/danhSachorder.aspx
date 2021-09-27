<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/Sever.Master" AutoEventWireup="true" CodeBehind="danhSachorder.aspx.cs" Inherits="quanlycuahang.admin.danhSachorder" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:80%; margin:50px auto auto auto">
        <h3 style="text-align:center" >Danh Sách Hóa Đơn</h3>
        <div style="width:100%; margin:20px auto auto 200px">
            <asp:GridView ID="grv" runat="server" Width="590px" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="orderID" HeaderText="Mã hóa đơn" />
                    <asp:BoundField DataField="cusPhone" HeaderText="Số điện thoại" />
                    <asp:BoundField DataField="orderMessage" HeaderText="size" />
                    <asp:BoundField DataField="orderDateTime" HeaderText="Ngày Tạo" />
                    <asp:BoundField DataField="orderStatus" HeaderText="Trạn Thái" />
                <asp:TemplateField HeaderText="Chi tiết hóa đơn">
                <ItemTemplate>
                    <asp:Button ID="sua" CommandName="sua" CommandArgument='<%#Bind("orderID")%>' 
                        Text="Chi tiết hóa đơn" OnCommand="Sua_click" runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
