using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dominio;
namespace Repositorio
{
    public class Repo_Tesoreros
    {
        public List<Tesorero> get_tesoreros_activos()
        {
            DataTable mitabla = new DataTable();

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTable("veracti_tesoreros", conex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Tesorero> Tesoreros = new List<Tesorero>();


            foreach (DataRow row in mitabla.Rows)
            {
                Tesorero mitesorero = new Tesorero();
                mitesorero.dni = Convert.ToInt64(row["codtesorero"]);
                mitesorero.apellido = row["apellido"].ToString();
                mitesorero.nombre = row["nombre"].ToString();
                mitesorero.telefonocelular = row["telefonocelular"].ToString();
                mitesorero.telefonofijo = row["telefonofijo"].ToString();
                mitesorero.direccion = row["direccion"].ToString();

                mitesorero.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);

                Tesoreros.Add(mitesorero);
            }


            return Tesoreros;


        }
        public List<Tesorero> gettesoreroactivobycodigo(Tesorero tesor)
        {
            DataTable mitabla = new DataTable();
            Int64 cod = tesor.dni;
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("gettesorbycod", conex, cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Tesorero> tesoreros = new List<Tesorero>();


            foreach (DataRow row in mitabla.Rows)
            {
                Tesorero mitesorero = new Tesorero();
                mitesorero.dni = Convert.ToInt64(row["codtesorero"]);
                mitesorero.apellido = row["apellido"].ToString();
                mitesorero.nombre = row["nombre"].ToString();
                mitesorero.telefonocelular = row["telefonocelular"].ToString();
                mitesorero.telefonofijo = row["telefonofijo"].ToString();
                mitesorero.direccion = row["direccion"].ToString();
                mitesorero.fechaingreso = Convert.ToDateTime(row["fechadeingreso"]);
                mitesorero.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                mitesorero.horarioentrada = Convert.ToDateTime(row["horarioentrada"]);
                mitesorero.horariosalida = Convert.ToDateTime(row["horariosalida"]);

                tesoreros.Add(mitesorero);
            }


            return tesoreros;


        }
        public List<Tesorero> gettesoreroactivobynombreyape(Tesorero tesor)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;
            string nombre = "%" + tesor.nombre + "%";
            string apellido = "%" + tesor.apellido + "%";

            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("busc_tesor_por_nom_ape", conex, nombre, apellido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Tesorero> Tesoreros = new List<Tesorero>();


            foreach (DataRow row in mitabla.Rows)
            {
                Tesorero mitesorero = new Tesorero();
                mitesorero.dni = Convert.ToInt64(row["codtesorero"]);
                mitesorero.apellido = row["apellido"].ToString();
                mitesorero.nombre = row["nombre"].ToString();
                mitesorero.telefonocelular = row["telefonocelular"].ToString();
                mitesorero.telefonofijo = row["telefonofijo"].ToString();
                mitesorero.direccion = row["direccion"].ToString();
                mitesorero.fechaingreso = Convert.ToDateTime(row["fechadeingreso"]);
                mitesorero.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                mitesorero.horarioentrada = Convert.ToDateTime(row["horarioentrada"]);
                mitesorero.horariosalida = Convert.ToDateTime(row["horariosalida"]);

                Tesoreros.Add(mitesorero);
            }


            return Tesoreros;


        }
        public void crearnuevotesorero(Tesorero tesor)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("crearnuevotesorero", conex, tesor.dni, tesor.nombre, tesor.apellido, tesor.telefonofijo, tesor.telefonocelular, tesor.fechaingreso, tesor.fechanacimiento, tesor.direccion, tesor.horarioentrada, tesor.horariosalida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void modificartesorero(Tesorero tesor)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("modificartesorero", conex, tesor.dni, tesor.nombre, tesor.apellido, tesor.telefonofijo, tesor.telefonocelular, tesor.fechaingreso, tesor.fechanacimiento, tesor.direccion, tesor.horarioentrada, tesor.horariosalida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void bajatesorero(Tesorero tesor)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                con.ejec_afectando_filasSp("bajatesorero", conex, tesor.dni);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public bool fueborradotesorero(Tesorero tesor)
        {
            Int64 cod = tesor.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            object existe;

            try
            {
                conex = con.crear();
                existe = con.TraerValorSp("gettesorerobycodinactivo", conex, cod);
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
        public bool existetesorero(Tesorero tesor)
        {
            Int64 cod = tesor.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            object existe;

            try
            {
                conex = con.crear();
                existe = con.TraerValorSp("gettesorbycod", conex, cod);
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
