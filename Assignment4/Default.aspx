<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="Landing" class="text-center">
    <asp:Image ID="BrandLogo" runat="server" 
           ImageUrl="Asset/Brandlogo.png" ImageAlign="Middle"/>
    <asp:Repeater ID="ModelRepeater" runat="server">
        <ItemTemplate>


    <div class="jumbotron" id="jumbo">
        <h1><%#Eval("name") %></h1>
        <h1><asp:Image ID="firstimage" runat="server" Height="200px" Width="250px" ImageUrl='<%# Eval("imageUrl") %>' /></h1>
        <p class="lead"><asp:HyperLink runat="server" NavigateUrl='<%#String.Format("~/ModelPage.aspx?name={0}&faction={1}",Eval("name"),Eval("faction")) %>'>
                            <asp:Label ID="firstname" runat="server" Width="240px" Height="35px" BackColor="Red">Detail</asp:Label> </asp:HyperLink></p>
        
    </div>
 </ItemTemplate>   
         </asp:Repeater>
   
    
       </div> 
                         
                                                      
                
</asp:Content>
