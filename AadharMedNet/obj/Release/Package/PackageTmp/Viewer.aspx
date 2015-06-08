<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewer.aspx.cs" Inherits="AadharMedNet.Viewer" %>

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
                    <li style="background: white">
                        <asp:HyperLink ID="MedPrfl" runat="server" BackColor="White" ForeColor="#0BD3FF">Medical Profile</asp:HyperLink>
                    </li>
                    <li> 
                        <asp:HyperLink ID="MedSrvcs" runat="server" NavigateUrl="~/Viewer_Srvc.aspx">Medical Services</asp:HyperLink>
                    </li>                    
                </ul>
            </div> 
            <div style="float:right; width:80%; font-family:gisha;"> 
                <asp:Panel ID="PnlPblc" runat="server" Visible="true">
                    <asp:Table ID="TblMedPrfl" runat="server" Font-Names="Gisha" Width="100%">
                        <asp:TableRow ID="TblPIRw1" runat="server" BackColor="#0BD3FF" HorizontalAlign="Left">
                            <asp:TableCell ID="TblPICellPI" runat="server" ColumnSpan="4" ForeColor="White">Personal Information</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblPIRw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblPICellDOB" runat="server">Age:</asp:TableCell>
                            <asp:TableCell ID="TblPICellDOBVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblPICellEml" runat="server">Email:</asp:TableCell>
                            <asp:TableCell ID="TblPICellEmlVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblPIRw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblPICellPhNo" runat="server">Phone Number:</asp:TableCell>
                            <asp:TableCell ID="TblPICellPhNoVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblPICellPhNo1" runat="server">Alt. Phone Number:</asp:TableCell>
                            <asp:TableCell ID="TblPICellPhNo1Val" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblPIRw4" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblPICellGndr" runat="server">Gender:</asp:TableCell>
                            <asp:TableCell ID="TblPICellGndrVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblPICellBldGrp" runat="server">Blood Group:</asp:TableCell>
                            <asp:TableCell ID="TblPICellBldGrpVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblPIRw5" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblPICellHght" runat="server">Height:</asp:TableCell>
                            <asp:TableCell ID="TblPICellHghtVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblPICellWght" runat="server">Weight:</asp:TableCell>
                            <asp:TableCell ID="TblPICellWghtVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblEmrgcyCntctRw1" runat="server" BackColor="#0BD3FF" HorizontalAlign="Left">
                            <asp:TableCell ID="TblEmrgcyCntctCell" runat="server" ColumnSpan="4" ForeColor="White">Emergency Contact</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblEmrgcyCntctRw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblEmrgcyCntctCellNm" runat="server">UID:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntctCellNmVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntctCellRel" runat="server">Relation:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntctCellRelVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblEmrgcyCntctRw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblEmrgcyCntctCellPhNo" runat="server">Phone Number:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntctCellPhNoVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntctCellAltPhNo" runat="server">Alt. Phone Number:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntctCellAltPhNoVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblEmrgcyCntct1Rw1" runat="server" BackColor="white" HorizontalAlign="Left">
                            <asp:TableCell ID="TblEmrgcyCntct1Cell" runat="server" ColumnSpan="4" ForeColor="White">#2</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblEmrgcyCntct1Rw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblEmrgcyCntct1CellNm" runat="server">UID:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntct1CellNmVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntct1CellRel" runat="server">Relation:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntct1CellRelVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblEmrgcyCntct1Rw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblEmrgcyCntct1CellPhNo" runat="server">Phone Number:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntct1CellPhNoVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntct1CellAltPhNo" runat="server">Alt. Phone Number:</asp:TableCell>
                            <asp:TableCell ID="TblEmrgcyCntct1CellAltPhNoVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblMedCondn" runat="server" BackColor="#0BD3FF" HorizontalAlign="Left">
                            <asp:TableCell ID="TblMedCondnRw1" runat="server" ColumnSpan="4" ForeColor="White">Current Medical Conditions</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblMedCondnRw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblMedCondnCellCndn" runat="server">Condition:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondnCellCndnVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblMedCondnCellMdcn" runat="server">Medication:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondnCellMdcnVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblMedCondnRw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblMedCondnCellFreq" runat="server">Frequency:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondnCellFreqVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblMedCondnCellDsg" runat="server">Dosage:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondnCellDsgVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblMedCondn1" runat="server" BackColor="white" HorizontalAlign="Left">
                            <asp:TableCell ID="TblMedCondn1Rw1" runat="server" ColumnSpan="4" ForeColor="White">#2</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblMedCondn1Rw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblMedCondn1CellCndn" runat="server">Condition:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondn1CellCndnVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblMedCondn1CellMdcn" runat="server">Medication:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondn1CellMdcnVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblMedCondn1Rw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblMedCondn1CellFreq" runat="server">Frequency:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondn1CellFreqVal" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblMedCondn1CellDsg" runat="server">Dosage:</asp:TableCell>
                            <asp:TableCell ID="TblMedCondn1CellDsgVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblAlrgy" runat="server" BackColor="#0BD3FF" HorizontalAlign="Left">
                            <asp:TableCell ID="TblAlrgyRw1" runat="server" ColumnSpan="4" ForeColor="White">Allergies</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblAlrgyRw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblAlrgyCellAlrgc2" runat="server">Allergic To:</asp:TableCell>
                            <asp:TableCell ID="TblAlrgyCellAlrgc2Val" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblAlrgyCellSmptms" runat="server">Symptoms:</asp:TableCell>
                            <asp:TableCell ID="TblAlrgyCellSmptmsVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblAlrgy2" runat="server" BackColor="white" HorizontalAlign="Left">
                            <asp:TableCell ID="TblAlrgy2Rw1" runat="server" ColumnSpan="4" ForeColor="White">#2</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblAlrgy2Rw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblAlrgy2CellAlrgc2" runat="server">Allergic To:</asp:TableCell>
                            <asp:TableCell ID="TblAlrgy2CellAlrgc2Val" runat="server"></asp:TableCell>
                            <asp:TableCell ID="TblAlrgy2CellSmptms" runat="server">Symptoms:</asp:TableCell>
                            <asp:TableCell ID="TblAlrgy2CellSmptmsVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblFlyHstry" runat="server" BackColor="#0BD3FF" HorizontalAlign="Left">
                            <asp:TableCell ID="TblFlyHstryRw1" runat="server" ColumnSpan="4" ForeColor="White">Family History</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblFlyHstryRw2" runat="server" HorizontalAlign="Left">
                           <asp:TableCell ID="TblFlyHstryCellUID" runat="server">Relative UID:</asp:TableCell>
                        <asp:TableCell ID="TblFlyHstryCellUIDVal" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TblFlyHstryCellRltn" runat="server">Your Relation:</asp:TableCell>
                        <asp:TableCell ID="TblFlyHstryCellRltnVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TblFlyHstryRw3" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblFlyHstryCellCndtn" runat="server">Relative Disease:</asp:TableCell>
                        <asp:TableCell ID="TblFlyHstryCellCndtnVal" runat="server"></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:Panel>
                <asp:Panel ID="PnlPrvt" runat="server" Visible="false">
                    This profile is private. Click <asp:LinkButton ID="LnkBtnReq" runat="server" OnClick="LnkBtnReq_Click">here</asp:LinkButton>  to request permission to view profile.
                </asp:Panel>
                <asp:Panel ID="PnlReq" runat="server" Visible="false">
                    <asp:Table ID="Table1" runat="server" Width="100%">
                        <asp:TableRow ID="TblReqRw1" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblReqCellUID" runat="server">UID:</asp:TableCell>
                            <asp:TableCell ID="TblReqCellUIDVal" runat="server"></asp:TableCell>
                        </asp:TableRow>  
                        <asp:TableRow ID="TblReqRw2" runat="server" HorizontalAlign="Left">
                            <asp:TableCell ID="TblReqCellRsn" runat="server">Reason:</asp:TableCell>
                            <asp:TableCell ID="TblReqCellRsnVal" runat="server">
                                <asp:TextBox ID="TxtBxRsn" runat="server" CssClass="field" TextMode="MultiLine"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>  
                        <asp:TableRow ID="TblReqRw3" runat="server" HorizontalAlign="Left">                            
                            <asp:TableCell ID="TblReqCellSrchVal" runat="server">
                                <asp:Button ID="BtnReq" runat="server" Text="Request" CssClass="btn" OnClick="BtnReq_Click" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:Panel>
            </div>
        </div>        
    </form>
</body>
</html>