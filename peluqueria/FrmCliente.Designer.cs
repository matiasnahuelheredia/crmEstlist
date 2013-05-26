namespace peluqueria
{
    partial class FrmCliente
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.Dgvcliente = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Lblfechanacim = new System.Windows.Forms.Label();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Mtbcelular = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbltelefonofijo = new System.Windows.Forms.Label();
            this.MtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Txtdireccion = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.GbxClient = new System.Windows.Forms.GroupBox();
            this.Txtemail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.CmbNivel = new System.Windows.Forms.ComboBox();
            this.Lblnivel = new System.Windows.Forms.Label();
            this.Lbldni = new System.Windows.Forms.Label();
            this.MtbDni = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvcliente)).BeginInit();
            this.GbxClient.SuspendLayout();
            this.SuspendLayout();
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
            // Dgvcliente
            // 
            this.Dgvcliente.AllowUserToAddRows = false;
            this.Dgvcliente.AllowUserToDeleteRows = false;
            this.Dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvcliente.Location = new System.Drawing.Point(14, 263);
            this.Dgvcliente.MultiSelect = false;
            this.Dgvcliente.Name = "Dgvcliente";
            this.Dgvcliente.ReadOnly = true;
            this.Dgvcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvcliente.Size = new System.Drawing.Size(724, 197);
            this.Dgvcliente.TabIndex = 2;
            this.Dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcliente_CellContentClick);
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
            // Mtbcelular
            // 
            this.Mtbcelular.Location = new System.Drawing.Point(117, 152);
            this.Mtbcelular.Mask = "000-000-0000";
            this.Mtbcelular.Name = "Mtbcelular";
            this.Mtbcelular.Size = new System.Drawing.Size(100, 20);
            this.Mtbcelular.TabIndex = 11;
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
            // Lbltelefonofijo
            // 
            this.Lbltelefonofijo.AutoSize = true;
            this.Lbltelefonofijo.Location = new System.Drawing.Point(38, 129);
            this.Lbltelefonofijo.Name = "Lbltelefonofijo";
            this.Lbltelefonofijo.Size = new System.Drawing.Size(68, 13);
            this.Lbltelefonofijo.TabIndex = 10;
            this.Lbltelefonofijo.Text = "Telefono Fijo";
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
            // GbxClient
            // 
            this.GbxClient.Controls.Add(this.Txtemail);
            this.GbxClient.Controls.Add(this.lblMail);
            this.GbxClient.Controls.Add(this.CmbNivel);
            this.GbxClient.Controls.Add(this.Lblnivel);
            this.GbxClient.Controls.Add(this.BtnBuscar);
            this.GbxClient.Controls.Add(this.BtnEliminar);
            this.GbxClient.Controls.Add(this.BtnGuardar);
            this.GbxClient.Controls.Add(this.Lblfechanacim);
            this.GbxClient.Controls.Add(this.DtpNacimiento);
            this.GbxClient.Controls.Add(this.Mtbcelular);
            this.GbxClient.Controls.Add(this.label3);
            this.GbxClient.Controls.Add(this.Lbltelefonofijo);
            this.GbxClient.Controls.Add(this.MtbTelefono);
            this.GbxClient.Controls.Add(this.label2);
            this.GbxClient.Controls.Add(this.label1);
            this.GbxClient.Controls.Add(this.Lblnombre);
            this.GbxClient.Controls.Add(this.Txtdireccion);
            this.GbxClient.Controls.Add(this.TxtApellido);
            this.GbxClient.Controls.Add(this.TxtNombre);
            this.GbxClient.Controls.Add(this.Lbldni);
            this.GbxClient.Controls.Add(this.MtbDni);
            this.GbxClient.Location = new System.Drawing.Point(8, 6);
            this.GbxClient.Name = "GbxClient";
            this.GbxClient.Size = new System.Drawing.Size(730, 238);
            this.GbxClient.TabIndex = 3;
            this.GbxClient.TabStop = false;
            this.GbxClient.Text = "Datos Del Cliente";
            // 
            // Txtemail
            // 
            this.Txtemail.Location = new System.Drawing.Point(368, 49);
            this.Txtemail.Name = "Txtemail";
            this.Txtemail.Size = new System.Drawing.Size(100, 20);
            this.Txtemail.TabIndex = 31;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(329, 52);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 30;
            this.lblMail.Text = "E-Mail";
            // 
            // CmbNivel
            // 
            this.CmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNivel.FormattingEnabled = true;
            this.CmbNivel.Location = new System.Drawing.Point(368, 19);
            this.CmbNivel.Name = "CmbNivel";
            this.CmbNivel.Size = new System.Drawing.Size(121, 21);
            this.CmbNivel.TabIndex = 29;
            // 
            // Lblnivel
            // 
            this.Lblnivel.AutoSize = true;
            this.Lblnivel.Location = new System.Drawing.Point(334, 22);
            this.Lblnivel.Name = "Lblnivel";
            this.Lblnivel.Size = new System.Drawing.Size(31, 13);
            this.Lblnivel.TabIndex = 28;
            this.Lblnivel.Text = "Nivel";
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
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.Dgvcliente);
            this.Controls.Add(this.GbxClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Alta  Baja y Modificacion de Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvcliente)).EndInit();
            this.GbxClient.ResumeLayout(false);
            this.GbxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView Dgvcliente;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label Lblfechanacim;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.MaskedTextBox Mtbcelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbltelefonofijo;
        private System.Windows.Forms.MaskedTextBox MtbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.TextBox Txtdireccion;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox GbxClient;
        private System.Windows.Forms.Label Lbldni;
        private System.Windows.Forms.MaskedTextBox MtbDni;
        private System.Windows.Forms.Label Lblnivel;
        private System.Windows.Forms.ComboBox CmbNivel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox Txtemail;

    }
}