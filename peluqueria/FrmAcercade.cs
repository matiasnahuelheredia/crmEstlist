using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace peluqueria
{
    public partial class FrmAcercade : Form
    {
        public FrmAcercade()
        {
            InitializeComponent();
        }

        private void FrmAcercade_Load(object sender, EventArgs e)
        {
            try
            {
                Txtacerca.Text = Servicio.Servicio_AcercaDe.contratolicencia();
                Lblnumserie.Text = Servicio.Servicio_registro.vernumerolicencia();
            }
            catch (Exception ex)
            {
                Txtacerca.Text = ex.Message;
            }

            
           
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
