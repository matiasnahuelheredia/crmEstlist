using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dominio;
namespace Repositorio
{
    public class Repo_peluquero
    {
        public List<Peluquero> getpeluquerosactivos()
        {
            DataTable mitabla = new DataTable();

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("veracti_peluquero", conex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Peluquero> Peluqueros = new List<Peluquero>();


            foreach (DataRow row in mitabla.Rows)
            {
                Peluquero mipeluquero = new Peluquero();
                mipeluquero.dni = Convert.ToInt64(row["codpeluquero"]);
                mipeluquero.apellido = row["apellido"].ToString();
                mipeluquero.nombre = row["nombre"].ToString();
                mipeluquero.telefonocelular = row["telefonocelular"].ToString();
                mipeluquero.telefonofijo = row["telefonofijo"].ToString();
                mipeluquero.direccion = row["direccion"].ToString();
                mipeluquero.fechaingreso = Convert.ToDateTime(row["fechadeingreso"]);
                mipeluquero.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                mipeluquero.horarioentrada = Convert.ToDateTime(row["horarioentrada"]);
                mipeluquero.horariosalida = Convert.ToDateTime(row["horariosalida"]);
               
                Peluqueros.Add(mipeluquero);
            }


            return Peluqueros;

            
        }
        public List<Peluquero> getpeluqueroactivobycodigo(Peluquero peluq)
        {
            DataTable mitabla = new DataTable();
            Int64 cod= peluq.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            
            
            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("getpeluqbycod", conex,cod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Peluquero> Peluqueros = new List<Peluquero>();


            foreach (DataRow row in mitabla.Rows)
            {
                Peluquero mipeluquero = new Peluquero();
                mipeluquero.dni = Convert.ToInt64(row["codpeluquero"]);
                mipeluquero.apellido = row["apellido"].ToString();
                mipeluquero.nombre = row["nombre"].ToString();
                mipeluquero.telefonocelular = row["telefonocelular"].ToString();
                mipeluquero.telefonofijo = row["telefonofijo"].ToString();
                mipeluquero.direccion = row["direccion"].ToString();
                mipeluquero.fechaingreso = Convert.ToDateTime(row["fechadeingreso"]);
                mipeluquero.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                mipeluquero.horarioentrada = Convert.ToDateTime(row["horarioentrada"]);
                mipeluquero.horariosalida = Convert.ToDateTime(row["horariosalida"]);

                Peluqueros.Add(mipeluquero);
            }


            return Peluqueros;


        }
        public List<Peluquero> getpeluqueroactivobynombreyape(Peluquero peluq)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;
            string nombre = "%" + peluq.nombre + "%";
            string apellido = "%" + peluq.apellido + "%";

            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("buspelpornomyape", conex, nombre,apellido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Peluquero> Peluqueros = new List<Peluquero>();


            foreach (DataRow row in mitabla.Rows)
            {
                Peluquero mipeluquero = new Peluquero();
                mipeluquero.dni = Convert.ToInt64(row["codpeluquero"]);
                mipeluquero.apellido = row["apellido"].ToString();
                mipeluquero.nombre = row["nombre"].ToString();
                mipeluquero.telefonocelular = row["telefonocelular"].ToString();
                mipeluquero.telefonofijo = row["telefonofijo"].ToString();
                mipeluquero.direccion = row["direccion"].ToString();
                mipeluquero.fechaingreso = Convert.ToDateTime(row["fechadeingreso"]);
                mipeluquero.fechanacimiento = Convert.ToDateTime(row["fechanacimiento"]);
                mipeluquero.horarioentrada = Convert.ToDateTime(row["horarioentrada"]);
                mipeluquero.horariosalida = Convert.ToDateTime(row["horariosalida"]);

                Peluqueros.Add(mipeluquero);
            }


            return Peluqueros;


        }
        public void crearnuevopeluquero(Peluquero peluq)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;
            

            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("crearnuevopeluquero", conex, peluq.dni, peluq.nombre, peluq.apellido, peluq.telefonofijo, peluq.telefonocelular, peluq.fechaingreso,peluq.fechanacimiento, peluq.direccion, peluq.horarioentrada, peluq.horariosalida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void modificarpeluquero(Peluquero peluq)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("modificarpeluquero", conex, peluq.dni, peluq.nombre, peluq.apellido, peluq.telefonofijo, peluq.telefonocelular, peluq.fechaingreso, peluq.fechanacimiento, peluq.direccion, peluq.horarioentrada, peluq.horariosalida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void bajapeluquero(Peluquero peluq)
        {
            DataTable mitabla = new DataTable();
            coneccion con = new coneccion();
            IDbConnection conex;


            try
            {
                conex = con.crear();
                con.ejec_afectando_filasSp("bajapeluquero", conex, peluq.dni);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public bool fueborradopeluquero(Peluquero pelu)
        {
            Int64 cod = pelu.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            object existe;

            try
            {
                conex = con.crear();
                existe = con.TraerValorSp("getpeluqbycodinactivo", conex, cod);
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
        public bool existepeluquero(Peluquero pelu)
        {
            Int64 cod = pelu.dni;
            coneccion con = new coneccion();
            IDbConnection conex;
            object existe;

            try
            {
                conex = con.crear();
                existe = con.TraerValorSp("getpeluqbycod", conex, cod);
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
