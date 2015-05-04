<%--
    index.aspx - Contains mixed html and ASP elements parsed to generate pure HTML
                 and JS for the login page.
    Name: Dan Salmon (https://danthesalmon.com)
    Date Created: 4/27/15
--%>
<%@ Page Title="Login" 
    Language="VB" 
    Theme="MyTheme" 
    MasterPageFile="~/MasterPage.master" 
    AutoEventWireup="false" 
    CodeFile="index.aspx.vb" 
    Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <fieldset>
        <legend>Login</legend> 
        <div class='container' id="form_container">
            <div class="form-group">
                <label for="mainContent_txtUserName">Username</label>
                <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" Height="22px" Text="dan"/>
                <asp:RequiredFieldValidator ID="RV1" runat="server" 
                                        ControlToValidate="txtUserName" 
                                        ErrorMessage="Please Enter User Name" 
                                        SetFocusOnError="True">*
                </asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="mainContent_txtPwd">Password</label>
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" 
                                         CssClass="form-control" Height="22px" Text="password"/>
                <asp:RequiredFieldValidator ID="RV2" runat="server" 
                                            ControlToValidate="txtPwd" 
                                            ErrorMessage="Your Password" 
                                            SetFocusOnError="True">*
                </asp:RequiredFieldValidator>
            </div>

            <asp:Button ID="btnLogIn" CssClass="btn btn-primary" runat="server" Text="Sign In" />
        </div>
                     
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error"/>

        <asp:Label ID="lblMsg" runat="server" Text="" CssClass="lbl_error" />
    </fieldset>
    <br />

</asp:Content>

