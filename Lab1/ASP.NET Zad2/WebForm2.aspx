<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">

                <tr>
                    <td class="auto-style2">
                        <asp:Panel ID="pnlPanel" runat="server" BackColor="#CC33FF" Font-Names="helvetica">
                            <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox>
                            <asp:TextBox ID="txtOperand2" runat="server"></asp:TextBox>
                            <asp:Label ID="lblRezultat" runat="server" EnableViewState="False">Rezultat</asp:Label>
                            <asp:Button ID="btnSoberi" runat="server" OnClick="btnSoberi_Click" Text="Soberi" />

                        </asp:Panel>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="chbVidlivo" runat="server" AutoPostBack="True" OnCheckedChanged="chbVidlivo_CheckedChanged" Text="Видливо" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
