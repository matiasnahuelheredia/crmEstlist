using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Servicio;
using Dominio;

namespace peluqueria
{
    public partial class FrmTesoreros : Form
    {
        public FrmTesoreros()
        {
            InitializeComponent();
        }
        private bool validarformulario()
        {
            bool valido = true;
            if (TxtNombre.Text == "")
            {
                valido = false;
                MessageBox.Show("el campo nombre esta vacio");
            }
            else
            {
                if (TxtApellido.Text == "")
                {
                    valido = false;
                    MessageBox.Show("el campo Apellido esta vacio");
                }
                else
                {
                    if (Txtdireccion.Text == "")
                    {
                        valido = false;
                        MessageBox.Show("el campo Direccion esta vacio");
                    }
                    else
                    {
                        if (Mtbcelular.Text.Length != 12)
                        {
                            MessageBox.Show("el campo Celular esta vacio o incompleto");
                            valido = false;
                        }
                        else
                        {
                            if (DtpNacimiento.Value >= DateTime.Now)
                            {
                                MessageBox.Show("No ha ingresado una fecha de nacimiento");
                                valido = false;
                            }
                        }
                    }
                }
            }

            return valido;
        }
        private void FrmTesoreros_Load(object sender, EventArgs e)
        {

        }
        public Tesorero pasarformulario()//pasa el contenido del formulario a un objeto peluquero
        {
            Tesorero tesor = new Tesorero();
            tesor.apellido = TxtApellido.Text;
            tesor.direccion = Txtdireccion.Text;
            tesor.nombre = TxtNombre.Text;
            tesor.telefonocelular = Mtbcelular.Text.Replace(",", "");
            tesor.fechaingreso = DtpIngreso.Value;
            tesor.fechanacimiento = DtpNacimiento.Value;
            string horaminuto = "01-01-01 " + NudHorarEntHor.Value.ToString() + ":" + NudMinEntr.Value.ToString() + ":00";
            if (Servicio_convertir.stringadatetime(horaminuto))
            {
                tesor.horarioentrada = Convert.ToDateTime(horaminuto);
            }
            horaminuto = "01-01-01 " + NudHorsalHor.Value.ToString() + ":" + NudHorSalMin.Value.ToString() + ":00";
            if (Servicio_convertir.stringadatetime(horaminuto))
            {
                tesor.horariosalida = Convert.ToDateTime(horaminuto);
            }
            string Dni = MtbDni.Text.Replace(",", "");
            if (Servicio_convertir.stringaulong(Dni))
            {
                tesor.dni = Convert.ToInt64(Dni);
            }
            tesor.telefonofijo = MtbTelefono.Text.Replace("-", "").Replace("(", "").Replace(")", "");
            return tesor;
        }
        private void mostrarenformulario(Tesorero tesor)
        {
            TxtNombre.Text = tesor.nombre;
            TxtApellido.Text = tesor.apellido;
            Txtdireccion.Text = tesor.direccion;
            Mtbcelular.Text = tesor.telefonocelular;
            MtbTelefono.Text = tesor.telefonofijo;
            NudHorarEntHor.Value = tesor.horarioentrada.Hour;
            NudMinEntr.Value = tesor.horarioentrada.Minute;
            NudHorsalHor.Value = tesor.horariosalida.Hour;
            NudHorSalMin.Value = tesor.horariosalida.Minute;

            DtpIngreso.Value = tesor.fechaingreso;
            DtpNacimiento.Value = tesor.fechanacimiento;
        }
        private void blanquearelformulario()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            Txtdireccion.Text = "";
            MtbTelefono.Text = "";
            Mtbcelular.Text = "";
            NudHorarEntHor.Value = 0;
            NudHorsalHor.Value = 0;
            NudHorSalMin.Value = 0;
            NudMinEntr.Value = 0;
            DtpIngreso.Value = DateTime.Now;
            DtpNacimiento.Value = DateTime.Now;


        }

        private void MtbDni_TextChanged(object sender, EventArgs e)
        {
            Servicio_Tesorero servtesor = new Servicio_Tesorero();
            Tesorero tesor = new Tesorero();
            if (Servicio_convertir.stringaulong(MtbDni.Text.Replace(",", "")) && (MtbDni.Text.Replace(",", "").Length == 8))//sirve para que no convierta algo vacio
            {
                tesor.dni = Convert.ToInt64(MtbDni.Text.Replace(",", ""));

                if (servtesor.existetesorero(tesor))
                {
                    tesor = servtesor.gettesoreroactivobycodigo(tesor)[0];
                    mostrarenformulario(tesor);
                }
                else
                {
                    blanquearelformulario();
                }
            }
            else
            {
                blanquearelformulario();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Servicio_Tesorero serv_tesor = new Servicio_Tesorero();
            Tesorero tesor = new Tesorero();
            tesor = pasarformulario();
            Dgvtesoreros.DataSource = serv_tesor.gettesoreroactivobynombreyape(tesor);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Servicio_Tesorero Servtesor = new Servicio_Tesorero();
            if (Servtesor.existetesorero(pasarformulario()))
            {
                Servtesor.bajatesorero(pasarformulario());
                MessageBox.Show("el Tesorero ha sido borrado exitosamente");
            }
            else
            {
                if (Servtesor.fueborradopeluquero(pasarformulario()))
                {
                    MessageBox.Show("el Tesorero ya ha sido borrado anteriormente");
                }
                else
                {
                    MessageBox.Show("el Tesorero Que intenta eliminar no existe");
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (validarformulario())
            {
                Servicio_Tesorero servtesorero = new Servicio_Tesorero();
                if (servtesorero.existetesorero(pasarformulario()))
                {
                    servtesorero.modificartesorero(pasarformulario());
                    MessageBox.Show("El peluquero ha sido modificado correctamente");
                }
                else
                {
                    if (servtesorero.fueborradopeluquero(pasarformulario()))
                    {
                        servtesorero.modificartesorero(pasarformulario());
                        MessageBox.Show("El peluquero ha sido modificado correctamente");
                    }
                    else
                    {
                        servtesorero.crearnuevotesorero(pasarformulario());
                        MessageBox.Show("El peluquero ha sido creado correctamente");
                    }
                }
            }
        }

        private void Dgvtesoreros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection filas = Dgvtesoreros.SelectedRows;
            MtbDni.Text = filas[0].Cells["dni"].Value.ToString();
        }

    }
}
