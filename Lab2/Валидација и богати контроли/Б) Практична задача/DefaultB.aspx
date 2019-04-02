<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultB.aspx.cs" Inherits="lab2.DefaultB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 734px;
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            height: 23px;
            width: 130px;
        }
        .auto-style5 {
            width: 286px;
        }
        .auto-style6 {
            height: 23px;
            width: 286px;
        }
        .auto-style8 {
            width: 130px;
            height: 26px;
        }
        .auto-style9 {
            width: 286px;
            height: 26px;
        }
        .auto-style10 {
            width: 265px;
        }
        .auto-style11 {
            width: 265px;
            height: 26px;
        }
        .auto-style12 {
            height: 23px;
            width: 265px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Име</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtIme" Display="None" ErrorMessage="Внеси име"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Презиме</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtPrezime" Display="None" ErrorMessage="Внеси презиме"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">ФИНКИ ID</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtFinkiID" runat="server"></asp:TextBox>
                        @finki.ukim.mk</td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtFinkiID" Display="None" ErrorMessage="Внеси ФИНКИ ID"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rexv1" runat="server" ControlToValidate="txtFinkiID" Display="None" ErrorMessage="Невалиден ФИНКИ ID формат" ValidationExpression="[0-9A-Z]*(_*([0-9]{2,})+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Лозинка</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtLozinka" Display="None" ErrorMessage="Внеси лозинка"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Потврда</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtLozinka2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="rfv5" runat="server" ControlToValidate="txtLozinka2" Display="None" ErrorMessage="Повтори лозинка"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cv1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtLozinka2" Display="None" ErrorMessage="Лозинките не се совпаѓаат"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Адреса</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtAdresa" Display="None" ErrorMessage="Внеси адреса"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Телефон</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtTelefon" Display="None" ErrorMessage="Внеси телефон"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rexv2" runat="server" ControlToValidate="txtTelefon" Display="None" ErrorMessage="Невалиден формат на телефон" ValidationExpression="([\+]389 2 [0-9]{4} [0-9]{3})|([\+]389 7[0-9] [0-9]{3} [0-9]{3})"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Пол</td>
                    <td class="auto-style6">
                        <asp:RadioButtonList ID="rblPol" runat="server" Height="16px" Width="53px">
                            <asp:ListItem>М</asp:ListItem>
                            <asp:ListItem>Ж</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style12">
                        <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="rblPol" Display="None" ErrorMessage="Избери пол"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Датум на раѓање</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Calendar ID="kalendar" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" VisibleDate="1985-06-26" Width="330px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <br />
        <br />
        Занимање<br />
        <asp:DropDownList ID="ddlZanimanje" runat="server">
            <asp:ListItem>Градежништво</asp:ListItem>
            <asp:ListItem>Програмирање</asp:ListItem>
            <asp:ListItem>Архитектура</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblZanimanje" runat="server"></asp:Label>
        <br />
        <br />
        Години на вршење на избраната дејност<br />
        <asp:TextBox ID="txtGodini" runat="server"></asp:TextBox>
        <asp:Label ID="lblGodini" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnPodnesi" runat="server" OnClick="btnPodnesi_Click" Text="Поднеси" />
        <br />
        <asp:Label ID="lblSmetka" runat="server"></asp:Label>
        <br />
        <asp:ValidationSummary ID="validateSummary" runat="server" ForeColor="#EB2F14" Height="57px" />
    </form>
</body>
</html>
