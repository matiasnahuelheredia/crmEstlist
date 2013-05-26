using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Servicio;
namespace peluqueria
{
    public partial class Frmestilist : Form
    {
        public Frmestilist()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TssFecha.Text = DateTime.Today.ToLongDateString();
            Servicio_registro servreg = new Servicio_registro();
            if (servreg.validarfechatrial() == false)
            {
                servreg.registrarlicencia(12171746247722944848);
                MessageBox.Show(servreg.validarlicencia().ToString());
            }
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio_registro servreg = new Servicio_registro();
            if (servreg.validarlicencia())
            {
                FrmTesoreros frmtes = new FrmTesoreros();
                frmtes.MdiParent = this;
                frmtes.Show();
            }
            else
            {
                MessageBox.Show("Debe tener una licencia registrada para realizar esta accion");
            }
        }

        private void administrarPeluquerosYEstilistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio_registro servreg = new Servicio_registro();
            if (servreg.validarlicencia())
            {
                Frmpeluqueros peluq = new Frmpeluqueros();
                peluq.MdiParent = this;
                peluq.Show();
            }
            else
            {
                MessageBox.Show("Debe tener una licencia registrada para realizar esta accion");
            }
            
        }

      

        private void aBMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio_registro servreg = new Servicio_registro();
            if (servreg.validarlicencia())
            {
                Frmproductos frmprod = new Frmproductos();
                frmprod.MdiParent = this;
                frmprod.Show();
            }
            else
            {
                MessageBox.Show("Debe tener una licencia registrada para realizar esta accion");
            }
        }

        private void agruparPorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio_registro servreg = new Servicio_registro();
            if (servreg.validarlicencia())
            {
                FrmCliente clie = new FrmCliente();
                clie.MdiParent = this;
                clie.Show();
            }
            else
            {
                MessageBox.Show("Debe tener una licencia registrada para realizar esta accion");
            }
        }

        private void graToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgraf frmgra = new frmgraf();
            frmgra.MdiParent = this;
            frmgra.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion frmfac = new FrmFacturacion();
            frmfac.MdiParent = this;
            frmfac.Show();
        }

        private void acercaDeCRMEstilistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercade frmacerca = new FrmAcercade();
            frmacerca.MdiParent = this;
            frmacerca.Show();
        }

        private void registrarLicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicencia licen = new FrmLicencia();
            licen.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
