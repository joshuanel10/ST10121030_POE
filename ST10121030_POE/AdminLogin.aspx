<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ST10121030_POE.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Email:   "></asp:Label>
        <asp:TextBox ID="AdminEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password:   "></asp:Label>
            <asp:TextBox ID="AdminPass" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="txtInfo" runat="server" Text=""></asp:Label>
        <p>
        <asp:Button ID="AdminLoginbtn" runat="server" Text="Login" OnClick="AdminLoginbtn_Click" />
        </p>
        <asp:Button ID="back" runat="server" Text="Back" OnClick="back_Click" />
    </form>
</body>
</html>
