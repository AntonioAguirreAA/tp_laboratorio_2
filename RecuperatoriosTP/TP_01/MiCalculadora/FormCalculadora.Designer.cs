
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.LstOperaciones = new System.Windows.Forms.ListBox();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.CmbOperador = new System.Windows.Forms.ComboBox();
            this.BtnConvertirABinario = new System.Windows.Forms.Button();
            this.BtnConvertirADecimal = new System.Windows.Forms.Button();
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstOperaciones
            // 
            this.LstOperaciones.FormattingEnabled = true;
            this.LstOperaciones.ItemHeight = 15;
            this.LstOperaciones.Location = new System.Drawing.Point(421, 12);
            this.LstOperaciones.Name = "LstOperaciones";
            this.LstOperaciones.Size = new System.Drawing.Size(248, 334);
            this.LstOperaciones.TabIndex = 0;
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumero1.Location = new System.Drawing.Point(34, 145);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(100, 43);
            this.TxtNumero1.TabIndex = 1;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumero2.Location = new System.Drawing.Point(298, 145);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(100, 43);
            this.TxtNumero2.TabIndex = 3;
            // 
            // CmbOperador
            // 
            this.CmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOperador.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbOperador.FormattingEnabled = true;
            this.CmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.CmbOperador.Location = new System.Drawing.Point(156, 145);
            this.CmbOperador.Name = "CmbOperador";
            this.CmbOperador.Size = new System.Drawing.Size(121, 45);
            this.CmbOperador.TabIndex = 2;
            // 
            // BtnConvertirABinario
            // 
            this.BtnConvertirABinario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConvertirABinario.Location = new System.Drawing.Point(22, 283);
            this.BtnConvertirABinario.Name = "BtnConvertirABinario";
            this.BtnConvertirABinario.Size = new System.Drawing.Size(187, 47);
            this.BtnConvertirABinario.TabIndex = 7;
            this.BtnConvertirABinario.Text = "Convertir a Binario";
            this.BtnConvertirABinario.UseVisualStyleBackColor = true;
            this.BtnConvertirABinario.Click += new System.EventHandler(this.BtnConvertirABinario_Click);
            // 
            // BtnConvertirADecimal
            // 
            this.BtnConvertirADecimal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConvertirADecimal.Location = new System.Drawing.Point(222, 283);
            this.BtnConvertirADecimal.Name = "BtnConvertirADecimal";
            this.BtnConvertirADecimal.Size = new System.Drawing.Size(176, 47);
            this.BtnConvertirADecimal.TabIndex = 8;
            this.BtnConvertirADecimal.Text = "Convertir a Decimal";
            this.BtnConvertirADecimal.UseVisualStyleBackColor = true;
            this.BtnConvertirADecimal.Click += new System.EventHandler(this.BtnConvertirADecimal_Click);
            // 
            // BtnOperar
            // 
            this.BtnOperar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOperar.Location = new System.Drawing.Point(23, 220);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(114, 47);
            this.BtnOperar.TabIndex = 4;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpiar.Location = new System.Drawing.Point(156, 220);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(115, 47);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.Location = new System.Drawing.Point(286, 220);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(112, 47);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblResultado.Location = new System.Drawing.Point(23, 67);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblResultado.Size = new System.Drawing.Size(375, 37);
            this.LblResultado.TabIndex = 9;
            this.LblResultado.Text = "label1";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 358);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Controls.Add(this.BtnConvertirADecimal);
            this.Controls.Add(this.BtnConvertirABinario);
            this.Controls.Add(this.CmbOperador);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.LstOperaciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Aguirre Antonio del curso 2° A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstOperaciones;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.ComboBox CmbOperador;
        private System.Windows.Forms.Button BtnConvertirABinario;
        private System.Windows.Forms.Button BtnConvertirADecimal;
        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblResultado;
    }
}