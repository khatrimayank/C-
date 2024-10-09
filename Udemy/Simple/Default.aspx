<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 70px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Simple Site</h2>
        <div>
            welcome to my demo site
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <img alt="pdf" class="auto-style1" src="Images/COMPLOGO.jpg" /><br />
        </div>
    </form>
    <h3 class="auto-style2">Hello</h3>
</body>
</html>
