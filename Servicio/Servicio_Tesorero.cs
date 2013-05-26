using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;
namespace Servicio
{
    public class Servicio_Tesorero
    {
        public List<Tesorero> getpeluquerosativos()
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            return repotesoreros.get_tesoreros_activos();
        }
        public List<Tesorero> gettesoreroactivobycodigo(Tesorero tesor)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            return repotesoreros.gettesoreroactivobycodigo(tesor);
        }
        public List<Tesorero> gettesoreroactivobynombreyape(Tesorero peluq)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            return repotesoreros.gettesoreroactivobynombreyape(peluq);
        }
        public bool existetesorero(Tesorero tesor)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            return repotesoreros.existetesorero(tesor);
        }
        public bool fueborradopeluquero(Tesorero tesor)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            return repotesoreros.fueborradotesorero(tesor);
        }
        public void crearnuevotesorero(Tesorero tesor)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            repotesoreros.crearnuevotesorero(tesor);


        }
        public void modificartesorero(Tesorero tesor)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            repotesoreros.modificartesorero(tesor);


        }
        public void bajatesorero(Tesorero tesor)
        {
            Repo_Tesoreros repotesoreros = new Repo_Tesoreros();
            repotesoreros.bajatesorero(tesor);


        }
    }
}
