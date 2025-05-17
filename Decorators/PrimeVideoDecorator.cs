using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_Planes_de_tigo.Decorators
{
    public class PrimeVideoDecorator : PlanDecorator
    {
        public PrimeVideoDecorator(Interfaces.Plan plan) : base(plan)
        {
        }
        public override string NombrePlan()
        {
            return _plan.NombrePlan() + " + Prime Video";
        }
        public override double CalcularPrecio()
        {
            return _plan.CalcularPrecio() + 59.00;
        }
    }
}

