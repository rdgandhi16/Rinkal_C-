﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="validationcntrl.aspx.cs"
    Inherits="validationcntrl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" align="center" cellpadding="5">
            <tr>
                <td>
                    Fname:
                </td>
                <td>
                    <asp:TextBox ID="fname" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Firstname Is required" ControlToValidate="fname" Font-Bold="True" 
                        ForeColor="Red"></asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="pwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Confirm Password:
                </td>
                <td>
                    <asp:TextBox ID="cpwd" runat="server"></asp:TextBox>
              
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ErrorMessage="Password is Not Match" ControlToCompare="pwd" 
                        ControlToValidate="cpwd" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Invalid EMail ID" ControlToValidate="email" Font-Bold="True" 
                        ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                
                </td>
            </tr>
               <tr>
                <td>
                    Salary:
                </td>
                <td>
                    <asp:TextBox ID="sal" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ErrorMessage="Salary Between 5000 to 10000" ControlToValidate="sal" 
                        Font-Bold="True" ForeColor="Red" MaximumValue="10000" MinimumValue="5000" 
                        Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
               <tr>
                <td>
                    Mobile:
                </td>
                <td>
                    <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ErrorMessage="Mobile Must be  10 Digit" Font-Bold="True" ForeColor="Red" 
                        onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
               <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </div>
    </form>
</body>
</html>
