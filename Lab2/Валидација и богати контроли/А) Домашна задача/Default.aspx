<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 132px;
        }
        .auto-style3 {
            width: 94px;
        }
        .auto-style4 {
            width: 349px;
        }
        .auto-style5 {
            width: 109px;
        }
        .auto-style6 {
            width: 354px;
        }
        .auto-style7 {
            margin-left: 0px;
        }
        .auto-style8 {
            width: 133px;
        }
        .auto-style9 {
            width: 93px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1. Валидација (задача 1A)<br />
            <table class="auto-style4">
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Text="Провери" Width="88px" />
                    </td>
                    <td class="auto-style5">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Неисполнет услов" ValidationExpression="[0-9A-Z]*(_*([0-9]{2,})+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
            <br />
            2. Валидација (задача 2A)<br />
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style7" Text="Провери" Width="89px" />
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RegularExpressionValidator" ValidationExpression="([\+]389 2 [0-9]{4} [0-9]{3})|([\+]389 7[0-9] [0-9]{3} [0-9]{3})"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
