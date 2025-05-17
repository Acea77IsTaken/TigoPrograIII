using Seleccion_de_Planes_de_tigo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_Planes_de_tigo.ObjetosConcretos
{
    public class PlanBasico : Interfaces.Plan
    {
        public string Nombre;
        public double Precio;
        public int CanalesSD;
        public int CanalesHD;
        public int CanalesMusica;
        public bool TigoSports;
        public int Mbps;
        public PlanBasico()
        {
            Nombre = "PLAN TIGO INICIAL INTERNET 100 MBPS + TV en HD";
            Precio = 215.00;
            CanalesSD = 42;
            CanalesHD = 24;
            CanalesMusica = 10;
            TigoSports = true;
            Mbps = 100;
        }
        public string NombrePlan()
        {
           return Nombre;
        }
        public double CalcularPrecio()
        {
            return Precio;
        }
    }

}
