<%@ Page Title="" Language="VB" Theme="MyTheme" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Main Heading</h1>
    <h2>Sub Heading</h2>
    <p>Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum </p>
    <hr />
    <asp:Label ID="lblDemo" runat="server" Text="I'm a label: "></asp:Label>
    <asp:TextBox ID="txtDemo" runat="server"></asp:TextBox>
    <asp:Button ID="btnDemo" runat="server" Text="Button" />
    <hr />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem Value="Item 1"></asp:ListItem>
        <asp:ListItem Value="Item 2"></asp:ListItem>
        <asp:ListItem Value="Item 3"></asp:ListItem>
    </asp:CheckBoxList>
    <hr />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Value="Item 1"></asp:ListItem>
        <asp:ListItem Value="Item 2"></asp:ListItem>
        <asp:ListItem Value="Item 3"></asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>

