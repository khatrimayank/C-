<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Employee.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Employee Information : </h2>
            <p>
                &nbsp;</p>
            <p>
                Name :
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            </p>
            <p>
                Select Office :
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" AutoPostBack="True" Height="23px" Visible="True">
                    <asp:ListItem Selected="True">Office</asp:ListItem>
                    <asp:ListItem Value="Navi Mumbai">CBD Belapur</asp:ListItem>
                    <asp:ListItem Value="Mumbai">Borivali</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
            </p>
            <p>
                Department : </p>
            <p>
                <asp:RadioButton ID="RdoMarketing" runat="server" GroupName="Department" Text="Marketing" />
            </p>
            <p>
                <asp:RadioButton ID="RdoAccounting" runat="server" GroupName="Department" Text="Accounting" />
            </p>
            <p>
                <asp:RadioButton ID="RdoLegal" runat="server" GroupName="Department" Text="Legal" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                Qualifications :</p>
            <p>
                <asp:CheckBox ID="ChkBA" runat="server" Text="BA" />
            </p>
            <p>
                <asp:CheckBox ID="ChkMA" runat="server" Text="MA" />
            </p>
            <p>
                <asp:CheckBox ID="ChkPHD" runat="server" Text="PHD" />
            </p>
            <p>
                <asp:Button ID="Btn" runat="server" OnClick="Btn_Click" Text="Go" />
            </p>
            <p>
                <asp:Label ID="LabelAllResult" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
