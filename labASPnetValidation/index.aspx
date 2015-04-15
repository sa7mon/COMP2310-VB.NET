<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please enter a name" ForeColor="Red">Error</asp:RequiredFieldValidator>
            </td>
        </tr> 
        <tr>
            <td class="auto-style1">Age</td>
            <td class="auto-style1"><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
            <td class="auto-style1">
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Age must be between 1 and 110" ForeColor="Red" MaximumValue="110" MinimumValue="1" Type="Integer">Error</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>SSN: </td>
            <td><asp:TextBox ID="txtSSN" runat="server"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtSSN" ErrorMessage="Format like this: 111-11-1111" ForeColor="Red" ValidationExpression="\d{3}-\d{2}-\d{4}">Error</asp:RegularExpressionValidator>
            </td>
        </tr>
          <tr>
            <td># of children: </td>
            <td><asp:TextBox ID="txtChildren" runat="server"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtChildren" ErrorMessage="# of children must be &gt;= 0" ForeColor="Red" Operator="GreaterThanEqual" ValueToCompare="0">Error</asp:CompareValidator>
              </td>
        </tr>
        <tr>
            <td><span style="color:red;">* Required</span></td>
            <td><asp:Button ID="Button1" runat="server" Text="Validate" /></td>
            <td>&nbsp;</td>
        </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
