<%@ Page Title="Giày Thể Thao" Language="C#" MasterPageFile="~/marterpage/client.Master" AutoEventWireup="true" CodeBehind="giaythethao.aspx.cs" Inherits="quanlycuahang.client.giaythethao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href="../style/style.css" />
	<style>
     tr,td{
		 width:250px;
		
     }
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <slider>
		<div class="container-slider owl-carousel" id="slider-top">
			<div class="slide-item">
				<img src="../images/banner.jpg" />
				<h2>
					<span>The best</span>
					<small>Welcome</small>
				</h2>
			</div>
			</div>
		</slider>
     <div style="margin:40px 50px 50px 50px"> 
         <p style="text-transform:uppercase; font-weight:600; margin-bottom:40px; height:50px;width:150px;text-align:center ;background-color:red;line-height:50px">
             Giày Thể Thảo </p>
         <asp:DataList ID="DataList1" runat="server" DataKeyField="proID" DataSourceID="SqlDataSource1" RepeatColumns="5" RepeatDirection="Horizontal">
             <ItemTemplate>
                 <asp:Image ID="anh" runat="server" ImageUrl='<%# "~/images/"+ Eval("proPhoto") %>' Width="200px" Height="250px" />
               <br />
                <h4><asp:Label ID="proNameLabel" runat="server" Text='<%# Eval("proName") %>' /></h4>
                 Mã : 
                 <asp:Label ID="proIDLabel" runat="server" Text='<%# Eval("proID") %>' />
                 <br />
                 Giá : 
                 <asp:Label ID="proPriceLabel" runat="server" Text='<%# Eval("proPrice") %>' /> VND
                 <br />
                 Giảm Giá: 
                 <asp:Label ID="proDiscountLabel" runat="server" Text='<%# Eval("proDiscount") %>' />%
                 <br />
                 <asp:Button ID="xem" CommandName="xem" CommandArgument='<%#Bind("proID")%>' 
                        Text="Xem Chi Tiết" OnCommand="Xem_click" runat="server"  />
<br />
             </ItemTemplate>
         </asp:DataList>
		 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataShopConnectionString %>" SelectCommand="SELECT [proID], [proName], [proPrice], [proDiscount], [proPhoto] FROM [Products] WHERE ([typeID] = @typeID)">
             <SelectParameters>
                 <asp:ControlParameter ControlID="DataList1" DefaultValue="6" Name="typeID" PropertyName="SelectedValue" Type="Int32" />
             </SelectParameters>
         </asp:SqlDataSource>
		 </div>
</asp:Content>
