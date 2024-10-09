<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizaaStore.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Pick your favourite 
            Pizza&nbsp; from the list below
            <br />
            <br />
            <asp:RadioButton ID="RdoBaby" runat="server"  Text="Baby $10" GroupName="Food" />
            <br />
            <asp:RadioButton ID="RdoMama" runat="server"  Text="Mama $13" GroupName="Food" />
            <br />
            <asp:RadioButton ID="RdoPapa" runat="server" Text="Papa $16" GroupName="Food" />
            <br />
            <br />
            <asp:RadioButton ID="RdoThinCrust" runat="server" GroupName="Crust" Text="ThinCrust" />
            <br />
            <asp:RadioButton ID="RdoDeepCrust" runat="server" GroupName="Crust" Text="DeepCrust(+$2.00)" />
            <br />
            <br />
            <asp:CheckBox ID="Chkpepperoni" runat="server" Text="pepperoni" />
            <br />
            <asp:CheckBox ID="Chkgreenpeppers" runat="server" Text="greenpeppers" />
            <br />
            <asp:CheckBox ID="Chkanchovies" runat="server" Text="anchovies" />
            <br />
            <asp:CheckBox ID="Chkredpeppers" runat="server" Text="redpeppers" />
            <br />
            <asp:CheckBox ID="Chkonions" runat="server" Text="onions" />
            <br />
            <br />
            <br />
            Special Deal Save&nbsp; $2.00 when you add pepperoni , green peppers and anchovies OR<br />
            pepperoni , red peppers and onions&nbsp; to ypur pizza<br />
            <br />
            <asp:Button ID="BtnPurchase" runat="server" OnClick="BtnPurchase_Click" Text="Purchase" />
            <br />
            <br />
            <br />
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
