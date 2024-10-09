<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CALENDAR_CONTROL.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Here your Calendar
        </p>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="231px" OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Width="372px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <p>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="BtnGet" runat="server" OnClick="BtnGet_Click" Text="GET" />
            <asp:Button ID="BtnSet" runat="server" OnClick="BtnSet_Click" Text="SET" />
            <asp:Button ID="BtnDiff" runat="server" OnClick="BtnDiff_Click" Text="DIFF" />
        </p>
        <asp:Label ID="LblResult2" runat="server"></asp:Label>
    </form>
</body>
</html>
