<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Navigation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Navigation Demos<br />
            <br />
            <a href="Page2.aspx">Text Hyperlink using HTML</a><br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page2.aspx">GoToPage2</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" Height="70px" ImageUrl="~/Images/NextPage.png" ImageWidth="70px" NavigateUrl="~/Page2.aspx">HyperLink</asp:HyperLink>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Page2</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            Login :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="Go" />
            <br />
            <br />
            Password :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
