<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Navigation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 212px;
            height: 71px;
            border-width: 0px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello From Page2:<br />
            <br />
            <a href="Default.aspx">
            <img alt="" class="auto-style1" src="Images/homepage_icon.png" /></a><br />
            <br />
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
