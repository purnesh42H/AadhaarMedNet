﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="AadharMedNet.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height:100%">
<head id="Head1" runat="server">
    <title></title>
    <link href="App_Themes/Themes/MyHome.css" rel="stylesheet" />
</head>
<body style="height: 100%; background: #f3f1f5;">
    <form id="form1" runat="server" style="height:100%; width: 100%;">   
       
        <div class="box">
            <div style="height:4%" class="bar">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
            </div> 
            <div style="height: 100%; width:20%;float:left;">
                <ul id="cssmenu" style="height: 96%">
                    <li>
                        <asp:HyperLink ID="MedPrfl" runat="server" NavigateUrl="~/Home_Prfl.aspx">Medical Profile</asp:HyperLink>
                    </li>
                    <li> 
                        <asp:HyperLink ID="MedSrvcs" runat="server" NavigateUrl="~/Medical Service.aspx">Medical Services</asp:HyperLink>
                    </li>
                    <li> 
                        <asp:HyperLink ID="MyReq" runat="server" NavigateUrl="~/My Requests.aspx">My Requests</asp:HyperLink>
                    </li>                    
                    <li>
                        <asp:HyperLink ID="MyApntmnt" runat="server" NavigateUrl="~/My Appointments.aspx">My Appointments</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="BkApntmnt" runat="server" NavigateUrl="~/Book Appointment.aspx">Book Appointment</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="UpldCrtfct" runat="server" NavigateUrl="~/Upload Certificates.aspx">Upload Certificates</asp:HyperLink>
                    </li>
                    <li style="background: white">
                        <asp:HyperLink ID="Srch" runat="server" BackColor="White" ForeColor="#0BD3FF">Search</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="Stngs" runat="server" NavigateUrl="~/Settings.aspx">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div> 
            <div style="float:right; width:80%; font-family:gisha;"> 
                <asp:Panel ID="PnlSrchFltr" runat="server">
                    <asp:Table ID="TblSrch" runat="server" Width="100%">
                        <asp:TableRow ID="TblSrchRw1" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblSrchCellSrchFr" runat="server">Search For:</asp:TableCell>
                            <asp:TableCell ID="TblSrchCellSrchFrVal" runat="server">
                                <asp:DropDownList ID="CmbBxFr" runat="server" CssClass="ddl" Font-Names="Gisha">
                                     <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>Doctor</asp:ListItem>
                                    <asp:ListItem>Blood Donor</asp:ListItem>
                                    <asp:ListItem>Organ Donor</asp:ListItem>
                                    <asp:ListItem>Sperm Donor</asp:ListItem>
                                    <asp:ListItem>Surrogate Mother</asp:ListItem>
                                </asp:DropDownList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblSrchRw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblSrchCellKyWrd" runat="server">Keyword:</asp:TableCell>
                            <asp:TableCell ID="TblSrchCellKyWrdVal" runat="server">
                                <asp:TextBox ID="TxtBxKyWrd" runat="server" CssClass="field" placeholder="Eg:Surgeon"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblSrchRw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblSrchCellSrch" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblSrchCellSrchVal" runat="server">
                                <asp:Button ID="BtnSrch" runat="server" Text="Search" CssClass="btn" OnClick="BtnSrch_Click" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>                    
                </asp:Panel>
                <asp:Panel ID="PnlSrchRslts" runat="server" Visible="false">
                    <asp:Table ID="TblSrchRslts" runat="server" Width="100%">
                        <asp:TableRow runat="server" Font-Names="Gisha" HorizontalAlign="Left">
                            <asp:TableCell ID="TblSrchRsltsCellHdng" runat="server" BackColor="#0BD3FF" ForeColor="White">Search Results</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server" ForeColor="#0BD3FF" HorizontalAlign="Left">
                            <asp:TableCell ID="TblSrchRsltsCellRslts" runat="server" ForeColor="#0BD3FF">
                                <asp:LinkButton ID="LnkBtn" runat="server" OnClick="LnkBtn_Click">LinkButton</asp:LinkButton>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>                    
                </asp:Panel>
            </div>
        </div>        
    </form>
</body>
</html>
