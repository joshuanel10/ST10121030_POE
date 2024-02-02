<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ST10121030_POE.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="height: 57px">
                Farmer Management Software</div>
        </div>
        <asp:Button ID="farmerbtn" runat="server" Text="Farmer Log In" OnClick="farmerbtn_Click" />
        <p>
            <asp:Button ID="adminbtn" runat="server" Text="Admin Log In" OnClick="adminbtn_Click" />
        </p>
    </form>
</body>
</html>
