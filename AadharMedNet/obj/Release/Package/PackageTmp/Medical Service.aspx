<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medical Service.aspx.cs" Inherits="AadharMedNet.Medical_Service" %>

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
                    <li style="background: white"> 
                        <asp:HyperLink ID="MedSrvcs" runat="server" CssClass="activeLink" BackColor="White" BorderColor="White" ForeColor="#0BD3FF">Medical Services</asp:HyperLink>
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
                    <li>
                        <asp:HyperLink ID="Stngs" runat="server" NavigateUrl="~/Settings.aspx">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div>             
            <div style="float:right; width:80%; font-family:gisha;">
                <asp:Table ID="TblMedSrvcs" runat="server" Width="100%">
                    <asp:TableRow ID="TblMedSrvcsRw1" runat="server" BackColor="#0BD3FF" Font-Names="Gisha" ForeColor="White">
                        <asp:TableCell ID="TblMedSrvcsCellHdng1" runat="server" ColumnSpan="4" HorizontalAlign="Left">Registered Services</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw2" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellRgSrvcs" runat="server">Registered As:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellRgSrvcsVal" runat="server"></asp:TableCell>
                    </asp:TableRow>                    
                    <asp:TableRow ID="TblMedSrvcsRw3" runat="server" BackColor="#0BD3FF" Font-Names="Gisha" ForeColor="White">
                        <asp:TableCell ID="TblMedSrvcsCellHdng3" runat="server" ColumnSpan="4" HorizontalAlign="Left">Profession</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw4" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellQulfctn" runat="server">Qualification:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellQulfctnVal" runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw5" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellSpclztn" runat="server">Specialization:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellSpclztnVal" runat="server"></asp:TableCell>
                    </asp:TableRow>                    
                    <asp:TableRow ID="TblMedSrvcsRw6" runat="server" BackColor="#0BD3FF" Font-Names="Gisha" ForeColor="White">
                        <asp:TableCell ID="TblMedSrvcsCellHdng4" runat="server" ColumnSpan="4" HorizontalAlign="Left">Biography</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw7" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellBgrphyVal" runat="server" ColumnSpan="4" HorizontalAlign="Left">Biography</asp:TableCell>
                        
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>        
    </form>
</body>
</html>
