using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dominio;

namespace Repositorio
{
    public class Repo_Producto
    {
      
        public List<Producto> getproductosactivos()
        {
            DataTable mitabla = new DataTable();

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("veracti_productos", conex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Producto> Productos = new List<Producto>();


            foreach (DataRow row in mitabla.Rows)
            {
                Producto miproducto = new Producto();
                miproducto.Nombre = row["nombre"].ToString();
                miproducto.Codigo = Convert.ToInt32(row["codprodserv"]);
                miproducto.Descripcion = row["descripcion"].ToString();
                miproducto.Imagen = (byte[])row["imagen"];
                Productos.Add(miproducto);
            }


            return Productos;


        }
        public List<Producto> getproductosporcod(Producto prod)
        {
            DataTable mitabla = new DataTable();

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                mitabla = con.TraerDataTableSp("getproductobycod", conex, prod.Codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            List<Producto> Productos = new List<Producto>();


            foreach (DataRow row in mitabla.Rows)
            {
                Producto miproducto = new Producto();
                miproducto.Nombre = row["nombre"].ToString();
                miproducto.Codigo = Convert.ToInt32(row["codprodser"]);
                miproducto.Descripcion = row["descripcion"].ToString();
                miproducto.Imagen = (byte[])row["imagen"];
                miproducto.Precio = Convert.ToDouble(row["precio"]);
                miproducto.Cantidad = Convert.ToInt32(row["Cantidad"]);
                Productos.Add(miproducto);
            }


            return Productos;


        }
        public void crearproducto(Producto prod)
        {
            

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                con.ejec_afectando_filasSp("altaproducto", conex, prod.Codigo,prod.Precio,prod.Nombre,prod.Descripcion,prod.Imagen,prod.Cantidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void modificarproducto(Producto prod)
        {


            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                con.ejec_afectando_filasSp("modificarproducto", conex, prod.Codigo,prod.Nombre,prod.Descripcion,prod.Imagen,prod.Cantidad,prod.Precio );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public void bajaproducto(Producto prod)
        {


            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                con.ejec_afectando_filasSp("bajaproducto", conex, prod.Codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);



        }
        public bool existeproducto(Producto prod)
        {
            object aca_hay_algo;

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                aca_hay_algo = con.TraerValorSp("getproductobycod", conex, prod.Codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            if (aca_hay_algo == null)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public bool fueborradoproducto(Producto prod)
        {
            object aca_hay_algo;

            coneccion con = new coneccion();
            IDbConnection conex;
            try
            {
                conex = con.crear();
                aca_hay_algo = con.TraerValorSp("verproductobycodinactivo", conex, prod.Codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            con.cerrar(conex);
            if (aca_hay_algo == null)
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
