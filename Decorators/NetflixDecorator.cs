using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_Planes_de_tigo.Decorators
{
    public class NetflixDecorator : PlanDecorator
    {
        public NetflixDecorator(Interfaces.Plan plan) : base(plan)
        {
        }
        public override string NombrePlan()
        {
            return _plan.NombrePlan() + " + Netflix";
        }
        public override double CalcularPrecio()
        {
            return _plan.CalcularPrecio() + 35.00;
        }
    }
}
