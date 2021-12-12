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

namespace FormServicioTecnico
{
    public partial class FormDispositivo : Form
    {
        Celular celular;
        Computadora computadora;

        public Celular Celular
        {
            get
            {
                return this.celular;
            }
        }

        public Computadora Computadora
        {
            get
            {
                return this.computadora;
            }
        }

        public FormDispositivo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Si recibe "true" el form generará una computadora, si recibe "false" el form generará un celular
        /// </summary>
        /// <param name="computadora"></param>
        public FormDispositivo(bool computadora) : this()
        {
            if(computadora == true)
            {
                cmbMarca.Visible = false;
                lblMarca.Visible = false;
                this.btnAceptar.Click += new EventHandler(this.Manejador_AgregarComputadora);
            }
            else
            {
                cmbMarca.Visible = true;
                lblMarca.Visible = true;
                this.btnAceptar.Click += new EventHandler(this.Manejador_AgregarCelular);
            }
        }

        public FormDispositivo(Celular celular):this(false)
        {
            txtId.Text = Convert.ToString(celular.Id);
            txtId.Enabled = false;
            txtNombre.Text = celular.NombreDuenio;
            txtObservacion.Text = celular.Observacion;
            txtPrecio.Text = Convert.ToString(celular.Precio);
            dateTimePickerArreglo.Value = celular.ArregloEstimado;
        }

        public FormDispositivo(Computadora computadora):this(true)
        {
            txtId.Text = Convert.ToString(computadora.Id);
            txtId.Enabled = false;
            txtNombre.Text = computadora.NombreDuenio;
            txtObservacion.Text = computadora.Observacion;
            txtPrecio.Text = Convert.ToString(computadora.Precio);
            dateTimePickerArreglo.Value = computadora.ArregloEstimado;
        }

        private void FormDispositivo_Load(object sender, EventArgs e)
        {

        }

        private void Manejador_AgregarComputadora(object sender, EventArgs e)
        {
            if(Computadora.NuevaComputadora(txtId.Text,
                txtNombre.Text
                ,txtObservacion.Text
                ,txtPrecio.Text
                ,dateTimePickerArreglo.Value
                ,out this.computadora))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al generar computadora, revise los campos");
            }
        }

        private void Manejador_AgregarCelular(object sender, EventArgs e)
        {
            Marca marca;
            switch(cmbMarca.Text)
            {
                case "Apple":
                    marca = Marca.Apple;
                    break;
                case "Samsung":
                    marca = Marca.Samsung;
                    break;
                case "Xiaomi":
                    marca = Marca.Xiaomi;
                    break;
                default:
                    marca = default;
                    break;
            }
            if(Celular.NuevoCelular(txtId.Text,
                txtNombre.Text
                ,txtObservacion.Text
                ,txtPrecio.Text
                ,dateTimePickerArreglo.Value
                ,marca,out this.celular))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al generar celular, revise los campos");
            }
        }
    }
}
