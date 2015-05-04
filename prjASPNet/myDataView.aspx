<%--
    myDataView - Contains mixed asp and html controls that are parsed to generate pure HTML and JS
                 for the book collection page.
    Name: Dan Salmon (https://danthesalmon.com)
    Date Created: 4/27/15
--%>

<%@ Page 
    Title="My Collection" 
    Theme="MyTheme" 
    Language="VB" 
    MasterPageFile="~/MasterPage.master" 
    AutoEventWireup="false" 
    CodeFile="myDataView.aspx.vb" 
    Inherits="collection" 
%>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <h2>Your Book Collection</h2>

    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" CssClass="gvtable">
        <Columns>
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" ReadOnly="True" />
            <asp:BoundField DataField="bookName" HeaderText="Title" />
            <asp:BoundField DataField="author" HeaderText="Author" />
            <asp:BoundField DataField="cover" HeaderText="Cover" />
            <asp:BoundField DataField="typeDesc" HeaderText="Type" ReadOnly="True" />

            <asp:CommandField ShowEditButton="true" ShowDeleteButton="True" ButtonType="Image" DeleteImageUrl="App_Themes/MyTheme/trash.png" EditImageUrl="App_Themes/MyTheme/pencil.png" UpdateImageUrl="App_Themes/MyTheme/floppy.png" CancelImageUrl="App_Themes/MyTheme/times.png" >
            <ItemStyle CssClass="gvControl" />
            </asp:CommandField>
        </Columns>
        <HeaderStyle CssClass="gv_header" />
    </asp:GridView>

    <br />
    <div id="addBook">
        <fieldset>
            <legend>Add Book</legend>
            <table id="tbl_addBook">
                <tr>
                    <td class="tablelbl">
                        <asp:Label ID="lblISBN" runat="server" Text="ISBN: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtISBN" runat="server">123-4-567-89012-3</asp:TextBox>
                    </td>
                    <td class="tablelbl">
                        <asp:Label ID="lblType" runat="server" Text="Type: "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddType" runat="server">
                            <asp:ListItem Value="1">Fiction</asp:ListItem>
                            <asp:ListItem Value="2">Non-Fiction</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="tablelbl">
                        <asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server">The best book in the world</asp:TextBox>
                    </td>
                    <td class="tablelbl">
                        <asp:Label ID="lblAuthor" runat="server" Text="Author: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAuthor" runat="server">Dan</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tablelbl">
                        <asp:Label ID="lblCover" runat="server" Text="Cover:&nbsp;"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblistCover" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Soft&nbsp;" selected="true" />
                            <asp:ListItem Text="Hard" />
                        </asp:RadioButtonList>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: center;">
                        <asp:Button ID="btnAdd" runat="server" Text="Add Book" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
    <br />
    <br />
</asp:Content>

