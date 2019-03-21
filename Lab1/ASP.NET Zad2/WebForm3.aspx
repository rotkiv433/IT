<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password" OnTextChanged="txtLozinka_TextChanged"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtPoraka" runat="server" ReadOnly="True" Rows="5" TextMode="MultiLine" AutoPostBack="True" OnTextChanged="txtPoraka_TextChanged"></asp:TextBox>
        <asp:Button ID="btnProveri" runat="server" OnClick="btnProveri_Click" Text="Proveri" />
        <asp:Button ID="btnPrvaStrana" runat="server" Enabled="False" OnClick="btnPrvaStrana_Click" Text="Prva Strana" PostBackUrl="~/WebForm1.aspx" />
    </form>
</body>
</html>
