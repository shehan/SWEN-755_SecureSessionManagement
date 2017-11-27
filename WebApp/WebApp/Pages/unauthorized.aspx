<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unauthorized.aspx.cs" Inherits="WebApp.Pages.unauthorized" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="cache-control" content="no-cache" />
    <meta http-equiv="Expires" content="0" />
    <meta http-equiv="cache-control" content="no-store" />
    <meta http-equiv="cache-control" content="must-revalidate" />
    <meta http-equiv="cache-control" content="proxy-revalidate" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
           <h1>Unauthorized Access!</h1> 
        </div>
        <div>
            <img src="../Images/dancingbanana.gif" /> &nbsp;&nbsp;
            <img src="../Images/loading.gif" />&nbsp;&nbsp;
            <img src="../Images/dancingbanana.gif" />
        </div>
        </center>
        <a href="welcome.aspx">Home</a>
    </form>
</body>
</html>
