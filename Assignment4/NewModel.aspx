<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewModel.aspx.cs" Inherits="Assignment4.NewModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified" id="tab" style="background-color: #66CCFF">
            <tr>
                <td colspan="2" class="text-center">
                                <br />
                    <h1> Make New model</h1>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lname" Text="Name:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" runat="server" ID="nameTextBox" CssClass="col-md-8 form-control" style="left: 0px; top: 0px" />
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lfaction" Text="Faction:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" runat="server" ID="factionTextBox" CssClass="col-md-8 form-control" style="left: 0px; top: 0px; width: 101%"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lrank" Text="Rank:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="rankTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lbase" Text="Base:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="BaseTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lsize" Text="Size:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="sizeTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lzone" Text="Deployment Zone:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" runat="server" ID="deploymentZoneTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lmobility" Text="Mobility:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="mobilityTextBox" CssClass="col-md-8 form-control" style="left: 0px; top: 0px"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server"  ID="lwillpower" Text="Will Power:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="willpowerTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lresiliance" Text="Resiliance:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="resilianceTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="lwounds" Text="Wounds:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" TextMode="Number" runat="server" ID="woundsTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
                <asp:Label runat="server" ID="limageurl" Text="Image URL:" CssClass="col-md-4 control-label " />
                            </td>
                <td>
    

    
                    <asp:TextBox Text="" runat="server" ID="imageurlTextBox" CssClass="col-md-8 form-control"/>
                            </td>
            </tr>
            <tr>
                <td class="text-right">
               

    
                <asp:Button runat="server" ID="button_submit" Text="Submit" OnClick="SaveButton_Click" CssClass="btn btn-default" />
                            </td>
                <td>
    

    
                <asp:Button runat="server" Text="Cancel" onClick="InsertButton_Click" ID="InsertButton" CausesValidation="False" CssClass="btn btn-default"/>
                            </td>
            </tr>
            </table>
            
  

</asp:Content>
