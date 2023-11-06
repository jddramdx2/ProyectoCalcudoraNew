using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraProyecto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Funcion para remover un digito ingresado por el usuario al hacer click al boton. Uno a la vez
        protected void btEliminar_click(object sender, EventArgs e)
        {
            string texto = lbMostrarResultado.Text;

            if (texto.Length >= 1)
            {
                lbMostrarResultado.Text = texto.Remove(texto.Length - 1);
            }
        }

        // Función para calcular el factorial de un numero
        private double CalcularFactorial(double numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("No se puede obtener el factorial de numeros menores a 0");
            }

            double factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Función para mostrar el resultado de los datos ingresados por el usuario,es la funcion que se ejecuta al clickear el boton  =
        protected void btMostrarResultado(object sender, EventArgs e)
        {
            try
            {
                string expression = lbMostrarResultado.Text;
                bool expresionCientifica = false;
                // en este if se calcula el factorial del numero ingresado por el usuario
                if (expression.Contains("!"))
                {
                    expresionCientifica = true;
                    int index = expression.IndexOf('!');
                    if (index > 0)
                    {
                        string numero = expression.Substring(0, index);
                        double resultado = CalcularFactorial(Double.Parse(numero));
                        lbMostrarResultado.Text = resultado.ToString();
                    }
                }
                // en este if se calcula la potencia a partir de los numeros ingresados por el usuario
                if (expression.Contains("^"))
                {
                    expresionCientifica = true;
                    string[] arregloNumeros = expression.Split('^');
                    double resultado = Math.Pow(Double.Parse(arregloNumeros[0]), Double.Parse(arregloNumeros[1]));
                    lbMostrarResultado.Text = resultado.ToString();
                }
                // en este if se calcula el logarito en base a 10 del numero ingresado por el usuario
                if (expression.Contains("log("))
                {
                    expresionCientifica = true;
                    string numero = expression.Substring(expression.LastIndexOf('(') + 1);
                    double resultado = Math.Log10(Double.Parse(numero));
                    lbMostrarResultado.Text = resultado.ToString();
                }
                // en este if se calcula la raiz cuadrada del numero ingresado por el usuario
                if (expression.Contains("√"))
                {
                    expresionCientifica = true;
                    string numero = expression.Substring(expression.LastIndexOf('√') + 1);
                    double resultado = Math.Sqrt(Double.Parse(numero));
                    lbMostrarResultado.Text = resultado.ToString();
                }
                // en este if se resuelven las expresiones aritmeticas mas simples usando la propiedad de los DataTable "Compute".
                if (expresionCientifica == false)
                {
                    DataTable table = new DataTable();
                    object result = table.Compute(expression, "");
                    lbMostrarResultado.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                // si algun calculo falla por defecto muestra el siguiente error
                lbMostrarResultado.Text = "Syntax Error";
            }


        }

        // Función para cambiar convertir un numero de positivo a negativo o viseverse
        private double cambiarSigno(double number)
        {
            return -number; // Cambia el signo del numero
        }

        // Funcion Para convertir el numero de positivo a negativo y viseversa, es la funcion que se ejecuta al clickear del boton +/-
        protected void btConversion_click(object sender, EventArgs e)
        {
            try
            {
                string expression = lbMostrarResultado.Text;
                if (expression.Length > 0)
                {
                    bool esNumericoUltimo = char.IsDigit(expression[expression.Length - 1]);
                    if (esNumericoUltimo)
                    {
                        double resultado = cambiarSigno(Double.Parse(expression));
                        lbMostrarResultado.Text = resultado.ToString();
                    }
                }
            }
            catch (Exception)
            {
                // si algun calculo falla por defecto muestra el siguiente error
                lbMostrarResultado.Text = "Syntax Error";
            }

        }
        // Funcion para los botones numericos y el caracter especial "negativo" y la coma. esto porque un numero puede ser negativo y llevar coma
        protected void btNumber_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.CommandName)
            {
                case "number0":
                    lbMostrarResultado.Text += 0;
                    break;
                case "number1":
                    lbMostrarResultado.Text += 1;
                    break;
                case "number2":
                    lbMostrarResultado.Text += 2;
                    break;
                case "number3":
                    lbMostrarResultado.Text += 3;
                    break;
                case "number4":
                    lbMostrarResultado.Text += 4;
                    break;
                case "number5":
                    lbMostrarResultado.Text += 5;
                    break;
                case "number6":
                    lbMostrarResultado.Text += 6;
                    break;
                case "number7":
                    lbMostrarResultado.Text += 7;
                    break;
                case "number8":
                    lbMostrarResultado.Text += 8;
                    break;
                case "number9":
                    lbMostrarResultado.Text += 9;
                    break;
                case "coma":
                    lbMostrarResultado.Text += ".";
                    break;
                case "resta":
                    lbMostrarResultado.Text += "-";
                    break;
            }

        }
        // Funcion que se encarga de eliminar todos los valores ingresados por el usuario. es la funcion que se ejecuta al clickear del boton C
        protected void btC_click(object sender, EventArgs e)
        {
            lbMostrarResultado.Text = string.Empty;
        }
        // metodo que calcula la potencia de un numero. retorna un double
        public double calcularPotencia(double numero)
        {

            return Math.Pow(numero, numero);
        }

        // metodo que permite al usuario agregar las expresiones matematicas o posibles acciones como suma, resta, multiplicacion ... esto según el boton que clickeen
        protected void btAccion_click(object sender, EventArgs e)
        {
            string texto = lbMostrarResultado.Text;
            Button btn = (Button)sender;
            if (texto.Length > 0)
            {
                bool esNumericoUltimo = char.IsDigit(texto[texto.Length - 1]);
                // si el usario ha digitado un numero previamente puede seleccionar una de las siguientes expresiones.
                if (esNumericoUltimo)
                {
                    switch (btn.CommandName)
                    {
                        case "suma":
                            lbMostrarResultado.Text += "+";
                            break;
                        case "multiplicacion":
                            lbMostrarResultado.Text += "*";
                            break;
                        case "division":
                            lbMostrarResultado.Text += "/";
                            break;
                        case "potencia":
                            lbMostrarResultado.Text += "^";
                            break;
                        case "cuadrado_potencia":
                            lbMostrarResultado.Text += "^2";
                            break;
                        case "factorial":
                            lbMostrarResultado.Text += "!";
                            break;

                    }
                }
                else
                {
                    // si el usario no ha digitado un numero previamente igual puede seleccionar una de las siguientes expresiones.
                    switch (btn.CommandName)
                    {
                        case "decima_potencia":
                            lbMostrarResultado.Text += "10^";
                            break;
                        case "raiz_cuadrada":
                            lbMostrarResultado.Text += "√";
                            break;
                        case "logaritmo":
                            lbMostrarResultado.Text += "log(";
                            break;
                    }
                }

            }
            else
            {
                //// si el usario no ha digitado un numero previamente igual puede seleccionar una de las siguientes expresiones.
                switch (btn.CommandName)
                {
                    case "decima_potencia":
                        lbMostrarResultado.Text += "10^";
                        break;
                    case "raiz_cuadrada":
                        lbMostrarResultado.Text += "√";
                        break;
                    case "logaritmo":
                        lbMostrarResultado.Text += "log(";
                        break;
                }
            }


        }


    }
}

        
    


        

       
    
