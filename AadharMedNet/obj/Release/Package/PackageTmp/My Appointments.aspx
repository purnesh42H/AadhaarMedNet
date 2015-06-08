<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="My Appointments.aspx.cs" Inherits="AadharMedNet.My_Appointments" %>

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
                    <li style="background: white">
                        <asp:HyperLink ID="MyApntmnt" runat="server" BackColor="White" ForeColor="#0BD3FF">My Appointments</asp:HyperLink>
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
                    <li>
                        <asp:HyperLink ID="Stngs" runat="server" NavigateUrl="~/Settings.aspx">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div>             
            <div style="float:right; width:80%; font-family:gisha;">
                <asp:Table ID="TblApntmnt" runat="server" Width="100%">                    
                    <asp:TableRow ID="TblApntmntRw1" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblApntmntCellDt" runat="server">Date:</asp:TableCell>
                        <asp:TableCell ID="TblApntmntCellDtVal" runat="server"></asp:TableCell>                        
                    </asp:TableRow>
                    <asp:TableRow ID="TblApntmntRw2" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblApntmntCellTm" runat="server">Time:</asp:TableCell>
                        <asp:TableCell ID="TblApntmntCellTmVal" runat="server"></asp:TableCell>                        
                    </asp:TableRow>  
                    <asp:TableRow ID="TblApntmntRw3" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblApntmntCell" runat="server">Hospital:</asp:TableCell>
                        <asp:TableCell ID="TblApntmntCellRsnVal" runat="server"></asp:TableCell>                        
                    </asp:TableRow>
                    <asp:TableRow ID="TblApntmntRw4" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblRsnCell" runat="server">Reason:</asp:TableCell>
                        <asp:TableCell ID="TblCellRsnVal" runat="server"></asp:TableCell>                        
                    </asp:TableRow> 
                    <asp:TableRow ID="TblAlrgy2" runat="server" BackColor="white" HorizontalAlign="Left" >
                        <asp:TableCell ID="TblAlrgy2Rw1" runat="server" ColumnSpan="4" ForeColor="White">#2</asp:TableCell>
                    </asp:TableRow> 
                    <asp:TableRow ID="TableRow1" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TableCell1" runat="server">Date:</asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server"></asp:TableCell>                        
                    </asp:TableRow>
                    <asp:TableRow ID="TableRow2" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TableCell3" runat="server">Time:</asp:TableCell>
                        <asp:TableCell ID="TableCell4" runat="server"></asp:TableCell>                        
                    </asp:TableRow>  
                    <asp:TableRow ID="TableRow3" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TableCell5" runat="server">Hospital:</asp:TableCell>
                        <asp:TableCell ID="TableCell6" runat="server"></asp:TableCell>                        
                    </asp:TableRow>
                    <asp:TableRow ID="TableRow4" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TableCell7" runat="server">Reason:</asp:TableCell>
                        <asp:TableCell ID="TableCell8" runat="server"></asp:TableCell>                        
                    </asp:TableRow>                                                                      
                </asp:Table>
            </div>
        </div>        
    </form>
</body>
</html>
