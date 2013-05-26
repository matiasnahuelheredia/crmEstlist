using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio;
namespace Servicio
{
    public class Servicio_AcercaDe
    {
        public static string contratolicencia()
        {
           
            Repo_acerca_de repacerca = new Repo_acerca_de();
    
            return repacerca.vercontrato();
            
        }
    }
}
