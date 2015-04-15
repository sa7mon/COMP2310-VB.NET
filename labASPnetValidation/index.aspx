﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        td {
            text-align: right;
        }
        #Button1 {
            width: 100%;
        }
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
        <tr>
            <td>*Name</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            <td>        
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Please Enter a Name</asp:RequiredFieldValidator>
            </td>
        </tr> 
        <tr>
            <td class="auto-style1">Age</td>
            <td class="auto-style1"><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td>SSN: </td>
            <td><asp:TextBox ID="txtSSN" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td># of children: </td>
            <td><asp:TextBox ID="txtChildren" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td># of boys: </td>
            <td><asp:TextBox ID="txtBoys" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><span style="color:red;">* Required</span></td>
            <td><asp:Button ID="Button1" runat="server" Text="Validate" /></td>
            <td>&nbsp;</td>
        </tr>
        </table>
    </form>
</body>
</html>
