<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewer_Srvc.aspx.cs" Inherits="AadharMedNet.Viewer_Srvc" %>

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
                        <asp:HyperLink ID="MedPrfl" runat="server" NavigateUrl="~/Viewer.aspx">Medical Profile</asp:HyperLink>
                    </li>
                    <li style="background: white"> 
                        <asp:HyperLink ID="MedSrvcs" runat="server" BackColor="White" ForeColor="#0BD3FF">Medical Services</asp:HyperLink>
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
                        <asp:TableCell ID="TblMedSrvcsCellHdng3" runat="server" ColumnSpan="4" HorizontalAlign="Left">Service Details</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw4" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellQulfctn" runat="server">Qualification/Authorization for:</asp:TableCell>
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
                    <asp:TableRow ID="TblMedSrvcsRw8" runat="server" BackColor="#0BD3FF" Font-Names="Gisha" ForeColor="White">
                        <asp:TableCell ID="TblMedSrvcsCellHdng5" runat="server" ColumnSpan="4" HorizontalAlign="Left">Place Request</asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw9" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellFr" runat="server">For:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellFrVal" runat="server">
                            <asp:DropDownList ID="CmbBxFr" runat="server" CssClass="ddl" Font-Names="Gisha">
                                <asp:ListItem>Doctor</asp:ListItem>
                                <asp:ListItem>Blood Donor</asp:ListItem>
                                <asp:ListItem>Organ Donor</asp:ListItem>
                                <asp:ListItem>Sperm Donor</asp:ListItem>
                                <asp:ListItem>Surrogate Mother</asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="TblMedSrvcsRw10" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellUID" runat="server">UID:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellUIDVal" runat="server"></asp:TableCell>
                    </asp:TableRow>  
                    <asp:TableRow ID="TblMedSrvcsRw11" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellRsn" runat="server">Reason:</asp:TableCell>
                        <asp:TableCell ID="TblMedSrvcsCellRsnVal" runat="server">
                            <asp:TextBox ID="TxtBxRsn" runat="server" CssClass="field" TextMode="MultiLine"></asp:TextBox>
                        </asp:TableCell>                        
                    </asp:TableRow> 
                    <asp:TableRow ID="TblMedSrvcsRw12" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblMedSrvcsCellReq" runat="server">
                            <asp:Button ID="BtnReq" runat="server" Text="Request" CssClass="btn" OnClick="BtnReq_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </div>
    </form>
</body>
</html>
