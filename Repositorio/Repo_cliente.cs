using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dominio;
namespace Repositorio
{
    public class Repo_cliente
    {
        public List<Cliente> getclientesactivos()
        {
            DataTable mitabla = new DataTable();

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTable("veracti_clien", conex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Cliente> Clientes = new List<Cliente>();


            foreach (DataRow row in mitabla.Rows)
            {
                Cliente micliente = new Cliente();
                micliente.dni = Convert.ToInt64(row["codpeluquero"]);
                micliente.apellido = row["apellido"].ToString();
                micliente.nombre = row["nombre"].ToString();
                micliente.telefonocelular = row["telefonocelular"].ToString();
                micliente.telefonofijo = row["telefonofijo"].ToString();
                micliente.direccion = row["direccion"].ToString();
                
                micliente.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                
                Clientes.Add(micliente);
            }


            return Clientes;


        }
        public List<Cliente> getclienteactivobycodigo(Cliente clien)
        {
            DataTable mitabla = new DataTable();
            Int64 cod = clien.dni;
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("getclienbycod", conex, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Cliente> Clientes = new List<Cliente>();


            foreach (DataRow row in mitabla.Rows)
            {
                Cliente micliente = new Cliente();
                micliente.dni = Convert.ToInt64(row["codcliente"]);
                micliente.apellido = row["apellido"].ToString();
                micliente.nombre = row["nombre"].ToString();
                micliente.telefonocelular = row["telefonocelular"].ToString();
                micliente.telefonofijo = row["telefonofijo"].ToString();
                micliente.direccion = row["direccion"].ToString();
                micliente.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                micliente.email = row["mail"].ToString();
                micliente.nivel = Convert.ToInt32(row["nivel"]);
                Clientes.Add(micliente);
            }


            return Clientes;


        }
        public List<Cliente> getpeluqueroactivobynombreyape(Cliente clien)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;
            string nombre = "%" + clien.nombre + "%";
            string apellido = "%" + clien.apellido + "%";

            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("busclienpornomyape", conex, nombre, apellido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Cliente> clientes = new List<Cliente>();


            foreach (DataRow row in mitabla.Rows)
            {
                Cliente micliente = new Cliente();
                micliente.dni = Convert.ToInt64(row["codcliente"]);
                micliente.apellido = row["apellido"].ToString();
                micliente.nombre = row["nombre"].ToString();
                micliente.telefonocelular = row["telefonocelular"].ToString();
                micliente.telefonofijo = row["telefonofijo"].ToString();
                micliente.direccion = row["direccion"].ToString();
                micliente.email = row["mail"].ToString();
                micliente.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                

                clientes.Add(micliente);
            }


            return clientes;


        }
        public void crearnuevocliente(Cliente clien)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("crearnuevocliente", conex, clien.dni, clien.nombre, clien.apellido, clien.telefonofijo, clien.telefonocelular,clien.fechanacimiento, clien.direccion,clien.email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void modificarcliente(Cliente clien)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("modificarcliente", conex, clien.dni, clien.nombre, clien.apellido, clien.telefonofijo, clien.telefonocelular,clien.email, clien.fechanacimiento, clien.direccion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void bajacliente(Cliente clien)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                con.ejec_afectando_filasSp("bajacliente", conex, clien.dni);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public bool fueborradocliente(Cliente clien)
        {
            Int64 cod = clien.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            object existe;

            try
            {
                conex = con.crear();
                existe = con.TraerValorSp("getclienbycodinactivo", conex, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);

            if (existe == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool existecliente(Cliente clien)
        {
            Int64 cod = clien.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            object existe;

            try
            {
                conex = con.crear();
                existe = con.TraerValorSp("getclienbycod", conex, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);

            if (existe == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
