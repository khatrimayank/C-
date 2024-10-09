<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstRealAspWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            background-color: #FF66FF;
        }
        .auto-style2 {
            width: 150px;
            height: 70px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="TextFirst">
            Welcome to My first Real ASP.NET web application<br />
            <br />
            Enter First Name :
            <asp:TextBox ID="TextFirst" runat="server" OnTextChanged="TextFirst_TextChanged"></asp:TextBox>
            <br />
            <br />
            Enter Last Name :
            <asp:TextBox ID="TextLast" runat="server" OnTextChanged="TextLast_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonGo" runat="server" Text="GO" OnClick="ButtonGo_Click" />

            <input id="Button1" type="button" value="button1" /><br />
            <br />
            <hr />
            <asp:Label ID="Label1" runat="server" Text="LabelResult"></asp:Label>
            <br />
        </div>
    </form>
    <p class="auto-style1">
        <a href="http://cnn.com">HI</a></p>
    <p class="auto-style1">
        <img alt="Logo" class="auto-style2" src="file:///C:/Users/mayank.khatri/Desktop/python/client_ledger_pdf/img/COMPLOGO.jpg" /></p>
</body>
</html>
