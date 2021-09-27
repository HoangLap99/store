<%@ Page Title="" Language="C#" MasterPageFile="~/marterpage/client.Master" AutoEventWireup="true" CodeBehind="trangchu.aspx.cs" Inherits="quanlycuahang.client.trangchu" EnableEventValidation="false" %>
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

   <div style="margin:40px 50px 50px 50px"> <p style="text-transform:uppercase; font-weight:600; margin-bottom:40px; height:50px;width:150px;text-align:center ;background-color:red;line-height:50px">sản phẩm</p> 
	   <asp:DataList ID="DataList1" runat="server"  RepeatColumns="5" RepeatDirection="Horizontal">
           <ItemTemplate>
			   <asp:Image ID="anh" runat="server" ImageUrl='<%# "~/images/"+ Eval("proPhoto") %>' Width="200px" Height="250px" />
               <br />
               <h4><asp:Label ID="proNameLabel" runat="server" Text='<%# Eval("proName") %>' /></h4>
               <br />
               mã:
               <asp:Label ID="proIDLabel" runat="server" Text='<%# Eval("proID") %>' />
               <br />
               Giá:
               <asp:Label ID="proPriceLabel" runat="server" Text='<%# Eval("proPrice") %>' />
               <br />
			    <asp:Button ID="xem" CommandName="xem" CommandArgument='<%#Bind("proID")%>' 
                        Text="Xem Chi Tiết" OnCommand="Xem_click" runat="server"  />
			   <br />
			   <br />
           </ItemTemplate>
       </asp:DataList>
	   </div>
	<shipping>
		<div class="container">
			<ul>
				<li>
					<img src="../images/a.png" />
					<h3>Special offers</h3>
					<p>Shop Big Save Big</p>
				</li>
				<li>
					<img src="../images/a1.png" />
					<h3>Free delivery</h3>
					<p>On Orders Above $99</p>
				</li>
				<li>
					<img src="../images/a3.png" />
					<h3>30 Days Return</h3>
					<p>Policy We Offers</p>
				</li>
				<li>
					<img src="../images/a4.png" />
					<h3>Fastest Shipping</h3>
					<p>2 Days Express</p>
				</li>
			</ul>
		</div>
	</shipping>
		<promotion>
		<div class="container">
			<ul>
				<li>
					<img src="../images/sale1.png" />
				</li>
				<li class="active">
					<img src="../images/sale2.png" />
				</li>
				<li>
					<img src="../images/sale3.png" />
				</li>
			</ul>
		</div>
	</promotion>
	   <div style="margin:40px 50px 50px 50px"> 
		<p style="text-transform:uppercase; font-weight:600; margin-bottom:40px; height:50px;width:150px;text-align:center ;
         background-color:red;line-height:50px">Sale</p> 
           <asp:DataList ID="DataList2" runat="server" DataKeyField="proID" DataSourceID="SqlDataSource2" RepeatColumns="5" RepeatDirection="Horizontal">
               <ItemTemplate>
				   <asp:Image ID="anh" runat="server" ImageUrl='<%# "~/images/"+ Eval("proPhoto") %>' Width="200px" Height="250px" />
               <br />
                   <asp:Label ID="proNameLabel" runat="server" Text='<%# Eval("proName") %>' />
                   <br />
                   <asp:Label ID="proIDLabel" runat="server" Text='<%# Eval("proID") %>' />
                   <br />
                   Giá:
                   <asp:Label ID="proPriceLabel" runat="server" Text='<%# Eval("proPrice") %>' />
                   <br />
                   Giảm Giá:
                   <asp:Label ID="proDiscountLabel" runat="server" Text='<%# Eval("proDiscount") %>' />%
                   <br />
				     <asp:Button ID="xem" CommandName="xem" CommandArgument='<%#Bind("proID")%>' 
                        Text="Xem Chi Tiết" OnCommand="Xem_click" runat="server"/>
               </ItemTemplate>
           </asp:DataList>
           <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DataShopConnectionString %>" SelectCommand="SELECT [proID], [proName], [proPrice], [proDiscount], [proPhoto] FROM [Products] WHERE ([proDiscount] &gt; @proDiscount)">
               <SelectParameters>
                   <asp:ControlParameter ControlID="DataList2" DefaultValue="0" Name="proDiscount" PropertyName="SelectedValue" Type="Int32" />
               </SelectParameters>
           </asp:SqlDataSource>
       </div>


</asp:Content>
