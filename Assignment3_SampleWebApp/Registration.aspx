<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registration.aspx.cs"  Inherits="Assignment3_SampleWebApp.Registration" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--<!DOCTYPE html>--%>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>
<%--<head runat="server">
    <title>Registration Page</title>
</head>--%>
<%--<body>--%>
    <%--<form id="form1" runat="server">
    <div>--%>
    <h3>Registration Form</h3>
  <%--  </div>--%>
        
        <table style="width: 50%; height: 541px;">
            <tr>
                <td>ID:</td>
                <td><asp:TextBox ID="id" runat="server"></asp:TextBox></td>
               <td><asp:RequiredFieldValidator ID="IdValidator" 
                    ControlToValidate="id"
                    runat="server" 
                    ErrorMessage="Id should be unique and cant be left blank"
                    SetFocusOnError="True"></asp:RequiredFieldValidator></td> 
            </tr>
           
             <tr>
                <td>First Name:</td>
                <td><asp:TextBox ID="fname" runat="server"></asp:TextBox></td>
                 <td><asp:RequiredFieldValidator ID="fnameValidator" 
                     runat="server"
                     ControlToValidate="fname" 
                     ErrorMessage="FirstName Can't be Empty"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td><asp:TextBox ID="lname" runat="server"></asp:TextBox></td>
                 <td><asp:RequiredFieldValidator ID="lnameValidator" 
                     runat="server"
                     ControlToValidate="lname" 
                     ErrorMessage="LastName Can't be Empty"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="email" runat="server"></asp:TextBox>                     
                </td>
                 <td><asp:RequiredFieldValidator ID="emailValid" 
                     runat="server"
                     ControlToValidate="email" 
                     ErrorMessage="Email Can't be Empty"></asp:RequiredFieldValidator></td>
                <td><asp:RegularExpressionValidator ID="emailValidator" 
                    runat="server" 
                    ControlToValidate="email"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator></td>
               
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox> </td>
                 <td><asp:RequiredFieldValidator ID="passwordValidator" 
                     runat="server"
                     ControlToValidate="password1" 
                     ErrorMessage="Password cant be empty"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Confirm Password:</td>                
                <td><asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox> </td>
                <td><asp:CompareValidator ID="confirmPasswordValidator" 
                    runat="server"
                    ControlToCompare ="password2"
                    ControlToValidate="password1"
                    Operator="Equal"
                    ErrorMessage="Password's doesn't match"></asp:CompareValidator></td>
            </tr>          
            <tr>
                <td>Phone Number:</td>
                <td><asp:TextBox ID="phonenumber" runat="server"></asp:TextBox> </td>
                <td><asp:CustomValidator ID="PhoneNumberCustomerValidator" 
                    runat="server"
                    ControlToValidate="phonenumber"
                    onservervalidate ="PhoneNumberCustomerValidator_ServerValidate"                     
                    ErrorMessage="Phone Number must be 10 characters long" ValidateEmptyText="True"></asp:CustomValidator></td>

            </tr>
            <tr>
                <td>Date:</td>
                <td><asp:TextBox ID="date" runat="server" TextMode="DateTime"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" Width="63px" />&nbsp &nbsp &nbsp &nbsp&nbsp;<input id="Reset1" style="width: 65px; height: 27px" type="reset" value="Reset" /></td>
            </tr>
        </table> 
        <br />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>--%>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        
        
    
    
    
  <%--  </form>--%>
<%--</body>
</html>--%>
    </asp:Content>