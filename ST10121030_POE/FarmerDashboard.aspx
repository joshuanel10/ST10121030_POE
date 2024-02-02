<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FarmerDashboard.aspx.cs" Inherits="ST10121030_POE.FarmerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbluserEmail" runat="server" Text=""></asp:Label>
        </div>

                <div>
            <table align="center">
                <tr>
                    <td>ProductName</td>
                    <td>
                        <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>Description</td>
                    <td>
                        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>Quantity</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnProdAdd" runat="server" Text="Insert" OnClick="btnProdAdd_Click"  />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="btnBack" runat="server"  Text="Back" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>
