<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1.Default" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab1</title>
    <style type="text/css">
        #form1 {
            width: 30%;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
    <div id="errorContainer" style="float: left; width: 100%">
        <div><asp:RequiredFieldValidator runat="server" 
                controltovalidate="txtAnnualRate"
                errormessage="Annual Rate is required.">
            </asp:RequiredFieldValidator>
        </div>
        <div><asp:RequiredFieldValidator runat="server" 
                controltovalidate="txtNumYears"
                errormessage="The number of years are required.">
            </asp:RequiredFieldValidator>
        </div>  
    </div>
        

    <div style="float: left; width:100%">
        <h2 style="color: blue">401k Future Value Calculator</h2>
    </div>
        <div style="width: 50%; float:left">
            Monthly Investment
        </div>
        <div style=" width: 40%; float: right;">
            <asp:DropDownList ID="ddlMonthlyInvestment" runat="server"></asp:DropDownList>
        </div>
        <div style="width: 50%; float: left">
            Annual Interest Rate
        </div>
        <div style="width: 40%; float: right;">
            <asp:TextBox ID="txtAnnualRate" runat="server"></asp:TextBox>
        </div>
        <div style="width: 50%; float: left">
            Number of Years
        </div>
        <div style="width: 40%; float: right;">
            <asp:TextBox ID="txtNumYears" runat="server"></asp:TextBox>
        </div>
        <div style="width: 50%; float: left">
            Future Value: <asp:Label ID="lblCalcValue" runat="server"/>
        </div>
        
        <div style="width: 100%; padding-top: 1em; float: left">
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click1" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click1" />
        </div>
        
    </form>
</body>
</html>
