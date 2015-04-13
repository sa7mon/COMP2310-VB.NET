<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>What is your favorite ice cream?</h1>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="lstFlavor" runat="server">
            <asp:ListItem>Vanilla</asp:ListItem>
            <asp:ListItem>Chocolate</asp:ListItem>
            <asp:ListItem>Cherry Garcia</asp:ListItem>
            <asp:ListItem>Green Tea</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
