<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculadoraProyecto.WebForm1" %>


<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.0/css/all.min.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style5 {
            height: 24px;
            width: 948px;
        }
        .auto-style6 {
            width: 948px;
        }
        .row-size {
            height: 24px;
            width: 300px !important;
        }
        .fa-icon {
        font-family: 'Font Awesome 5 Free';
        padding: 5px;
        font-weight: 500;
}
        .btn-default {
            font-size: 20px;
            font-weight: 600;
        }
        .lbl-resultado {
            font-size: 30px;
            font-weight: 600;
            vertical-align: bottom;
            border: solid 1px;
            width:500px;
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style3">
                *********Calculadora Proyecto**********</div>
             <div class="auto-style3">

            <table class="auto-style1">
                <tr>  
                      <td class="row-size"> 

                      <br /> 
                      <asp:Label ID="lbMostrarResultado" Width="343px" Height="40px" CssClass="lbl-resultado" runat="server" Text=""></asp:Label>
                      </td>
                </tr>
                <tr>
                    <td class="row-size">
                        <asp:Button ID="btRaiz" runat="server" Text="²√x" Width="64px" Height="48px"  CommandName="raiz_cuadrada" OnClick="btAccion_click" CssClass="btn-default" />
                        <asp:Button ID="btnC" runat="server" Text="C" Width="64px" Height="48px" OnClick="btC_click" CssClass="btn-default"  />
                        <asp:Button ID="btEliminar" runat="server" Width="64px" Height="48px" Text='&#9003;' OnClick="btEliminar_click" CssClass="btn-default fa-icon" /> 
                        <asp:Button ID="btMultiplos" runat="server" Text="n!" Width="64px" Height="48px" CommandName="factorial" OnClick="btAccion_click" CssClass="btn-default"   /> 
                        <asp:Button ID="btDividir" runat="server" Text="&divide;" Width="64px" Height="48px" CommandName="division" OnClick="btAccion_click"  CssClass="btn-default"   />.
                    </td>
                </tr>
                <tr>
                       <td class="row-size">
                         <asp:Button ID="btPotencia" runat="server" Text="x^y" Width="64px" Height="48px" CommandName="potencia" OnClick="btAccion_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber7" runat="server" Text="7" Width="64px" Height="48px" CommandName="number7" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber8" runat="server" Text="8" Width="64px" Height="48px" CommandName="number8" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber9" runat="server" Text="9" Width="64px" Height="48px" CommandName="number9" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btMultiplicar" runat="server" Text="x" Width="64px" Height="48px" CommandName="multiplicacion" OnClick="btAccion_click" CssClass="btn-default"  />
      
 </td>
                </tr>
                <tr>
                   <td class="row-size">
                         <asp:Button ID="btDecimaPotencia" runat="server" Text="10^x" Width="64px" Height="48px" CommandName="decima_potencia" OnClick="btAccion_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber4" runat="server" Text="4" Width="64px" Height="48px" CommandName="number4" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber5" runat="server" Text="5" Width="64px" Height="48px" CommandName="number5" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber6" runat="server" Text="6" Width="64px" Height="48px" CommandName="number6" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btRestar" runat="server" Text="&minus;" Width="64px" Height="48px" CommandName="resta" OnClick="btNumber_click"  CssClass="btn-default" />
 </td>
                </tr>
                <tr>
                   <td class="row-size">
                         <asp:Button ID="btLogaritmo" runat="server" Text="log" Width="64px" Height="48px" CommandName="logaritmo" OnClick="btAccion_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber1" runat="server" Text="1" Width="64px" Height="48px" CommandName="number1" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber2" runat="server" Text="2" Width="64px" Height="48px" CommandName="number2" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber3" runat="server" Text="3" Width="64px" Height="48px" CommandName="number3" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btSuma" runat="server" Text="+" Width="64px" Height="48px" CommandName="suma" OnClick="btAccion_click"  CssClass="btn-default" />  
                 </td>
                </tr>
                <tr>
                 <td class="row-size">
                         <asp:Button ID="btCuadrado" runat="server" Text="x²"  Width="64px" Height="48px" CommandName="cuadrado_potencia"  OnClick="btAccion_click" CssClass="btn-default" />
                         <asp:Button ID="btConversion" runat="server" Text="+/-" Width="64px" Height="48px" OnClick="btConversion_click" CssClass="btn-default" />
                         <asp:Button ID="btNumber0" runat="server" Text="0" Width="64px" Height="48px" CommandName="number0" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btComa" runat="server" Text="," Width="64px" Height="48px" CommandName="coma" OnClick="btNumber_click" CssClass="btn-default" />
                         <asp:Button ID="btResultado" runat="server" Text="=" Width="64px" Height="48px" OnClick="btMostrarResultado" CssClass="btn-default" />
                 </td>
                </tr>
                 <tr>  
                </tr>
            </table>
                 </div>
        </div>
    </form>
</body>
</html>