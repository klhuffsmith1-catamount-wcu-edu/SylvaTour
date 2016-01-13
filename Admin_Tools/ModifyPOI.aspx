<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Tools/Master.master" AutoEventWireup="true" CodeFile="ModifyPOI.aspx.cs" Inherits="UpdatePOI" Debug="false" Trace="false" ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 18px;
        }
        .style2
        {
            width: 160px;
        }
        .style3
        {
            width: 207px;
        }
        .style4
        {
            width: 252px;
        }
        .style7
        {
            width: 63px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="toolbar-box">
        <div class="t">
            <div class="t">
                <div class="t">
                </div>
            </div>
        </div>
        <div class="m">
            <div class="toolbar" id="toolbar">
                <table class="toolbar">
                    <tr>
                        <td class="button" id="toolbar-save">
                            <asp:LinkButton ID="lbUpdate" runat="server" onclick="butUpdate_Click" 
                                ForeColor="#0B55C4">
                                <span class="icon-32-save" title="Save"></span>
                                Save
                            </asp:LinkButton>
                        </td>
                        <td class="button" id="toolbar-cancel">
                            <a href="POIs.aspx">
                                <span class="icon-32-cancel" title="Close"></span>
                                Close
                            </a>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="header icon-48-article">
                Point of Interest: [edit]
            </div>
            <div class="clr"></div>
        </div>
        <div class="b">
            <div class="b">
                <div class="b">
                </div>
            </div>
        </div>
    </div>
    <div id="element-box">
        <div class="t">
            <div class="t">
                <div class="t">
                </div>
            </div>
        </div>
        <div class="m">
            <center><b><asp:Label ID="lblDisplay" runat="server" /></b></center>
            <table cellpadding="0" cellspacing="0" border="0" width="50%">
                <tr>
                    <td colspan="2">
                        <table class="admintable">
                            <tr>
                                <td width="20%" class="key">
                                    ID
                                </td>
                                <td>
                                    <asp:Label ID="lblID" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Title
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTitle" runat="server" Width="250px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Category
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlCategory" runat="server" Width="150px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Latitude
                                </td>
                                <td>
                                    <asp:TextBox ID="txtLatitude" runat="server" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Longitude
                                </td>
                                <td>
                                    <asp:TextBox ID="txtLongitude" runat="server" Width="150px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Website URL
                                </td>
                                <td>
                                    <asp:TextBox ID="txtURL" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Contact Name
                                </td>
                                <td>
                                    <asp:TextBox ID="txtContactName" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Phone Number
                                </td>
                                <td>
                                    <asp:TextBox ID="txtPhone" runat="server" Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Address1
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAddress1" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Address2
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAddress2" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    City
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCity" runat="server" Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    State
                                </td>
                                <td>
                                    <asp:TextBox ID="txtState" runat="server" Width="100px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    ZipCode
                                </td>
                                <td>
                                    <asp:TextBox ID="txtZipCode" runat="server" Width="100px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" 
                                        ControlToValidate="txtZipCode" ErrorMessage="* Please Enter a Zip Code"></asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="rvZipCode" runat="server" ControlToValidate="txtZipCode" 
                                        ErrorMessage="* Please Enter a Valid Zip Code" MaximumValue="99999" 
                                        MinimumValue="00001"></asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Is Active?</td>
                                <td>
                                    <asp:CheckBox ID="chkIsActive" runat="server" 
                                        Text="Check if you would like this location to be active and appear on the application" />
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Pet&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Friendly?</td>
                                <td>
                                    <asp:CheckBox ID="chkPetFriendly" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Description
                                </td>
                                <td>
                                    <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="118px" Width="513px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Image 1
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="style1"><asp:Image ID="imgImage1" runat="server" Height="100px" Width="100px" /></td>
                                            <td class="style7"></td>
                                            <td class="style2" class="key">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Image 2
                                </td>
                                <td>
                                <table>
                                    <tr>
                                        <td class="style1"><asp:Image ID="imgImage2" runat="server" Height="100px" Width="100px"/></td>
                                        <td class="style7">&nbsp;</td>
                                        <td class="style3">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Image 3
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="style1"><asp:Image ID="imgImage3" runat="server" Height="100px" Width="100px" /></td>
                                            <td class="style7"><asp:HyperLink ID="hypImage2" runat="server"></asp:HyperLink></td>
                                            <td class="style4">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                             <tr>
                                <td width="20%" class="key">
                                    Image 4 
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="style1"><asp:Image ID="imgImage4" runat="server" Height="100px" 
                                                    Width="100px" /></td>
                                            <td class="style7"></td>
                                            <td class="style2" class="key">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Image 5
                                </td>
                                <td>
                                <table>
                                    <tr>
                                        <td class="style1"><asp:Image ID="imgImage5" runat="server" Height="100px" 
                                                Width="100px"/></td>
                                        <td class="style7">&nbsp;</td>
                                        <td class="style3">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="20%" class="key">
                                    Image 6
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td class="style1"><asp:Image ID="imgImage6" runat="server" Height="100px" 
                                                    Width="100px" /></td>
                                            <td class="style7"></td>
                                            <td class="style4">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
       </div>
       <div class="b">
            <div class="b">
                <div class="b">
                </div>
            </div>
        </div>
    </div>
</asp:Content>

