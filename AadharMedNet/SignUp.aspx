<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AadharMedNet.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>     
    <link href="App_Themes/Themes/MySignUp.css" rel="stylesheet" />        
</head>
<body style="background:#00B3D9">
    <form id="msform" runat="server">
        <!-- progressbar -->
        <ul id="progressbar" >
            <li class ="active" id="Step1" runat="server">Step 1</li>
            <li id="Step2" runat="server">Step 2</li>            
        </ul>
        <!-- fieldsets -->
        <asp:Panel ID="PnlStp1" runat="server">
            <fieldset>
                <h2 class="fs-title">Step 1</h2>
                <h3 class="fs-subtitle">Aadhar MedConnect account setup</h3>

                <asp:TextBox runat="server" ID="TxtBxUID" placeholder="Aadhar Number"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtBxUID" ErrorMessage="User Name is required." ValidationGroup="CreateUserWizard1" ToolTip="User Name is required." ID="UserNameRequired">*</asp:RequiredFieldValidator>
                <asp:TextBox runat="server" TextMode="Password" ID="TxtBxPswrd" placeholder="Password" OnTextChanged="TxtBxPswrd_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtBxPswrd" ErrorMessage="Password is required." ValidationGroup="CreateUserWizard1" ToolTip="Password is required." ID="PasswordRequired">*</asp:RequiredFieldValidator>
                <asp:TextBox runat="server" TextMode="Password" ID="TxtBxCnfrmPswrd" placeholder="Confirm Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="TxtBxCnfrmPswrd" ErrorMessage="Confirm Password is required." ValidationGroup="CreateUserWizard1" ToolTip="Confirm Password is required." ID="ConfirmPasswordRequired">*</asp:RequiredFieldValidator>
                <asp:DropDownList ID="CmbBxRegAs" runat="server" Width="100%" Font-Names="Gisha" CssClass="ddl" OnSelectedIndexChanged="CmbBxRegAs_SelectedIndexChanged">
                    <asp:ListItem Value="0">MedNet Member</asp:ListItem>
                    <asp:ListItem Value="1">Doctor</asp:ListItem>
                    <asp:ListItem Value="2">Fund Donor</asp:ListItem>
                    <asp:ListItem Value="3">Organ Donor</asp:ListItem>
                    <asp:ListItem Value="4">Blood Donor</asp:ListItem>
                    <asp:ListItem Value="5">Surrogate Mother</asp:ListItem>
                    <asp:ListItem Value="6">Sperm Donor</asp:ListItem>
                </asp:DropDownList>
                <asp:CompareValidator runat="server" ControlToCompare="TxtBxPswrd" ControlToValidate="TxtBxCnfrmPswrd" ErrorMessage="The Password and Confirmation Password must match." Display="Dynamic" ValidationGroup="CreateUserWizard1" ID="PasswordCompare"></asp:CompareValidator>
                <asp:Literal runat="server" ID="ErrorMessage" EnableViewState="False"></asp:Literal>
                <asp:Button ID="BtnNxt" runat="server" Text="Next" class="action-button" OnClick="BtnNxt_Click" ValidationGroup="CreateUserWizard1" />                                                       
            </fieldset>
        </asp:Panel>
        <asp:Panel ID="PnlStp2" runat="server" Visible="false">
            <fieldset>
                <h2 class="fs-title">Step 2</h2>
                <h3 class="fs-subtitle">Authentication</h3>
                <asp:TextBox ID="TxtBxNm" runat="server" placeholder="Pincode" ValidationGroup="Submit"></asp:TextBox> 
                <asp:DropDownList ID="CmbBxGndr" runat="server" Width="100%" Font-Names="Gisha" CssClass="ddl">                    
                    <asp:ListItem Value="1">Male</asp:ListItem>
                    <asp:ListItem Value="2">Female</asp:ListItem>
                    <asp:ListItem Value="3">Transgender</asp:ListItem>                    
                </asp:DropDownList>
                <br />
                <br />
                <asp:TextBox ID="TxtBxAdd" runat="server" placeholder="OTP" TextMode="MultiLine" ValidationGroup="Sumit" Visible = "false"></asp:TextBox>                               
                <asp:Label ID="LblDOB" runat="server" Text="Date Of Birth"></asp:Label>
                <asp:TextBox ID="TxtBxDOB" runat="server" placeholder="Age"></asp:TextBox>                                               
                <asp:Button ID="BtnPrev" class="previous action-button" runat="server" Text="Previous" OnClick="BtnPrev_Click" />                
                <asp:Button ID="BtnSbmt" runat="server" Text="Submit" class="action-button" OnClick="BtnSbmt_Click" />
            </fieldset>
        </asp:Panel>     
    </form>

</body>
</html>