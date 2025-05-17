using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_Planes_de_tigo.ObjetosConcretos
{
    public class PlanAvanzado : Interfaces.Plan
    {
        public string Nombre;
        public double Precio;
        public int CanalesSD;
        public int CanalesHD;
        public int CanalesMusica;
        public bool TigoSports;
        public int Mbps;
        public PlanAvanzado()
        {
            Nombre = "PLAN FULL TIGO INTERNET 150 MBPS + TV en HD";
            Precio = 500.00;
            CanalesSD = 100;
            CanalesHD = 100;
            CanalesMusica = 71;
            TigoSports = true;
            Mbps = 500;
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
