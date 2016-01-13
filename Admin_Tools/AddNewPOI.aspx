<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Tools/Master.master" AutoEventWireup="true" CodeFile="AddNewPOI.aspx.cs" Inherits="AddNewPOI" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
                            <asp:LinkButton ID="lbUpdate" runat="server" onclick="butAdd_Click"
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
                Point of Interest: [create]
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
            <asp:Panel ID="pnlInput" runat="server"> 
                 <table cellpadding="0" cellspacing="0" border="0" style="width: 54%">
                        <tr>
                            <td colspan="2">
                                <table>
                                    <tr>
                                        <td class="style2">
                                            Category</td>
                                        <td>
                                            <asp:DropDownList ID="ddlCategory" runat="server" Width="125px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Latitude</td>
                                        <td>
                                            <asp:TextBox ID="txtLatitude" runat="server" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Longitude</td>
                                        <td>
                                            <asp:TextBox ID="txtLongitude" runat="server" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Location Title</td>
                                        <td>
                                            <asp:TextBox ID="txtTitle" runat="server" Width="300px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                                ControlToValidate="txtTitle" Display="Dynamic" ErrorMessage="* Enter a Title" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Description</td>
                                        <td>
                                            <asp:TextBox ID="txtDescription" runat="server" Width="300px" Height="105px" 
                                                TextMode="MultiLine"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvDescription" runat="server" 
                                                ControlToValidate="txtDescription" Display="Dynamic" 
                                                ErrorMessage="* Enter a Description" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                        <tr>
                                        <td class="style2">
                                            Address 1</td>
                                        <td>
                                            <asp:TextBox ID="txtAddress1" runat="server" Width="300px"></asp:TextBox>
                                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                ControlToValidate="txtAddress1" Display="Dynamic" ErrorMessage="* Enter a Address" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Address 2</td>
                                        <td>
                                            <asp:TextBox ID="txtAddress2" runat="server" Width="300px"></asp:TextBox>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            City</td>
                                        <td>
                                            <asp:TextBox ID="txtCity" runat="server" Width="300px"></asp:TextBox>
                                        <%--    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                ControlToValidate="txtCity" Display="Dynamic" ErrorMessage="* Enter a City" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            State</td>
                                        <td>
                                            <asp:TextBox ID="txtState" runat="server" Width="300px"></asp:TextBox>
                                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                ControlToValidate="txtState" Display="Dynamic" ErrorMessage="* Enter a State" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            ZipCode</td>
                                        <td>
                                            <asp:TextBox ID="txtZipCode" runat="server" Width="300px"></asp:TextBox>
                                  <%--          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                ControlToValidate="txtZipCode" Display="Dynamic" ErrorMessage="* Enter a ZipCode" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                            <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" 
                                                ControlToValidate="txtZipCode" ErrorMessage="* Please Enter a Zip Code"></asp:RequiredFieldValidator>
                                            &nbsp;<asp:RangeValidator ID="rvZipCode" runat="server" 
                                                ControlToValidate="txtZipCode" ErrorMessage="* Please Enter a Valid Zip Code" 
                                                MaximumValue="99999" MinimumValue="00001"></asp:RangeValidator>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Contact Name</td>
                                        <td>
                                            <asp:TextBox ID="txtContactName" runat="server" Width="300px"></asp:TextBox>
                                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                ControlToValidate="txtContactName" Display="Dynamic" ErrorMessage="* Enter a Contact Name" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Phone Number</td>
                                        <td>
                                            <asp:TextBox ID="txtPhone" runat="server" Width="300px"></asp:TextBox>
                                <%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                ControlToValidate="txtPhone" Display="Dynamic" ErrorMessage="* Enter a Phone Number" 
                                                SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Website URL</td>
                                        <td>
                                            <asp:TextBox ID="txtURL" runat="server" Width="300px"></asp:TextBox>
                                            </td>
                                    </tr>
                                        <tr>
                                            <td class="style2">
                                                Pet Friendly?</td>
                                            <td>
                                                <asp:CheckBox ID="chkPetFriendly" runat="server" />
                                            </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            Is Active?</td>
                                        <td>
                                            <asp:CheckBox ID="chkIsActive" runat="server" 
                                                Text=" Check if you would like this location to be active and appear on the application" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                        <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                                            <asp:Button ID="butAdd" runat="server" onclick="butAdd_Click" Text="Add" 
                                                Width="105px" />
                                            </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                 </asp:Panel>
                 <asp:Panel ID="pnlDisplay" runat="server">
                    <center>
                        <table>
                            <tr>
                                <td align="center">The new POI has been created, click below to add images.</td>
                            </tr>
                            <tr>
                                <td align="center"><asp:HyperLink ID="hypAddImagePage" runat="server">Add Images</asp:HyperLink></td>
                            </tr>
                        </table>
                     </center>
                 </asp:Panel>
        </div>
       <div class="b">
            <div class="b">
                <div class="b">
                </div>
            </div>
        </div>
    </div>
</asp:Content>

