<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="WebApp.welcome" %>

<asp:Content id="myContent" runat="server" ContentPlaceholderId="ContentPlaceHolder1">
<div>
    <center><h1>Hello!</h1></center>
    <center><h3>Welcome to RIT's intranet portal!</h3></center>
            <ul>
                <li><a href="department/finance/finance.aspx">Finance</a></li>
                <li><a href="department/hr/hr.aspx">HR</a></li>
            </ul>
</div>
 </asp:Content>
