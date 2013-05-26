using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Servicio;
using System.IO;
using Dominio;
namespace peluqueria
{
    public partial class Frmproductos : Form
    {
        public Frmproductos()
        {
            InitializeComponent();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void Frmproductos_Load(object sender, EventArgs e)
        {
            Servicio_producto servprod = new Servicio_producto();

            DgvProductos.DataSource = servprod.getproductosactivos();
        }
        private void blanquearformulario()
        {
            TxtNombre.Text = "";
            TxtCantidad.Text = "";
            TxtPrecio.Text = "";
            TxtDescripcion.Text = "";
            PbxProducto.Image = null;

        }
        private void pasarpeluqueroaformulario(Producto prod)
        {
            Servicio_producto servprod = new Servicio_producto();
            
            prod.Codigo = Convert.ToInt32(Txtcodigoprod.Text);
            prod = servprod.getproductobycod(prod);
            TxtNombre.Text = prod.Nombre;
            TxtDescripcion.Text = prod.Descripcion;
            TxtPrecio.Text = prod.Precio.ToString();
            TxtCantidad.Text = prod.Cantidad.ToString();
            PbxProducto.Image = byteArrayToImage(prod.Imagen);
            TxtPrecio.Text = prod.Precio.ToString();
        }
        private Producto pasarformularioaobjeto()
        {
            Producto prod = new Producto();
            prod.Cantidad =Convert.ToInt32(TxtCantidad.Text);
            prod.Codigo = Convert.ToInt32(Txtcodigoprod.Text);
            prod.Descripcion = TxtDescripcion.Text;
            prod.Imagen = imageToByteArray(PbxProducto.Image);
            prod.Nombre = TxtNombre.Text;
            prod.Precio = Convert.ToDouble(TxtPrecio.Text);
            return prod;
            
        }
        private void Txtcodigoprod_TextChanged(object sender, EventArgs e)
        {
            
               
                Servicio_producto servprod = new Servicio_producto();
                Producto prod = new Producto();
                if (Servicio_convertir.stringaint(Txtcodigoprod.Text))
                {
                    prod.Codigo = Convert.ToInt32(Txtcodigoprod.Text);
                    if (servprod.existeproducto(prod))
                    {
                        pasarpeluqueroaformulario(prod);
                    }
                    else
                    {
                        blanquearformulario();
                    }
                }
                else
                {
                    blanquearformulario();
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servicio_producto servprod = new Servicio_producto();
            
            
            if (servprod.existeproducto(pasarformularioaobjeto()))
            {
               
                servprod.modificarproducto(pasarformularioaobjeto());
                MessageBox.Show("se ha modificado el producto correctamente");
            }
            else
            {
                if (servprod.fueborradoproducto(pasarformularioaobjeto()))
                {
                    servprod.modificarproducto(pasarformularioaobjeto());
                    MessageBox.Show("se ha modificado el producto correctamente");
                }
                else
                {
                servprod.altaproducto(pasarformularioaobjeto());
                MessageBox.Show("se ha creado el producto correctamente");
                }

            }
            
        }

        private void Btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
            PbxProducto.ImageLocation = opn.FileName;
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection filas = DgvProductos.SelectedRows;
            Txtcodigoprod.Text = filas[0].Cells["Codigo"].Value.ToString();
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            Servicio_producto servprod = new Servicio_producto();
            Producto prod = new Producto();
            
            if (Servicio_convertir.stringaint(Txtcodigoprod.Text))
            {
                prod.Codigo = Convert.ToInt32(Txtcodigoprod.Text);
                if (servprod.existeproducto(prod))
                {

                    servprod.bajaproducto(prod);
                    MessageBox.Show("Se ha eliminado el producto");
                }
                else
                {
                    if (servprod.fueborradoproducto(prod))
                    {
                        MessageBox.Show("El producto que quiere eliminar ya ha sido eliminado anteriormente");
                    }
                    else
                    {
                        MessageBox.Show("El producto que se quiere eliminar no existe");
                    }
                }
            }
        }
    }
}
