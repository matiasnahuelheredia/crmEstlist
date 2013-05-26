using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;
namespace Servicio
{
    public class Servicio_peluquero
    {
        public List<Peluquero> getpeluquerosativos()
        {
            Repo_peluquero repopeluq = new Repo_peluquero();
            return repopeluq.getpeluquerosactivos();
        }
        public List<Peluquero> getpeluqueroactivobycodigo(Peluquero peluq)
        {
            Repo_peluquero repopeluq = new Repo_peluquero();
            return repopeluq.getpeluqueroactivobycodigo(peluq);
        }
        public List<Peluquero> getpeluqueroactivobynombreyape(Peluquero peluq)
        {
            Repo_peluquero repopeluq = new Repo_peluquero();
            return repopeluq.getpeluqueroactivobynombreyape(peluq);
        }
        public bool existepeluquero(Peluquero peluq)
        {
            Repo_peluquero repopeluq = new Repo_peluquero();
            return repopeluq.existepeluquero(peluq);
        }
        public bool fueborradopeluquero(Peluquero peluq)
        {
            Repo_peluquero repopeluq = new Repo_peluquero();
            return repopeluq.fueborradopeluquero(peluq);
        }
        public void crearnuevopeluquero(Peluquero peluq)
        {
            Repo_peluquero reppelu = new Repo_peluquero();
            reppelu.crearnuevopeluquero(peluq);


        }
        public void modificarpeluquero(Peluquero peluq)
        {
            Repo_peluquero reppelu = new Repo_peluquero();
            reppelu.modificarpeluquero(peluq);


        }
        public void bajapeluquero(Peluquero peluq)
        {
            Repo_peluquero reppelu = new Repo_peluquero();
            reppelu.bajapeluquero(peluq);


        }
    }
}
