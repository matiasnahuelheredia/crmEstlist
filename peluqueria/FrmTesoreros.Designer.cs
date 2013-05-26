namespace peluqueria
{
    partial class FrmTesoreros
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Lblfechingreso = new System.Windows.Forms.Label();
            this.Lblfechanacim = new System.Windows.Forms.Label();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Lbltelefonofijo = new System.Windows.Forms.Label();
            this.Mtbcelular = new System.Windows.Forms.MaskedTextBox();
            this.GbxPeluquero = new System.Windows.Forms.GroupBox();
            this.NudHorSalMin = new System.Windows.Forms.NumericUpDown();
            this.NudHorsalHor = new System.Windows.Forms.NumericUpDown();
            this.NudMinEntr = new System.Windows.Forms.NumericUpDown();
            this.NudHorarEntHor = new System.Windows.Forms.NumericUpDown();
            this.Lblhorasalida = new System.Windows.Forms.Label();
            this.Lblhorarioentrada = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Txtdireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Lbldni = new System.Windows.Forms.Label();
            this.MtbDni = new System.Windows.Forms.MaskedTextBox();
            this.Dgvtesoreros = new System.Windows.Forms.DataGridView();
            this.GbxPeluquero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHorSalMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHorsalHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMinEntr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHorarEntHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtesoreros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(515, 46);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 23);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Lblfechingreso
            // 
            this.Lblfechingreso.AutoSize = true;
            this.Lblfechingreso.Location = new System.Drawing.Point(18, 211);
            this.Lblfechingreso.Name = "Lblfechingreso";
            this.Lblfechingreso.Size = new System.Drawing.Size(91, 13);
            this.Lblfechingreso.TabIndex = 16;
            this.Lblfechingreso.Text = "Fecha De ingreso";
            // 
            // Lblfechanacim
            // 
            this.Lblfechanacim.AutoSize = true;
            this.Lblfechanacim.Location = new System.Drawing.Point(14, 182);
            this.Lblfechanacim.Name = "Lblfechanacim";
            this.Lblfechanacim.Size = new System.Drawing.Size(93, 13);
            this.Lblfechanacim.TabIndex = 15;
            this.Lblfechanacim.Text = "Fecha Nacimiento";
            // 
            // DtpNacimiento
            // 
            this.DtpNacimiento.Location = new System.Drawing.Point(115, 179);
            this.DtpNacimiento.Name = "DtpNacimiento";
            this.DtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DtpNacimiento.TabIndex = 12;
            // 
            // Lbltelefonofijo
            // 
            this.Lbltelefonofijo.AutoSize = true;
            this.Lbltelefonofijo.Location = new System.Drawing.Point(38, 129);
            this.Lbltelefonofijo.Name = "Lbltelefonofijo";
            this.Lbltelefonofijo.Size = new System.Drawing.Size(68, 13);
            this.Lbltelefonofijo.TabIndex = 10;
            this.Lbltelefonofijo.Text = "Telefono Fijo";
            // 
            // Mtbcelular
            // 
            this.Mtbcelular.Location = new System.Drawing.Point(117, 152);
            this.Mtbcelular.Mask = "000-000-0000";
            this.Mtbcelular.Name = "Mtbcelular";
            this.Mtbcelular.Size = new System.Drawing.Size(100, 20);
            this.Mtbcelular.TabIndex = 11;
            // 
            // GbxPeluquero
            // 
            this.GbxPeluquero.Controls.Add(this.NudHorSalMin);
            this.GbxPeluquero.Controls.Add(this.NudHorsalHor);
            this.GbxPeluquero.Controls.Add(this.NudMinEntr);
            this.GbxPeluquero.Controls.Add(this.NudHorarEntHor);
            this.GbxPeluquero.Controls.Add(this.Lblhorasalida);
            this.GbxPeluquero.Controls.Add(this.Lblhorarioentrada);
            this.GbxPeluquero.Controls.Add(this.BtnBuscar);
            this.GbxPeluquero.Controls.Add(this.BtnEliminar);
            this.GbxPeluquero.Controls.Add(this.BtnGuardar);
            this.GbxPeluquero.Controls.Add(this.Lblfechingreso);
            this.GbxPeluquero.Controls.Add(this.Lblfechanacim);
            this.GbxPeluquero.Controls.Add(this.DtpIngreso);
            this.GbxPeluquero.Controls.Add(this.DtpNacimiento);
            this.GbxPeluquero.Controls.Add(this.Mtbcelular);
            this.GbxPeluquero.Controls.Add(this.label3);
            this.GbxPeluquero.Controls.Add(this.Lbltelefonofijo);
            this.GbxPeluquero.Controls.Add(this.MtbTelefono);
            this.GbxPeluquero.Controls.Add(this.label2);
            this.GbxPeluquero.Controls.Add(this.label1);
            this.GbxPeluquero.Controls.Add(this.Lblnombre);
            this.GbxPeluquero.Controls.Add(this.Txtdireccion);
            this.GbxPeluquero.Controls.Add(this.TxtApellido);
            this.GbxPeluquero.Controls.Add(this.TxtNombre);
            this.GbxPeluquero.Controls.Add(this.Lbldni);
            this.GbxPeluquero.Controls.Add(this.MtbDni);
            this.GbxPeluquero.Location = new System.Drawing.Point(12, 12);
            this.GbxPeluquero.Name = "GbxPeluquero";
            this.GbxPeluquero.Size = new System.Drawing.Size(730, 238);
            this.GbxPeluquero.TabIndex = 3;
            this.GbxPeluquero.TabStop = false;
            this.GbxPeluquero.Text = "Datos Del Tesorero";
            // 
            // NudHorSalMin
            // 
            this.NudHorSalMin.Location = new System.Drawing.Point(426, 56);
            this.NudHorSalMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudHorSalMin.Name = "NudHorSalMin";
            this.NudHorSalMin.Size = new System.Drawing.Size(41, 20);
            this.NudHorSalMin.TabIndex = 33;
            // 
            // NudHorsalHor
            // 
            this.NudHorsalHor.Location = new System.Drawing.Point(379, 56);
            this.NudHorsalHor.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NudHorsalHor.Name = "NudHorsalHor";
            this.NudHorsalHor.Size = new System.Drawing.Size(41, 20);
            this.NudHorsalHor.TabIndex = 32;
            // 
            // NudMinEntr
            // 
            this.NudMinEntr.Location = new System.Drawing.Point(426, 23);
            this.NudMinEntr.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudMinEntr.Name = "NudMinEntr";
            this.NudMinEntr.Size = new System.Drawing.Size(41, 20);
            this.NudMinEntr.TabIndex = 31;
            // 
            // NudHorarEntHor
            // 
            this.NudHorarEntHor.Location = new System.Drawing.Point(379, 23);
            this.NudHorarEntHor.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NudHorarEntHor.Name = "NudHorarEntHor";
            this.NudHorarEntHor.Size = new System.Drawing.Size(41, 20);
            this.NudHorarEntHor.TabIndex = 30;
            // 
            // Lblhorasalida
            // 
            this.Lblhorasalida.AutoSize = true;
            this.Lblhorasalida.Location = new System.Drawing.Point(275, 59);
            this.Lblhorasalida.Name = "Lblhorasalida";
            this.Lblhorasalida.Size = new System.Drawing.Size(88, 13);
            this.Lblhorasalida.TabIndex = 29;
            this.Lblhorasalida.Text = "Horario de Salida";
            // 
            // Lblhorarioentrada
            // 
            this.Lblhorarioentrada.AutoSize = true;
            this.Lblhorarioentrada.Location = new System.Drawing.Point(275, 26);
            this.Lblhorarioentrada.Name = "Lblhorarioentrada";
            this.Lblhorarioentrada.Size = new System.Drawing.Size(98, 13);
            this.Lblhorarioentrada.TabIndex = 28;
            this.Lblhorarioentrada.Text = "Horario De Entrada";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(515, 77);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(150, 23);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(515, 13);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 23);
            this.BtnGuardar.TabIndex = 21;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DtpIngreso
            // 
            this.DtpIngreso.Location = new System.Drawing.Point(115, 205);
            this.DtpIngreso.Name = "DtpIngreso";
            this.DtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.DtpIngreso.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular";
            // 
            // MtbTelefono
            // 
            this.MtbTelefono.Location = new System.Drawing.Point(117, 126);
            this.MtbTelefono.Mask = "(999)000-0000";
            this.MtbTelefono.Name = "MtbTelefono";
            this.MtbTelefono.Size = new System.Drawing.Size(100, 20);
            this.MtbTelefono.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido";
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Location = new System.Drawing.Point(62, 51);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(44, 13);
            this.Lblnombre.TabIndex = 6;
            this.Lblnombre.Text = "Nombre";
            // 
            // Txtdireccion
            // 
            this.Txtdireccion.Location = new System.Drawing.Point(117, 100);
            this.Txtdireccion.MaxLength = 45;
            this.Txtdireccion.Name = "Txtdireccion";
            this.Txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.Txtdireccion.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(117, 74);
            this.TxtApellido.MaxLength = 45;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(117, 48);
            this.TxtNombre.MaxLength = 45;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // Lbldni
            // 
            this.Lbldni.AutoSize = true;
            this.Lbldni.Location = new System.Drawing.Point(80, 22);
            this.Lbldni.Name = "Lbldni";
            this.Lbldni.Size = new System.Drawing.Size(26, 13);
            this.Lbldni.TabIndex = 1;
            this.Lbldni.Text = "DNI";
            // 
            // MtbDni
            // 
            this.MtbDni.Location = new System.Drawing.Point(117, 19);
            this.MtbDni.Mask = "00.000.000";
            this.MtbDni.Name = "MtbDni";
            this.MtbDni.Size = new System.Drawing.Size(76, 20);
            this.MtbDni.TabIndex = 0;
            this.MtbDni.TextChanged += new System.EventHandler(this.MtbDni_TextChanged);
            // 
            // Dgvtesoreros
            // 
            this.Dgvtesoreros.AllowUserToAddRows = false;
            this.Dgvtesoreros.AllowUserToDeleteRows = false;
            this.Dgvtesoreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvtesoreros.Location = new System.Drawing.Point(18, 269);
            this.Dgvtesoreros.MultiSelect = false;
            this.Dgvtesoreros.Name = "Dgvtesoreros";
            this.Dgvtesoreros.ReadOnly = true;
            this.Dgvtesoreros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvtesoreros.Size = new System.Drawing.Size(724, 197);
            this.Dgvtesoreros.TabIndex = 2;
            this.Dgvtesoreros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvtesoreros_CellClick);
            // 
            // FrmTesoreros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 473);
            this.Controls.Add(this.GbxPeluquero);
            this.Controls.Add(this.Dgvtesoreros);
            this.Name = "FrmTesoreros";
            this.Text = "Alta Baja y Modificacion de Tesoreros";
            this.Load += new System.EventHandler(this.FrmTesoreros_Load);
            this.GbxPeluquero.ResumeLayout(false);
            this.GbxPeluquero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHorSalMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHorsalHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMinEntr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHorarEntHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtesoreros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label Lblfechingreso;
        private System.Windows.Forms.Label Lblfechanacim;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.Label Lbltelefonofijo;
        private System.Windows.Forms.MaskedTextBox Mtbcelular;
        private System.Windows.Forms.GroupBox GbxPeluquero;
        private System.Windows.Forms.NumericUpDown NudHorSalMin;
        private System.Windows.Forms.NumericUpDown NudHorsalHor;
        private System.Windows.Forms.NumericUpDown NudMinEntr;
        private System.Windows.Forms.NumericUpDown NudHorarEntHor;
        private System.Windows.Forms.Label Lblhorasalida;
        private System.Windows.Forms.Label Lblhorarioentrada;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DateTimePicker DtpIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MtbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.TextBox Txtdireccion;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Lbldni;
        private System.Windows.Forms.MaskedTextBox MtbDni;
        private System.Windows.Forms.DataGridView Dgvtesoreros;
    }
}