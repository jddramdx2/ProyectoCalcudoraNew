using System;
using System.Collections.Generic;
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

        protected void btMultiplicar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = (float.Parse(TextBox1.Text) * float.Parse(TextBox2.Text)).ToString();
        }

        protected void btSumar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = (float.Parse(TextBox1.Text) + float.Parse(TextBox2.Text)).ToString();
        }

        protected void btRestar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = (float.Parse(TextBox1.Text) - float.Parse(TextBox2.Text)).ToString();
        }

        protected void btDividir_Click(object sender, EventArgs e)
        {
            lbResultado.Text = (float.Parse(TextBox1.Text) / float.Parse(TextBox2.Text)).ToString();
        }

        protected void btRaiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                double numero = double.Parse(TextBox1.Text);
                if (numero >= 0)
                {
                    double resultado = Math.Sqrt(numero);
                    lbResultado.Text = resultado.ToString();
                }
                else
                {
                    lbResultado.Text = "Error: No se puede calcular la raíz cuadrada de un número negativo.";
                }
            }
            else
            {
                lbResultado.Text = "Ingrese un número válido.";
            }

        }

        protected void btCuadrado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                double numero = double.Parse(TextBox1.Text);
                double resultado = CalcularCuadrado(numero);
                lbResultado.Text = resultado.ToString();
            }
            else
            {
                lbResultado.Text = "Ingrese un número válido.";
            }
        }

        // Función para calcular el cuadrado de un número
        private double CalcularCuadrado(double numero)
        {
            return numero * numero;
        }
    }
    }

        
    


        

       
    
