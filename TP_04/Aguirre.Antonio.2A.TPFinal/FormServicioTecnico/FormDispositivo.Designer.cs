
namespace FormServicioTecnico
{
    partial class FormDispositivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.dateTimePickerArreglo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(12, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 29);
            this.txtId.TabIndex = 0;
            // 
            // dateTimePickerArreglo
            // 
            this.dateTimePickerArreglo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerArreglo.Location = new System.Drawing.Point(12, 372);
            this.dateTimePickerArreglo.Name = "dateTimePickerArreglo";
            this.dateTimePickerArreglo.Size = new System.Drawing.Size(359, 29);
            this.dateTimePickerArreglo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del dueño";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(12, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 29);
            this.txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(37, 186);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(334, 29);
            this.txtPrecio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(12, 244);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(359, 96);
            this.txtObservacion.TabIndex = 13;
            this.txtObservacion.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha estimada de arreglo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(12, 408);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 21);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Xiaomi"});
            this.cmbMarca.Location = new System.Drawing.Point(12, 432);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 29);
            this.cmbMarca.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAceptar.Location = new System.Drawing.Point(278, 417);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 43);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // FormDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(383, 474);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerArreglo);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDispositivo";
            this.Text = "FormDispositivo";
            this.Load += new System.EventHandler(this.FormDispositivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dateTimePickerArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnAceptar;
    }
}