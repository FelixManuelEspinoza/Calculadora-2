using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Form1 : Form
    {
        string operador;
        double Num1, Num2, resultado;
        public Form1()
        {
            InitializeComponent();
        }
        Boolean ban_btn = true, ban_num = true, ban_ope = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "1";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
            }
            ban_btn = false;
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "0";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }
            ban_btn = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "7";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }
            ban_btn = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "2";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }
            ban_btn = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "3";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }
            ban_btn = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "4";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }
            ban_btn = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "5";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }
            ban_btn = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "6";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }
            ban_btn = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "8";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }
            ban_btn = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ban_num)
            {
                pantalla.Clear();
                pantalla.Text = "9";
                ban_num = false;

            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }
            ban_btn = false;
        }

        private void btnpun_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            ban_num = true;
            ban_ope = true;
            ban_btn = true;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (pantalla.TextLength > 0)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1, 1);
            }

        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operador = "-";

            ban_num = true;


            if (ban_ope)
            {
                Num1 = double.Parse(pantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    Num2 = double.Parse(pantalla.Text);
                    f_switch(operador);
                    Num1 = double.Parse(pantalla.Text);
                    ban_num = true;
                    ban_btn = true;

                }
            }
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            ban_num = true;


            if (ban_ope)
            {
                Num1 = double.Parse(pantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    Num2 = double.Parse(pantalla.Text);
                    f_switch(operador);
                    Num1 = double.Parse(pantalla.Text);
                    ban_num = true;
                    ban_btn = true;

                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            operador = "x";
            ban_num = true;


            if (ban_ope)
            {
                Num1 = double.Parse(pantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    Num2 = double.Parse(pantalla.Text);
                    f_switch(operador);
                    Num1 = double.Parse(pantalla.Text);
                    ban_num = true;
                    ban_btn = true;

                }
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (ban_btn == false)
                if(ban_ope == false)
                {
                    {
                        Num2 = double.Parse(pantalla.Text);
                        f_switch(operador);
                        ban_num = true;
                        ban_btn = true;
                        ban_ope = true;
                    }
            }
         }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            ban_num = true;


            if (ban_ope)
            {
                Num1 = double.Parse(pantalla.Text);
                ban_ope = false;
            }
            else
            {
                if (ban_btn == false)
                {
                    Num2 = double.Parse(pantalla.Text);
                    f_switch(operador);
                    Num1 = double.Parse(pantalla.Text);
                    ban_num = true;
                    ban_btn = true;

                }
            }
        }
        private double f_switch(string operacion)
        {
            switch (operador)
            {
                case "+":
                    resultado = Num1 + Num2;
                    break;
                case "-":
                    resultado = Num1 - Num2;
                    break;
                case "x":
                    resultado = Num1 * Num2;
                    break;
                case "/":
                    resultado = Num1 / Num2;
                    break;
            }
            pantalla.Text = resultado.ToString();
            return resultado;
        }
    }
}
