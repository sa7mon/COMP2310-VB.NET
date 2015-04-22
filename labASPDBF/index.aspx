<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="ID" ReadOnly="True" DataField="ID" />
                <asp:BoundField HeaderText="User ID" DataField="userID" />
                <asp:BoundField HeaderText="User Name" DataField="userName" />
                <asp:BoundField HeaderText="Email" DataField="email" />
                <asp:BoundField HeaderText="Password" DataField="password" />
                <asp:BoundField HeaderText="Phone" DataField="phone" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:DropDownList ID="lstPhone" runat="server">
        </asp:DropDownList>

    </div>
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="UserID"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Phone"></asp:Label>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Button ID="btnSave" runat="server" Text="Save to Database" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
