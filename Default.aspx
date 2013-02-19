<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="lblPrincipal" runat="server" Text="Principal"></asp:Label><br />

        <asp:TextBox ID="txtPrincipalAmount" runat="server"></asp:TextBox><br />
        
         <asp:Label ID="lblInterestRate" runat="server" Text="Interest Rate"></asp:Label><br />
        <asp:TextBox ID="txtInterestRate" runat="server"></asp:TextBox><br />
          <asp:Label ID="lblMortgageLength" runat="server" Text="Mortgage Length"></asp:Label><br />
        <asp:TextBox ID="txtMortgageLength" runat="server"></asp:TextBox><br />
        <br />

        <asp:Button ID="btnPerformCalculations" runat="server"  Text="Calculate Mortgage"/><br /><br />


        <asp:Label ID="lblResults" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
