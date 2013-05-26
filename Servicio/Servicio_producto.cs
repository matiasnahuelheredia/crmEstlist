using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;
namespace Servicio
{
    public class Servicio_producto
    {

        public List<Producto> getproductosactivos()
        {
            Repo_Producto repo_prod = new Repo_Producto();
            return repo_prod.getproductosactivos();
        }
        public Producto getproductobycod(Producto prod)
        {
            Repo_Producto repo_prod = new Repo_Producto();
            return repo_prod.getproductosporcod(prod)[0];
        }


        public void bajaproducto(Producto prod)
        {
            Repo_Producto repo_prod = new Repo_Producto();
            repo_prod.bajaproducto(prod);
        }
        public bool existeproducto(Producto prod)
        {
            Repo_Producto repo_prod = new Repo_Producto();
            return repo_prod.existeproducto(prod);
        }
        public bool fueborradoproducto(Producto prod)
        {
            Repo_Producto repo_prod = new Repo_Producto();
            return repo_prod.fueborradoproducto(prod);
        }
        public void altaproducto(Producto prod)
        {
            Repo_Producto repo_prod = new Repo_Producto();
            repo_prod.crearproducto(prod);
        }
        public void modificarproducto(Producto prod)
        {
            Repo_Producto repo_prod = new Repo_Producto();
            repo_prod.modificarproducto(prod);
        }
    }
}
