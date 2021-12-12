
namespace FormServicioTecnico
{
    partial class FormListado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.LblServicioTecnico = new System.Windows.Forms.Label();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.lstTrabajosActuales = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarComputadora = new System.Windows.Forms.Button();
            this.btnAgregarCelular = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(12, 455);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(140, 74);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(12, 91);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 74);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(12, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 74);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // LblServicioTecnico
            // 
            this.LblServicioTecnico.AutoSize = true;
            this.LblServicioTecnico.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblServicioTecnico.ForeColor = System.Drawing.Color.White;
            this.LblServicioTecnico.Location = new System.Drawing.Point(12, 9);
            this.LblServicioTecnico.Name = "LblServicioTecnico";
            this.LblServicioTecnico.Size = new System.Drawing.Size(327, 32);
            this.LblServicioTecnico.TabIndex = 6;
            this.LblServicioTecnico.Text = "Servicio Técnico Aguirre";
            // 
            // lstListado
            // 
            this.lstListado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstListado.FormattingEnabled = true;
            this.lstListado.HorizontalScrollbar = true;
            this.lstListado.ItemHeight = 17;
            this.lstListado.Location = new System.Drawing.Point(158, 91);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(1162, 327);
            this.lstListado.TabIndex = 8;
            // 
            // lstTrabajosActuales
            // 
            this.lstTrabajosActuales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTrabajosActuales.FormattingEnabled = true;
            this.lstTrabajosActuales.HorizontalScrollbar = true;
            this.lstTrabajosActuales.ItemHeight = 17;
            this.lstTrabajosActuales.Location = new System.Drawing.Point(158, 461);
            this.lstTrabajosActuales.Name = "lstTrabajosActuales";
            this.lstTrabajosActuales.Size = new System.Drawing.Size(1162, 174);
            this.lstTrabajosActuales.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(158, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trabajos actuales";
            // 
            // btnAgregarComputadora
            // 
            this.btnAgregarComputadora.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarComputadora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarComputadora.ForeColor = System.Drawing.Color.White;
            this.btnAgregarComputadora.Location = new System.Drawing.Point(1326, 91);
            this.btnAgregarComputadora.Name = "btnAgregarComputadora";
            this.btnAgregarComputadora.Size = new System.Drawing.Size(119, 74);
            this.btnAgregarComputadora.TabIndex = 12;
            this.btnAgregarComputadora.Text = "Agregar Computadora";
            this.btnAgregarComputadora.UseVisualStyleBackColor = false;
            this.btnAgregarComputadora.Click += new System.EventHandler(this.btnAgregarComputadora_Click);
            // 
            // btnAgregarCelular
            // 
            this.btnAgregarCelular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarCelular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCelular.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCelular.Location = new System.Drawing.Point(1326, 171);
            this.btnAgregarCelular.Name = "btnAgregarCelular";
            this.btnAgregarCelular.Size = new System.Drawing.Size(119, 74);
            this.btnAgregarCelular.TabIndex = 13;
            this.btnAgregarCelular.Text = "Agregar Celular";
            this.btnAgregarCelular.UseVisualStyleBackColor = false;
            this.btnAgregarCelular.Click += new System.EventHandler(this.btnAgregarCelular_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(12, 535);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(140, 47);
            this.btnImportar.TabIndex = 14;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(12, 588);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(140, 47);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(158, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Todos los trabajos";
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1457, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnAgregarCelular);
            this.Controls.Add(this.btnAgregarComputadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTrabajosActuales);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.LblServicioTecnico);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnProcesar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio Técnico Aguirre";
            this.Load += new System.EventHandler(this.FormListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label LblServicioTecnico;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.ListBox lstTrabajosActuales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarComputadora;
        private System.Windows.Forms.Button btnAgregarCelular;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label2;
    }
}

