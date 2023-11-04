<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculadoraProyecto.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            height: 24px;
            width: 948px;
        }
        .auto-style6 {
            width: 948px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style3">
                *********Calculadora Proyecto**********</div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <strong>
                        <asp:Label ID="Label1" runat="server" Text="Primer numero"></asp:Label></strong><br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                        <asp:Label ID="Label2" runat="server" Text="Segundo numero"></asp:Label></strong><br />
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                        <asp:Button ID="btSumar" runat="server" Text="+" Width="29px" OnClick="btSumar_Click" />     
                        <asp:Button ID="btRestar" runat="server" Text="-" Width="29px" OnClick="btRestar_Click" />
                        <asp:Button ID="btMultiplicar" runat="server" Text="*" OnClick="btMultiplicar_Click" Width="29px" />
                        <asp:Button ID="btDividir" runat="server" Text="/" Width="29px" OnClick="btDividir_Click"  />.
                        <asp:Button ID="btRaiz" runat="server" Text="²√x" OnClick="btRaiz_Click" />
                        <asp:Button ID="btCuadrado" runat="server" Text="x²" OnClick="btCuadrado_Click" />
                        <br />
                        0 resultado es:<asp:Label ID="lbResultado" runat="server" Text="0"></asp:Label>
                        

                    </td>
                    <td class="auto-style4">
                       
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
