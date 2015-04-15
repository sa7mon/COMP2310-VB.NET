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
        <p>
            <asp:Button ID="btnChoice" runat="server" Text="Choice" />
        </p>
        <asp:Label ID="lblChoice" runat="server"></asp:Label>

        <div>
            <asp:RadioButton ID="radSassaphrass" runat="server" GroupName="flavors" Text="Sassaphrass" />
            <asp:RadioButton ID="radGoldNugget" runat="server" GroupName="flavors" Text="Gold Nugget" />
            <asp:RadioButton ID="radMooseDroppings" runat="server" GroupName="flavors" Text="Moose Droppings" />
        </div>
        
        <asp:Button ID="btnChoice2" runat="server" Text="Choice 2" />
        <asp:Label ID="lblChoice2" runat="server"></asp:Label>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </p>
        
    </form>
</body>
</html>
