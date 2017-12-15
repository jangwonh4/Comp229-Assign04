<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModelPage.aspx.cs" Inherits="Assignment4.ModelPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                       
   <link rel="stylesheet" type="text/css" href="Content/PageCss.css"/>
        <table class="nav-justified" id="tab">
            <tr>
                <td colspan="2" class="text-center">
                                 <asp:Image ID="ImageGame" runat="server" CssClass="img-thumbnail" Height="294px" Width="344px" />
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                                 <strong>
                                     Name:
                                 </strong> 
                            </td>
                <td>
                                <asp:TextBox ID="txtName" runat="server" CssClass="table" Width="150px" Enabled="false"/>

                                </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Faction: 
                                </strong>
                            </td>
                <td>
                                <asp:TextBox ID="txtFaction" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                                </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Rank: 
                                </strong>
                            </td>
                <td>
                                <asp:TextBox ID="txtRank" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                                </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Base:
                                </strong>
                            </td>
                <td>
                                <asp:TextBox ID="txtBase" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Size:
                                </strong>
                            </td>
                <td>
                                <asp:TextBox ID="txtSize" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Deployment Zone:
                                </strong>
                            </td>
                <td>
                                <asp:TextBox ID="txtDeploymentZone" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Traits :
                                </strong> 
                            </td>
                <td>
                               <asp:Repeater runat="server" ID="traits">
                                <ItemTemplate>                              
                                    <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>" />
                                </ItemTemplate>
                               </asp:Repeater>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                                <strong>
                                    Types : 
                                </strong>
                            </td>
                <td>
                               <asp:Repeater runat="server" ID="types">
                                <ItemTemplate>                              
                                    <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>"  />
                                </ItemTemplate>
                               </asp:Repeater>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                                        <strong>
                                            Defense Chart : 
                                        </strong>
                                    </td>
                <td>
                            
                                       <asp:Repeater runat="server" ID="defense">
                                        <ItemTemplate>       
                                               
                                             <tr>
                                                <td>                  
                                            <td>  
                                                                         
                                            <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>"/>
                                                </tr>
                                             </td>
                                            </td> 
                                        
                                        </ItemTemplate>
                                       </asp:Repeater>
                        

                        </td>
            </tr>
            <tr>
                            <td class="text-right">
                                <strong>
                                    Mobility : 
                                 </strong>
                            </td>
                            <td>
                                <asp:TextBox ID="txtMobility" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
                        </tr>
            <tr>
                            <td class="text-right">
                                <strong>
                                    Willpower :
                                </strong>
                            </td>
                            <td>
                                <asp:TextBox ID="txtWillpower" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
                        </tr>
            <tr>
                            <td class="text-right">
                                <strong>
                                    Resiliance :
                                </strong>
                            </td>
                            <td>
                                <asp:TextBox ID="txtResiliance" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
                        </tr>
            <tr>
                            <td class="text-right">
                                <strong>
                                    Wounds :
                                </strong>
                            </td>
                            <td>
                                <asp:TextBox ID="txtWounds" runat="server" CssClass="table" Width="150px" Enabled="false"/>
                            </td>
                        </tr>
            <tr>
                            <td class="text-right">
                                <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update" />
                                <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Save" ValidationGroup="Update" Visible="false" />
                            </td>
                            <td>
    

    
    <asp:Repeater runat="server" ID="action">
                <ItemTemplate>         
    <table>
        
                      
              
                <tr>
                    <td>
                        <strong>
                            Name : 
                        </strong>
                    </td>
                    <td>                           
                        <asp:Label runat="server" Text='<%# Eval("name") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>
                            Type : 
                        </strong>
                    </td>
                    <td>                           
                        <asp:Label runat="server" Text='<%# Eval("type") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>
                            Rating : 
                        </strong>
                    </td>
                    <td>                           
                        <asp:Label runat="server" Text='<%# Eval("rating") %>' />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <strong>
                            Range : 
                        </strong>
                    </td>
                    <td>                           
                        <asp:Label runat="server" Text='<%# Eval("range") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>
                            Description: 
                        </strong>
                    </td>
                    <td colspan="7">
                        <asp:Label runat="server" Text='<%# Eval("description") %>' />
                    </td>
                </tr>
                    <td>
                    </td>
                    <td></td>
                    
                                           
        </table>
          </ItemTemplate>
            </asp:Repeater>  
                            </td>
                        </tr>
            </table>
    

    
    

    

</asp:Content>
