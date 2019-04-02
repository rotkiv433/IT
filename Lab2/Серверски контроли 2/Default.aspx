<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 292px;
        }
        .auto-style2 {
            width: 126px;
        }
        .auto-style3 {
            width: 126px;
            height: 29px;
        }
        .auto-style4 {
            width: 292px;
            height: 29px;
        }
        .auto-style5 {
            width: 126px;
            height: 26px;
        }
        .auto-style6 {
            width: 292px;
            height: 26px;
        }
        .auto-style7 {
            width: 126px;
            height: 58px;
        }
        .auto-style8 {
            width: 292px;
            height: 58px;
        }
        .auto-style9 {
            margin-left: 429px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float:left">
            <table>
                <tr>
                    <td class="auto-style3">
                        Име:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtBoxIme" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Презиме:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtBoxPrezime" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        Од:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlOd" runat="server">
                            <asp:ListItem>Скопје</asp:ListItem>
                            <asp:ListItem>Охрид</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        До:</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlDo" runat="server">
                            <asp:ListItem>Рим</asp:ListItem>
                            <asp:ListItem>Токио</asp:ListItem>
                            <asp:ListItem>Виена</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Датум на тргање:</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlDen" runat="server" OnSelectedIndexChanged="ddlDen_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlMesec" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlGodina" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Време на тргање:</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlVreme" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Превозно средство:</td>
                    <td class="auto-style1">
                        <asp:ListBox ID="lstSredstvo" runat="server" Height="46px" Width="104px">
                            <asp:ListItem>Воз</asp:ListItem>
                            <asp:ListItem>Авион</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        Зона:</td>
                    <td class="auto-style6">
                        <asp:RadioButtonList ID="rblZona" runat="server">
                            <asp:ListItem>Пушачи</asp:ListItem>
                            <asp:ListItem>Непушачи</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        Класа:</td>
                    <td class="auto-style8">
                        <asp:RadioButtonList ID="rblKlasa" runat="server">
                            <asp:ListItem>Економска</asp:ListItem>
                            <asp:ListItem>Бизнис</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        Послуга:</td>
                    <td class="auto-style1">
                        <asp:CheckBoxList ID="cblPosluga" runat="server">
                            <asp:ListItem>Пијалок</asp:ListItem>
                            <asp:ListItem>Кафе</asp:ListItem>
                            <asp:ListItem>Оброк</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnPodnesi" runat="server" Text="Поднеси" OnClick="btnPodnesi_Click"/>
                    </td>
                </tr>
                <asp:Panel ID="Panel1" runat="server">
                </asp:Panel>
            </table>
        </div>
        <asp:Panel ID="lblPanela" runat="server" CssClass="auto-style9" Height="513px" BackColor="#FFFCE6">
            Почитуван патнику<br />
            <asp:Label ID="lblPatnik" runat="server" Text="lblPatnik" ForeColor="Red"></asp:Label>
            <br />
            <br />
            Издадена ви е карта за<br />
            <asp:Label ID="lblSredstvo" runat="server" Text="lblSredstbo" ForeColor="Red"></asp:Label>
            <br />
            со почетна дестинација<br />
            <asp:Label ID="lblOd" runat="server" Text="lblOd" ForeColor="Red"></asp:Label>
            <br />
            и крајна дестинација<br />
            <asp:Label ID="lblDo" runat="server" Text="lblDo" ForeColor="Red"></asp:Label>
            <br />
            <br />
            Време на поаѓање е<br />
            <asp:Label ID="lblVreme" runat="server" Text="lblVreme" ForeColor="Red"></asp:Label>
            <br />
            <br />
            Вашето место за седење ќе биде во зоната за<br />
            <asp:Label ID="lblZona" runat="server" Text="lblZoma" ForeColor="Red"></asp:Label>
            &nbsp;во
            <asp:Label ID="lblKlasa" runat="server" Text="lblKlasa" ForeColor="Red"></asp:Label>
            &nbsp;класа и во текот на патувањето<br /> ќе бидете послужени со
            <asp:Label ID="lblPosluga" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Image ID="slika" runat="server" Height="121px" Width="429px" />
            <br />
            <br />
            Ви благодариме на довербата и ви посакуваме среќен пат</asp:Panel>
        <asp:Label ID="lblWarning" runat="server"></asp:Label>
    </form>
</body>
</html>
