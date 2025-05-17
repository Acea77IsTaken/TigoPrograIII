using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_Planes_de_tigo.ObjetosConcretos
{
    public class PlanMedio : Interfaces.Plan
    {
        public string Nombre;
        public double Precio;
        public int CanalesSD;
        public int CanalesHD;
        public int CanalesMusica;
        public bool TigoSports;
        public int Mbps;
        public PlanMedio()
        {
            Nombre = "PLAN TIGO MEDIO INTERNET 150 MBPS + TV en HD";
            Precio = 255.00;
            CanalesSD = 94;
            CanalesHD = 48;
            CanalesMusica = 50;
            TigoSports = true;
            Mbps = 150;
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
