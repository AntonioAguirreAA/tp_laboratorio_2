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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Imprime el resultado en el labal y la operacoión en el lstBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Operando n1 = new Operando();
            Operando n2 = new Operando();
            n1.Numero = TxtNumero1.Text;
            n2.Numero = TxtNumero2.Text;
            double resultado = Calculadora.Operar(n1, n2, Convert.ToChar(CmbOperador.Text));
            LblResultado.Text = Convert.ToString(resultado);
            string cadenaList = TxtNumero1.Text + " " + CmbOperador.Text + " " + TxtNumero2.Text + " = " + resultado;
            LstOperaciones.Items.Add(cadenaList);
        }

        /// <summary>
        /// Limpia todos los textos del formulario
        /// </summary>
        private void Limpiar()
        {
            TxtNumero1.Text = "";
            TxtNumero2.Text = "";
            CmbOperador.Text = "";
            LblResultado.Text = "";
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Operando.DecimalBinario(LblResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            LblResultado.Text = Operando.BinarioDecimal(LblResultado.Text);

        }
    }
}
