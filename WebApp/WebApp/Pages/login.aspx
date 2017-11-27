<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="cache-control" content="no-cache" />
    <meta http-equiv="Expires" content="0" />
    <meta http-equiv="cache-control" content="no-store" />
    <meta http-equiv="cache-control" content="must-revalidate" />
    <meta http-equiv="cache-control" content="proxy-revalidate" />
    <script src="https://code.jquery.com/jquery-2.2.4.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-cookie/1.4.1/jquery.cookie.js"></script>
    <script src="/scripts/common.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Login Page</h3>
        <table>
            <tr>
                <td>UserName:</td>
                <td>
                    <asp:TextBox ID="UserName" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        ControlToValidate="UserName"
                        Display="Dynamic"
                        ErrorMessage="Cannot be empty."
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="UserPass" TextMode="Password"
                        runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        ControlToValidate="UserPass"
                        ErrorMessage="Cannot be empty."
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Remember me?</td>
                <td>
                    <asp:CheckBox ID="chkboxPersist" runat="server" />
                </td>
            </tr>
        </table>
        <asp:Button ID="Submit1" OnClick="Login_Click" Text="Log In"
            runat="server" />
        <p>
            <asp:Label ID="Msg" ForeColor="red" runat="server" />
        </p>
    </form>
</body>
</html>
