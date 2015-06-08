<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="AadharMedNet.Settings" %>

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
                    <li>
                        <asp:HyperLink ID="Srch" runat="server" NavigateUrl="~/Search.aspx">Search</asp:HyperLink>
                    </li>
                    <li style="background: white">
                        <asp:HyperLink ID="Stngs" runat="server" BackColor="White" ForeColor="#0BD3FF">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div>             
            <div style="float:right; width:80%; font-family:gisha;">
                <asp:Table ID="TblStngs" runat="server" Width="100%">                    
                    <asp:TableRow ID="TblStngsRw1" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblStngsPblc" runat="server">Make your profile public:</asp:TableCell>
                        <asp:TableCell ID="TblStngsPblcY" runat="server">
                            <asp:RadioButton ID="RadBtnY" runat="server" Text="Yes" OnCheckedChanged="RadBtnY_CheckedChanged" AutoPostBack="true"/>
                        </asp:TableCell>  
                        <asp:TableCell ID="TblStngsPblcN" runat="server">
                            <asp:RadioButton ID="RadBtnN" runat="server" Text="No" OnCheckedChanged="RadBtnN_CheckedChanged" AutoPostBack="true"/>
                        </asp:TableCell>  
                    </asp:TableRow>                                                                                  
                </asp:Table>
            </div>
        </div>        
    </form>
</body>
</html>