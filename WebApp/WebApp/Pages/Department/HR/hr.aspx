<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hr.aspx.cs" Inherits="WebApp.hr" %>

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
    <title>Company X - HR</title>
</head>
<body>
    <form id="form1" runat="server">
        <center><img src="hr.jpg" style="width:50%;height:50%;"/></center>
        <div>
            This is the HR web page.
        </div>
        <br /><br />
        <div><a href="../../welcome.aspx">Home</a></div>
        <p>Time until automatic logoff:&nbsp;</p>
        <p id="demo"></p>
        <hr />
    </form>
</body>
</html>
