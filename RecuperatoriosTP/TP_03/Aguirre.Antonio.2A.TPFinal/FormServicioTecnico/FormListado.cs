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
using XML;

namespace FormServicioTecnico
{
    public partial class FormListado : Form
    {
        Listado<Dispositivo> listado;
        List<Dispositivo> listadoFiltrado;
        Serializador<List<Dispositivo>> serializador;

        public FormListado()
        {
            InitializeComponent();
            listado = new Listado<Dispositivo>();
            serializador = new Serializador<List<Dispositivo>>();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            Importar();
            Refrescar();
        }

        private void Refrescar()
        {
            this.lstListado.DataSource = null;
            this.lstTrabajosActuales.DataSource = null;

            listadoFiltrado = Listado<Dispositivo>.Filtrar(listado);

            this.lstListado.DataSource = listado.Lista;
            this.lstTrabajosActuales.DataSource = listadoFiltrado;
        }
        private bool Importar()
        {
            bool retorno = false;
            List<Dispositivo> aux;
            try
            {
                if (serializador.Importar(out aux))
                {
                    listado.Lista = aux;
                    MessageBox.Show("Importado con exito");
                    retorno = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo importar");
            }
            return retorno;
        }
        private void Exportar()
        {
            try
            {
                if(serializador.Exportar(listado.Lista))
                {
                    MessageBox.Show("Backup exitoso");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo exportar");
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Dispositivo dispositivo = this.listadoFiltrado[lstTrabajosActuales.SelectedIndex];
            if(Listado<Dispositivo>.Procesar(dispositivo))
            {
                Refrescar();
            }
        }

        private void btnAgregarComputadora_Click(object sender, EventArgs e)
        {
            FormDispositivo frm = new FormDispositivo(true);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(listado + frm.Computadora)
                {
                    Refrescar();
                    MessageBox.Show("Se agregó correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
        }
        
        private void btnAgregarCelular_Click(object sender, EventArgs e)
        {
            FormDispositivo frm = new FormDispositivo(false);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(listado + frm.Celular)
                {
                    Refrescar();
                    MessageBox.Show("Se agregó correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Dispositivo dispositivo = this.listadoFiltrado[lstListado.SelectedIndex];
            if (listado - dispositivo)
            {
                MessageBox.Show("Se eliminó correctamente");
                Refrescar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dispositivo dispositivo = this.listadoFiltrado[lstListado.SelectedIndex];
            if(dispositivo is Celular)
            {
                FormDispositivo frm = new FormDispositivo((Celular)dispositivo);
                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog() == DialogResult.OK &&
                    listado.Modificar(frm.Celular))
                {
                    Refrescar();
                }
            }
            if (dispositivo is Computadora)
            {
                FormDispositivo frm = new FormDispositivo((Computadora)dispositivo);
                frm.StartPosition = FormStartPosition.CenterScreen;

                if (frm.ShowDialog() == DialogResult.OK &&
                    listado.Modificar(frm.Computadora))
                {
                    dispositivo = frm.Computadora;
                    Refrescar();
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Importar();
            Refrescar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
    }
}
