<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Display.aspx.cs" Inherits="Assignment3_SampleWebApp.Display" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--           </form>
</body>
</html>--%>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    <p>
            The below user is trying to Register for your Application. Please select your option:</p>
    <p>
            <table style="width: 100%; height: 255px;">
                <tr>
                    <td style="width: 188px">First Name</td>
                    <td>
                        <asp:Label ID="FNameDisplay" runat="server" Text="FirstNameDisplay"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 188px">Last Name</td>
                    <td>
                        <asp:Label ID="LNameDisplay" runat="server" Text="LastName"></asp:Label>
                        Display</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 188px">Email ID</td>
                    <td>
                        <asp:Label ID="EmailDisplay" runat="server" Text="EmailDisplay"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 188px">Password</td>
                   
                    <td>
                        <asp:Label ID="PasswordDisplay" runat="server" Text="PasswordDisplay"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 188px">Confirm Password</td>
                   
                    <td>
                        <asp:Label ID="CPasswordDisplay" runat="server" Text="CPasswordDisplay"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 188px">Phone Number</td>
                    <td>
                        <asp:Label ID="PhoneNumberLabel" runat="server" Text="PhoneNumberLabel"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
               
                
                
                
            </table>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Reject" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Label ID="ConfirmData" runat="server" Text="Label"></asp:Label>
    </p>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ASPNETWebFormAssignmentConnectionString %>" SelectCommand="SELECT * FROM [RegistrationForm2]"></asp:SqlDataSource>
        <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>--%>
        <br />
        
    </asp:content>
 <%--           </form>
</body>
</html>--%>
