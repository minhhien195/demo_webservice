<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumingWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="font-family:Arial">  
            <tr>  
                <td>  
                    <b>x: </b>  
                </td>  
                <td>  
                    <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    <b>y: </b>  
                </td>  
                <td>  
                    <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>  
                </td>  
            </tr>  
             <tr>  
                <td>  
                    <b>Result: </b>  
                </td>  
                <td>  
                    <asp:Label ID="lblResult" runat="server" ></asp:Label>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    <asp:Button ID="btncalculate" runat="server" Text="Calculate" OnClick="btncalculate_Click" />  
                    </td>  
                      
  
            </tr>  
        </table>  
    </form>
</body>
</html>
