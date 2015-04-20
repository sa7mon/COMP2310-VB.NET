<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv" runat="server"></asp:GridView>
    </div>
    <br />
    <div>
        <asp:DropDownList ID="lstPhone" runat="server">
        </asp:DropDownList>

    </div>
        
        <asp:Label ID="Label1" runat="server" for="Textbox1" Text="UserID"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
        <br />
            <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        
        <asp:Button ID="btnSave" runat="server" Text="Save to Database" />

        
    </form>
</body>
</html>
