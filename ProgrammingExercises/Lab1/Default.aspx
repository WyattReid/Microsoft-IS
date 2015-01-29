<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1.Default" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab1</title>
    <style type="text/css">
        @import "//fonts.googleapis.com/css?family=Montserrat:300,400,700";
        * {
            font-family: Montserrat
        }
        h1 {
            color:blue
        }
        #errorContainer {
            color: red;
            font-weight: bold;
            float:left
        }

         #form1 {
             width: 40%;
         }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
 
    <div style="float: left; width:100%">
        <h1 >401k Future Value Calculator</h1>
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
            Future Value
        </div>
        <div style ="width: 40%; float:right">
            <asp:Label ID="lblCalcValue" runat="server"/>
        </div>
        
        <div style="width: 100%; padding-top: 1em; float: left">
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click1" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click1" />
        </div>
        
           <div id="errorContainer" style="float: left; width: 100%; padding-top: 1em">
        <div><asp:RequiredFieldValidator runat="server" 
                controltovalidate="txtAnnualRate"
                errormessage="ERROR: Annual Rate is required.">
            </asp:RequiredFieldValidator>
        </div>
        <div><asp:RequiredFieldValidator runat="server" 
                controltovalidate="txtNumYears"
                errormessage="ERROR: The number of years are required.">
            </asp:RequiredFieldValidator>
        </div>  
    </div>
        
    </form>
</body>
</html>
