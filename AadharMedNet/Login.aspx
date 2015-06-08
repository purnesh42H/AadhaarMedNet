<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AadharMedNet.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Themes/Themes/MyLogin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="box">
            <div class="content">
                <h1>
                    <img src="Images/medical_symbol.png" style="height: 55px; width: 43px;"/>AADHAR MEDNET
                </h1>
                <asp:TextBox class="field" placeholder="Aadhar Number" ID="TxtBxUsrNm" runat="server" BorderStyle="Solid" BorderWidth="2px" Width="95%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ReqdFldVldtr" runat="server" ControlToValidate="TxtBxUsrNm" ErrorMessage="User Name is required." ToolTip="Aadhar Number is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                <br>
                <asp:TextBox class="field" placeholder="Password" ID="TxtBxPswrd" runat="server" TextMode="Password" BorderStyle="Solid" BorderWidth="2px" Width="95%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="TxtBxPswrd" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                <br>
                <asp:Button class="btn" ID="BtnLgn" runat="server" CommandName="Login" Text="Sign In" ValidationGroup="Login1" OnClick="BtnLgn_Click"></asp:Button>
                <br />
                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                <br />
                Don&#39;t have an Aadhar MedNet account? <a href="SignUp.aspx">Sign up now</a>
            </div>
        </div>
    </form>
</body>
</html>
