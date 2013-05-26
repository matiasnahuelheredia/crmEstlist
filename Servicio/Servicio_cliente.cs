using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;
namespace Servicio
{
    public class Servicio_cliente
    {
        public List<Cliente> getclientesativos()
        {
            Repo_cliente repoclien = new Repo_cliente();
            return repoclien.getclientesactivos();
        }
        public List<Cliente> getclienteactivobycodigo(Cliente clien)
        {
            Repo_cliente repoclien = new Repo_cliente();
            return repoclien.getclienteactivobycodigo(clien);
        }
        public List<Cliente> getclienteactivobynombreyape(Cliente clien)
        {
            Repo_cliente repoclien = new Repo_cliente();
            return repoclien.getpeluqueroactivobynombreyape(clien);
        }
        public bool existecliente(Cliente clien)
        {
            Repo_cliente repoclien = new Repo_cliente();
            return repoclien.existecliente(clien);
        }
        public bool fueborradocliente(Cliente clien)
        {
            Repo_cliente repoclien = new Repo_cliente();
            return repoclien.fueborradocliente(clien);
        }
        public void crearnuevocliente(Cliente clien)
        {
            Repo_cliente repoclien = new Repo_cliente();
            repoclien.crearnuevocliente(clien);


        }
        public void modificarcliente(Cliente clien)
        {
            Repo_cliente repoclien = new Repo_cliente();
            repoclien.modificarcliente(clien);


        }
        public void bajacliente(Cliente peluq)
        {
            Repo_cliente repoclien = new Repo_cliente();
            repoclien.bajacliente(peluq);


        }
    }
}
