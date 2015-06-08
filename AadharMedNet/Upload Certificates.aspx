<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload Certificates.aspx.cs" Inherits="AadharMedNet.Upload_Certificates" %>

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
                    <li style="background: white">
                        <asp:HyperLink ID="UpldCrtfct" runat="server" BackColor="White" ForeColor="#0BD3FF">Upload Certificates</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="Srch" runat="server" NavigateUrl="~/Search.aspx">Search</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="Stngs" runat="server" NavigateUrl="~/Settings.aspx">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div>             
            <div style="float:right; width:80%; font-family:gisha;">
                <asp:Table ID="TblUpldCrtfcts" runat="server" Width="100%">    
                    <asp:TableRow ID="TblUpldCrtfctsRw1" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblUpldCrtfctsCellFr" runat="server">For:</asp:TableCell>
                        <asp:TableCell ID="TblUpldCrtfctsCellFrVal" runat="server">
                            <asp:DropDownList ID="CmbBxFr" runat="server" CssClass="ddl" Font-Names="Gisha">
                                <asp:ListItem>Doctor</asp:ListItem>
                                <asp:ListItem>Blood Donor</asp:ListItem>
                                <asp:ListItem>Organ Donor</asp:ListItem>
                                <asp:ListItem>Sperm Donor</asp:ListItem>   
                                <asp:ListItem>Surrogate Mother</asp:ListItem>                                                             
                            </asp:DropDownList>
                        </asp:TableCell>                                                
                    </asp:TableRow>                
                    <asp:TableRow ID="TblUpldCrtfctsRw2" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblUpldCrtfctsCellFl" runat="server">Certificate:</asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellHsptlVal" runat="server">
                            <asp:FileUpload ID="FlUpld" runat="server" CssClass="ddl" />
                        </asp:TableCell>                        
                    </asp:TableRow>   
                    <asp:TableRow ID="TblUpldCrtfctsRw3" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblUpldCrtfctsCellSbmt" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TblUpldCrtfctsCellSbmtVal" runat="server">
                            <asp:Button ID="BtnSbmt" runat="server" Text="Submit" CssClass="btn" />
                        </asp:TableCell>
                                               
                    </asp:TableRow>                                                                                                 
                </asp:Table>
                <asp:Label ID="LblNote" runat="server" Text="Note: It will take upto 24 Hrs. to verify your documents." Font-Names="Gisha" ForeColor="Red"></asp:Label>
            </div>
        </div>        
    </form>
</body>
</html>
