using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numero;
            numero = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text)); //se invoca a la funcion operar para evitar que el programa se rompa
            lblResultado.Text = Operando.DecimalBinario(numero);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        { 
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            string operador = "+";
            string num1 = "0";
            string num2 = "0";

            if(resultado == Double.MinValue)
            {
                lblResultado.Text = "No se puede dividir por 0";
            }
            else
            {
                lblResultado.Text = Convert.ToString(resultado);
                if(cmbOperador.SelectedIndex != -1)
                {
                    operador = cmbOperador.Text; 
                }
                if(txtNumero1.Text != "")
                {
                    num1 = txtNumero1.Text;
                }
                if(txtNumero2.Text != "")
                {
                    num2 = txtNumero2.Text;
                }
                lstOperaciones.Items.Add(num1 + " " + operador + " " + num2 + " = " + resultado);
            }
        }

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = -1;
        }

        /// <summary>
        /// Recibe dos numeros como string y un operador de 1 caracter.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de dicha operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            double resultado;
            char chOperador;

            char.TryParse(operador, out chOperador);

            resultado = Calculadora.Operar(num1, num2, chOperador);

            return resultado;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
