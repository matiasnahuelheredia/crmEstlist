namespace peluqueria
{
    partial class Frmproductos
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
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Grbproductos = new System.Windows.Forms.GroupBox();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnimagen = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PbxProducto = new System.Windows.Forms.PictureBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.Lblcantidad = new System.Windows.Forms.Label();
            this.Lblcodigo = new System.Windows.Forms.Label();
            this.Txtcodigoprod = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.Lblprecio = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnBuscarPornombreodescripcion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.Grbproductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(12, 291);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(847, 234);
            this.DgvProductos.TabIndex = 0;
            this.DgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellContentClick);
            // 
            // Grbproductos
            // 
            this.Grbproductos.Controls.Add(this.BtnBuscarPornombreodescripcion);
            this.Grbproductos.Controls.Add(this.Btneliminar);
            this.Grbproductos.Controls.Add(this.Btnimagen);
            this.Grbproductos.Controls.Add(this.BtnGuardar);
            this.Grbproductos.Controls.Add(this.PbxProducto);
            this.Grbproductos.Controls.Add(this.TxtCantidad);
            this.Grbproductos.Controls.Add(this.Lblcantidad);
            this.Grbproductos.Controls.Add(this.Lblcodigo);
            this.Grbproductos.Controls.Add(this.Txtcodigoprod);
            this.Grbproductos.Controls.Add(this.TxtPrecio);
            this.Grbproductos.Controls.Add(this.Lblprecio);
            this.Grbproductos.Controls.Add(this.LblDescripcion);
            this.Grbproductos.Controls.Add(this.TxtDescripcion);
            this.Grbproductos.Controls.Add(this.TxtNombre);
            this.Grbproductos.Controls.Add(this.LblName);
            this.Grbproductos.Location = new System.Drawing.Point(12, 12);
            this.Grbproductos.Name = "Grbproductos";
            this.Grbproductos.Size = new System.Drawing.Size(847, 273);
            this.Grbproductos.TabIndex = 1;
            this.Grbproductos.TabStop = false;
            this.Grbproductos.Text = "Productos";
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(233, 56);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(220, 23);
            this.Btneliminar.TabIndex = 13;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnimagen
            // 
            this.Btnimagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btnimagen.Location = new System.Drawing.Point(549, 235);
            this.Btnimagen.Name = "Btnimagen";
            this.Btnimagen.Size = new System.Drawing.Size(258, 23);
            this.Btnimagen.TabIndex = 12;
            this.Btnimagen.Text = "Agregar imagen al producto";
            this.Btnimagen.UseVisualStyleBackColor = false;
            this.Btnimagen.Click += new System.EventHandler(this.Btnimagen_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(233, 30);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(220, 23);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PbxProducto
            // 
            this.PbxProducto.BackColor = System.Drawing.Color.Gray;
            this.PbxProducto.Location = new System.Drawing.Point(549, 32);
            this.PbxProducto.Name = "PbxProducto";
            this.PbxProducto.Size = new System.Drawing.Size(258, 197);
            this.PbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxProducto.TabIndex = 10;
            this.PbxProducto.TabStop = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(112, 134);
            this.TxtCantidad.MaxLength = 45;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 9;
            // 
            // Lblcantidad
            // 
            this.Lblcantidad.AutoSize = true;
            this.Lblcantidad.Location = new System.Drawing.Point(25, 137);
            this.Lblcantidad.Name = "Lblcantidad";
            this.Lblcantidad.Size = new System.Drawing.Size(83, 13);
            this.Lblcantidad.TabIndex = 8;
            this.Lblcantidad.Text = "Cantidad(Stock)";
            // 
            // Lblcodigo
            // 
            this.Lblcodigo.AutoSize = true;
            this.Lblcodigo.Location = new System.Drawing.Point(62, 35);
            this.Lblcodigo.Name = "Lblcodigo";
            this.Lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.Lblcodigo.TabIndex = 7;
            this.Lblcodigo.Text = "Codigo";
            // 
            // Txtcodigoprod
            // 
            this.Txtcodigoprod.Location = new System.Drawing.Point(112, 32);
            this.Txtcodigoprod.MaxLength = 45;
            this.Txtcodigoprod.Name = "Txtcodigoprod";
            this.Txtcodigoprod.Size = new System.Drawing.Size(100, 20);
            this.Txtcodigoprod.TabIndex = 6;
            this.Txtcodigoprod.TextChanged += new System.EventHandler(this.Txtcodigoprod_TextChanged);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(112, 108);
            this.TxtPrecio.MaxLength = 45;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 5;
            // 
            // Lblprecio
            // 
            this.Lblprecio.AutoSize = true;
            this.Lblprecio.Location = new System.Drawing.Point(65, 111);
            this.Lblprecio.Name = "Lblprecio";
            this.Lblprecio.Size = new System.Drawing.Size(37, 13);
            this.Lblprecio.TabIndex = 4;
            this.Lblprecio.Text = "Precio";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(43, 87);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 3;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(112, 84);
            this.TxtDescripcion.MaxLength = 45;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(112, 58);
            this.TxtNombre.MaxLength = 45;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(58, 61);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre";
            // 
            // BtnBuscarPornombreodescripcion
            // 
            this.BtnBuscarPornombreodescripcion.Location = new System.Drawing.Point(233, 82);
            this.BtnBuscarPornombreodescripcion.Name = "BtnBuscarPornombreodescripcion";
            this.BtnBuscarPornombreodescripcion.Size = new System.Drawing.Size(220, 23);
            this.BtnBuscarPornombreodescripcion.TabIndex = 14;
            this.BtnBuscarPornombreodescripcion.Text = "Buscar producto por nombre o descripcion";
            this.BtnBuscarPornombreodescripcion.UseVisualStyleBackColor = true;
            // 
            // Frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 537);
            this.Controls.Add(this.Grbproductos);
            this.Controls.Add(this.DgvProductos);
            this.Name = "Frmproductos";
            this.Text = "Listado De Productos";
            this.Load += new System.EventHandler(this.Frmproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.Grbproductos.ResumeLayout(false);
            this.Grbproductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.GroupBox Grbproductos;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label Lblprecio;
        private System.Windows.Forms.Label Lblcodigo;
        private System.Windows.Forms.TextBox Txtcodigoprod;
        private System.Windows.Forms.Label Lblcantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.PictureBox PbxProducto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button Btnimagen;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button BtnBuscarPornombreodescripcion;
    }
}