<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GestionReservas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Login</strong></td>
                </tr>
                <tr>
                    <td class="auto-style3">Username:</td>
                    <td>
                        <asp:TextBox ID="TxtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Password:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TxtPass" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
                        <br />
                        <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:LinkButton ID="LnkAdd" runat="server" OnClick="LnkAdd_Click">Home</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
