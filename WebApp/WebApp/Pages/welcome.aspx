<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="WebApp.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://code.jquery.com/jquery-2.2.4.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-cookie/1.4.1/jquery.cookie.js"></script>
    <script src="/scripts/common.js"></script>
    <script>
        $(document).ready(function () {
            createAuthCookie();
            countdown();
        });
    </script>
    <title>Company X - Welcome</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello!
            <ul>
                <li><a href="department/finance/finance.aspx">Finance</a></li>
                <li><a href="department/hr/hr.aspx">HR</a></li>
            </ul>
        </div>
        <br /><br />
        <p>Time until automatic logoff:&nbsp;</p>
        <p id="demo"></p>
        <hr />
    </form>
</body>
</html>
