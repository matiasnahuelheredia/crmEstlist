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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void blanquearelformulario()
        {
            
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            Txtdireccion.Text = "";
            MtbTelefono.Text = "";
            Mtbcelular.Text = "";
            DtpNacimiento.Value = DateTime.Now;
            
        }
        private void mostrarenformulario(Cliente clien)
        {
            
            TxtNombre.Text = clien.nombre;
            TxtApellido.Text = clien.apellido;
            Txtdireccion.Text = clien.direccion;
            MtbTelefono.Text = clien.telefonofijo;
            Mtbcelular.Text = clien.telefonocelular;
            DtpNacimiento.Value = clien.fechanacimiento;
            Txtemail.Text = clien.email;

        }
        private void MtbDni_TextChanged(object sender, EventArgs e)
        {
            Servicio_cliente servclien = new Servicio_cliente();
            Cliente clien = new Cliente();
            if (Servicio_convertir.stringaulong(MtbDni.Text.Replace(",", "")) && (MtbDni.Text.Replace(",", "").Length == 8))//sirve para que no convierta algo vacio
            {
                clien.dni = Convert.ToInt64(MtbDni.Text.Replace(",", ""));

                if (servclien.existecliente(clien))
                {
                    clien = servclien.getclienteactivobycodigo(clien)[0];
                    mostrarenformulario(clien);
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
        private void cargarcombocliente()
        {
            CmbNivel.Items.Add("plomo");
            CmbNivel.Items.Add("hierro");
            CmbNivel.Items.Add("bronce");
            CmbNivel.Items.Add("plata");
            CmbNivel.Items.Add("oro");
            
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cargarcombocliente();
        }
        private Cliente pasarformulario()
        {
            Cliente Clien = new Cliente();
            
            Clien.apellido = TxtApellido.Text;
            Clien.direccion = Txtdireccion.Text;
            Clien.nombre = TxtNombre.Text;
            Clien.telefonocelular = Mtbcelular.Text.Replace(",", "");
            Clien.fechanacimiento = DtpNacimiento.Value;
            string Dni = MtbDni.Text.Replace(",", "");
            if (Servicio_convertir.stringaulong(Dni))
            {
                Clien.dni = Convert.ToInt64(Dni);
            }
            Clien.telefonofijo = MtbTelefono.Text.Replace("-", "").Replace("(", "").Replace(")", "");
            Clien.email = Txtemail.Text;
            return Clien;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Servicio_cliente serv_cliente = new Servicio_cliente();
            Cliente clien = new Cliente();
            clien = pasarformulario();
            Dgvcliente.DataSource = serv_cliente.getclienteactivobynombreyape(clien);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Servicio_cliente Servclien = new Servicio_cliente();
            if (Servclien.existecliente(pasarformulario()))
            {
                Servclien.bajacliente(pasarformulario());
                MessageBox.Show("el Cliente ha sido borrado exitosamente");
            }
            else
            {
                if (Servclien.fueborradocliente(pasarformulario()))
                {
                    MessageBox.Show("el Cliente ya ha sido borrado anteriormente");
                }
                else
                {
                    MessageBox.Show("el Cliente Que intenta eliminar no existe");
                }
            }
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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validarformulario())
            {
                Servicio_cliente servclien = new Servicio_cliente();
                if (MtbDni.Text.Replace(",","")!="" && servclien.existecliente(pasarformulario()))
                {
                    try
                    {
                        servclien.modificarcliente(pasarformulario());
                        MessageBox.Show("Se ha modificado cliente exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (servclien.fueborradocliente(pasarformulario()))
                    {
                        try
                        {
                            servclien.modificarcliente(pasarformulario());
                            MessageBox.Show("Se ha modificado exitosamente un cliente que habia sido borrado exitosamente");
                        }                        
                        catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            servclien.crearnuevocliente(pasarformulario());
                            MessageBox.Show("Se ha creado un nuevo cliente exitosamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void Dgvcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection filas = Dgvcliente.SelectedRows;
            MtbDni.Text = filas[0].Cells["dni"].Value.ToString();
        }

    }
}
