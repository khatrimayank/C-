<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MultiPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 222px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to my MultiPage Web Application<br />
            <br />
            <img alt="Image1" class="auto-style1" src="Images/15.06.2024_17.31.17_REC.png" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            Click here to go to <a href="Page2.aspx">page2</a></div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
