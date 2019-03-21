<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblVreme1" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" Text="Hello World"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnVreme1" runat="server" Text="Button" OnClick="btnVreme1_Click" />
        <asp:Label ID="lblVreme2" runat="server" Text="Label"></asp:Label>
        <asp:HyperLink ID="hlSledno" runat="server" NavigateUrl="~/WebForm2.aspx">HyperLink</asp:HyperLink>
    </form>
</body>
</html>
