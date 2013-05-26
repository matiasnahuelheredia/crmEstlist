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
    public partial class FrmLicencia : Form
    {
        public FrmLicencia()
        {
            InitializeComponent();
        }
        
        private void MtbNumLicencia_TextChanged(object sender, EventArgs e)
        {
            if (MtbNumLicencia.Text.Replace(".", "").Length==20)
            {
                Servicio_registro servreg = new Servicio_registro();
                
                if (Servicio_convertir.stringaulong(MtbNumLicencia.Text.Replace(".", ""))&&servreg.validalicencianoregistrada(Convert.ToUInt64(MtbNumLicencia.Text.Replace(".", ""))))
                {
                    Btnvalidar.BackColor = Color.Green;
                }
                else
                {
                    
                    Btnvalidar.BackColor = Color.Red;
                }

            }
        }

        private void FrmLicencia_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Servicio_registro servreg = new Servicio_registro();
            servreg.registrarlicencia(Convert.ToUInt64(MtbNumLicencia.Text.Replace(".","")));
        }
    }
}
