using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_19bii
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double Valor = 0;
        string Operador;
        string Borrar;
        bool Secuencias;

      

        public Form1()
        {
            InitializeComponent();
        }

        Controlador.clssuma obj1 = new Controlador.clssuma();
        Controlador.clsresta obj2 = new Controlador.clsresta();
        Controlador.clsmultiplicacion obj3 = new Controlador.clsmultiplicacion();
        Controlador.clsdivision obj4 = new Controlador.clsdivision();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        // Al momento de precionar el Button lo hara es imprimir el nombre en la "pantalla"

        private void Btn0_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "4";

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "5";

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "6";

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "7";

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "8";

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "9";

        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + ".";

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Operador = "+";
            primero = double.Parse(tbxPantalla.Text);

            Valor = double.Parse(tbxPantalla.Text);
            Sombra.Text = Valor + " " + Operador;
            Ecuacion.Text = "";

            tbxPantalla.Clear();
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            primero = double.Parse(tbxPantalla.Text);

            Valor = double.Parse(tbxPantalla.Text);
            Sombra.Text = Valor + " " + Operador;
            Ecuacion.Text = "";

            tbxPantalla.Clear();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operador = "*";
            primero = double.Parse(tbxPantalla.Text);

            Valor = double.Parse(tbxPantalla.Text);
            Sombra.Text = Valor + " " + Operador;
            Ecuacion.Text = "";

            tbxPantalla.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            Operador = "/";
            primero = double.Parse(tbxPantalla.Text);

            Valor = double.Parse(tbxPantalla.Text);
            Sombra.Text = Valor + " " + Operador;
            Ecuacion.Text = "";

            tbxPantalla.Clear();
        }

        

        private void BtnIgual_Click(object sender, EventArgs e)
        {

            segundo = double.Parse(tbxPantalla.Text);

            double suma;
            double resta;
            double multi;
            double divi;

            switch (Operador)
            {
                
                case "+":
                suma = obj1.Sumar((primero), (segundo));
                    tbxPantalla.Text = suma.ToString();                  
                    break;

                case "-":
                    resta= obj2.Restar((primero), (segundo));
                    tbxPantalla.Text = resta.ToString();
                    break;

                case "*":
                    multi= obj3.Multiplicacion((primero), (segundo));
                    tbxPantalla.Text =multi.ToString();
                    break;

                case "/":
                    divi = obj4.Division((primero), (segundo));
                    tbxPantalla.Text = divi.ToString();
                    break;

            }
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {
            primero = 0;
            segundo = 0;
            tbxPantalla.Clear();
            tbxPantalla.Focus();
            Sombra.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            int x = 0;
            Borrar = tbxPantalla.Text;
            //x es igual a la longitud de lo que se borrara
            x = Borrar.Length-1;// el -1 es por la funcion de substring que inicia desde 0
            // Lo que hace es cortar un parte de la cadena o variable, es decir terminara en una posicion x


            Borrar = Borrar.Substring(0,x);// Si le doy DEL y no hay ningun valor, se crashea
            tbxPantalla.Text = Borrar;

            if (tbxPantalla.Text == "")
            {
                tbxPantalla.Text = "";
                Secuencias = true;
            }
            if (tbxPantalla.Text == "-")
            {
                tbxPantalla.Text = "";
                Secuencias = true;
            }
        }
    }
}
