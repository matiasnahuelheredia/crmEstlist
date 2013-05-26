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
    public partial class Frmpeluqueros : Form
    {
        public Frmpeluqueros()
        {
            InitializeComponent();
        }

        private bool validarformulario()
        {
            bool valido=true;
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
        private void Peluqueros_Load(object sender, EventArgs e)
        {
            
        }

        public Peluquero pasarformulario()//pasa el contenido del formulario a un objeto peluquero
        {
            Peluquero peluq = new Peluquero();
            peluq.apellido = TxtApellido.Text;
            peluq.direccion = Txtdireccion.Text;
            peluq.nombre = TxtNombre.Text;
            peluq.telefonocelular = Mtbcelular.Text.Replace(",", "");
            peluq.fechaingreso = DtpIngreso.Value;
            peluq.fechanacimiento = DtpNacimiento.Value;
            string horaminuto="01-01-01 " + NudHorarEntHor.Value.ToString() + ":" + NudMinEntr.Value.ToString() + ":00";
            if (Servicio_convertir.stringadatetime(horaminuto))
            {peluq.horarioentrada = Convert.ToDateTime(horaminuto);
            }
            horaminuto = "01-01-01 " + NudHorsalHor.Value.ToString() + ":" + NudHorSalMin.Value.ToString() + ":00";
            if (Servicio_convertir.stringadatetime(horaminuto))
            {
                peluq.horariosalida = Convert.ToDateTime(horaminuto);
            }
            string Dni = MtbDni.Text.Replace(",", "");
            if (Servicio_convertir.stringaulong(Dni))
            {
                peluq.dni = Convert.ToInt64(Dni);
            }
            peluq.telefonofijo = MtbTelefono.Text.Replace("-", "").Replace("(","").Replace(")","");
            return peluq;
        }
        private void mostrarenformulario(Peluquero peluquero)
        {
            TxtNombre.Text = peluquero.nombre;
            TxtApellido.Text = peluquero.apellido;
            Txtdireccion.Text = peluquero.direccion;
            Mtbcelular.Text = peluquero.telefonocelular;
            MtbTelefono.Text = peluquero.telefonofijo;
            NudHorarEntHor.Value = peluquero.horarioentrada.Hour;
            NudMinEntr.Value = peluquero.horarioentrada.Minute;
            NudHorsalHor.Value = peluquero.horariosalida.Hour;
            NudHorSalMin.Value = peluquero.horariosalida.Minute;
            
            DtpIngreso.Value = peluquero.fechaingreso;
            DtpNacimiento.Value = peluquero.fechanacimiento;
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
            Servicio_peluquero servpeluq = new Servicio_peluquero();
            Peluquero peluq = new Peluquero();
            if (Servicio_convertir.stringaulong(MtbDni.Text.Replace(",", "")) && (MtbDni.Text.Replace(",", "").Length==8))//sirve para que no convierta algo vacio
            {
                peluq.dni = Convert.ToInt64(MtbDni.Text.Replace(",", ""));
                
                if (servpeluq.existepeluquero(peluq))
                {
                    peluq = servpeluq.getpeluqueroactivobycodigo(peluq)[0];
                    mostrarenformulario(peluq);
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

        private void GbxPeluquero_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Servicio_peluquero serv_peluq = new Servicio_peluquero();
            Peluquero peluq = new Peluquero();
            peluq = pasarformulario();
            Dgvpeluqueros.DataSource = serv_peluq.getpeluqueroactivobynombreyape(peluq);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Servicio_peluquero Servpeluq = new Servicio_peluquero();
            if (Servpeluq.existepeluquero(pasarformulario()))
            {
                Servpeluq.bajapeluquero(pasarformulario());
                MessageBox.Show("el Peluquero ha sido borrado exitosamente");
            }
            else
            {
                if (Servpeluq.fueborradopeluquero(pasarformulario()))
                {
                    MessageBox.Show("el Peluquero ya ha sido borrado anteriormente");
                }
                else
                {
                    MessageBox.Show("el Peluquero Que intenta eliminar no existe");
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validarformulario())
            {
                Servicio_peluquero servpeluq = new Servicio_peluquero();
                if (servpeluq.existepeluquero(pasarformulario()))
                {
                    servpeluq.modificarpeluquero(pasarformulario());
                }
                else
                {
                    if (servpeluq.fueborradopeluquero(pasarformulario()))
                    {
                        servpeluq.modificarpeluquero(pasarformulario());
                    }
                    else
                    {
                        servpeluq.crearnuevopeluquero(pasarformulario());
                    }
                }
            }
        }

        private void Dgvpeluqueros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection filas = Dgvpeluqueros.SelectedRows;
            MtbDni.Text = filas[0].Cells["dni"].Value.ToString();
            
            
        }

    }
}
