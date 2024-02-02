<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="ST10121030_POE.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtAdminEmail" runat="server" Text=""></asp:Label>
        </div>

                <div>
            <table align="center">
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="txtfrmName" runat="server"></asp:TextBox>
                        

                    </td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="txtfrmSurname" runat="server"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtfrmEmail" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>PhoneNo.</td>
                    <td>
                        <asp:TextBox ID="txtfrmPhone" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtfrmPassword" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnFarmerCreate" runat="server" Text="Insert" OnClick="btnFarmerCreate_Click"/>
                    </td>
                </tr>
            </table>
        </div>
        <div>
        </div>

        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Farmer Email:   "></asp:Label>
            <asp:TextBox ID="txtFarmerSearch" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="btnFarmerSearch" runat="server" Text="Search" OnClick="btnFarmerSearch_Click" />
        </p>

        <table style="width: 800px; margin: auto">
            <tr>
                <td>
                    <asp:GridView ID="ProductView" runat="server" Width="100%"></asp:GridView>
                </td>
            </tr>
        </table>

        <p>
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
        </p>

    </form>
</body>
</html>
