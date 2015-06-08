<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="My Requests.aspx.cs" Inherits="AadharMedNet.My_Requests" %>

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
                    <li style="background: white"> 
                        <asp:HyperLink ID="MyReq" runat="server" BackColor="White" ForeColor="#0BD3FF">My Requests</asp:HyperLink>
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
                    <li>
                        <asp:HyperLink ID="Stngs" runat="server" NavigateUrl="~/Settings.aspx">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div>             
            <div style="float:right; width:80%; font-family:gisha;">
                <asp:Table ID="TblReq" runat="server" Width="100%">
                    <asp:TableRow ID="TblReqRw1" runat="server" BackColor="#0BD3FF" Font-Names="Gisha" ForeColor="White">
                        <asp:TableCell ID="TblReqCellHdng1" runat="server" ColumnSpan="4" HorizontalAlign="Left">Recieved</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblReqRw2" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblReqCellFr" runat="server">Request For:</asp:TableCell>
                        <asp:TableCell ID="TblReqCellFrVal" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TblReqCellUID" runat="server">UID:</asp:TableCell>
                        <asp:TableCell ID="TblReqCellUIDVal" runat="server"></asp:TableCell>
                    </asp:TableRow>  
                    <asp:TableRow ID="TblReqRw3" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblReqCellRsn" runat="server">Reason:</asp:TableCell>
                        <asp:TableCell ID="TblReqCellRsnVal" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TblReqCellCntct" runat="server">Contact:</asp:TableCell>
                        <asp:TableCell ID="TblReqCellCntctVal" runat="server"></asp:TableCell>
                    </asp:TableRow>                   
                    <asp:TableRow ID="TblReqRw4" runat="server" BackColor="#0BD3FF" Font-Names="Gisha" ForeColor="White">
                        <asp:TableCell ID="TblReqCellHdng3" runat="server" ColumnSpan="4" HorizontalAlign="Left">Placed</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblReqRw5" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblReqCellPFr" runat="server">For:</asp:TableCell>
                        <asp:TableCell ID="TblReqCellPFrVal" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TblReqCellPUID" runat="server">Specialization:</asp:TableCell>
                        <asp:TableCell ID="TblReqCellPUIDVal" runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblReqRw6" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblReqCellSts" runat="server">Status:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellSpclztnVal" runat="server"></asp:TableCell>
                    </asp:TableRow>                    
                    
                </asp:Table>
            </div>
        </div>        
    </form>
</body>
</html>

