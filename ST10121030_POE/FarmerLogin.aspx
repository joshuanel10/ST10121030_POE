<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FarmerLogin.aspx.cs" Inherits="ST10121030_POE.FarmerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email:   "></asp:Label>
            <asp:TextBox ID="txtFarmerEmail" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Password:   "></asp:Label>
        <asp:TextBox ID="txtFarmerPassword" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblLoginSuccess" runat="server" Text=""></asp:Label>
        </p>
        <asp:Button ID="btnFarmerLogin" runat="server" Text="Login" OnClick="btnFarmerLogin_Click" />
        <p>
            <asp:Button ID="back" runat="server" Text="Back" OnClick="back_Click" />
        </p>
    </form>
</body>
</html>
