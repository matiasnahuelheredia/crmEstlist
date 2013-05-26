namespace peluqueria
{
    partial class FrmLicencia
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
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.Lblnumero = new System.Windows.Forms.Label();
            this.MtbNumLicencia = new System.Windows.Forms.MaskedTextBox();
            this.Btnvalidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(368, 16);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(122, 23);
            this.BtnRegistrar.TabIndex = 0;
            this.BtnRegistrar.Text = "Registrar Producto";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // Lblnumero
            // 
            this.Lblnumero.AutoSize = true;
            this.Lblnumero.Location = new System.Drawing.Point(13, 21);
            this.Lblnumero.Name = "Lblnumero";
            this.Lblnumero.Size = new System.Drawing.Size(98, 13);
            this.Lblnumero.TabIndex = 1;
            this.Lblnumero.Text = "Numero de licencia";
            // 
            // MtbNumLicencia
            // 
            this.MtbNumLicencia.Location = new System.Drawing.Point(132, 18);
            this.MtbNumLicencia.Mask = "00,000,000,000,000,000,000";
            this.MtbNumLicencia.Name = "MtbNumLicencia";
            this.MtbNumLicencia.Size = new System.Drawing.Size(147, 20);
            this.MtbNumLicencia.TabIndex = 2;
            this.MtbNumLicencia.TextChanged += new System.EventHandler(this.MtbNumLicencia_TextChanged);
            // 
            // Btnvalidar
            // 
            this.Btnvalidar.Location = new System.Drawing.Point(285, 16);
            this.Btnvalidar.Name = "Btnvalidar";
            this.Btnvalidar.Size = new System.Drawing.Size(26, 23);
            this.Btnvalidar.TabIndex = 4;
            this.Btnvalidar.UseVisualStyleBackColor = true;
            // 
            // FrmLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(this.Btnvalidar);
            this.Controls.Add(this.MtbNumLicencia);
            this.Controls.Add(this.Lblnumero);
            this.Controls.Add(this.BtnRegistrar);
            this.Name = "FrmLicencia";
            this.Text = "Licencia";
            this.Load += new System.EventHandler(this.FrmLicencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label Lblnumero;
        private System.Windows.Forms.MaskedTextBox MtbNumLicencia;
        private System.Windows.Forms.Button Btnvalidar;
    }
}