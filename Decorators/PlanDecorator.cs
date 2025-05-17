using Seleccion_de_Planes_de_tigo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_Planes_de_tigo.Decorators
{
    public abstract class PlanDecorator : Interfaces.Plan
    {
        protected Plan _plan;
        public PlanDecorator(Plan plan)
        {
            this._plan = plan;
        }

        public virtual string NombrePlan()
        {
            return _plan.NombrePlan();
        }
        public virtual double CalcularPrecio()
        {
            return _plan.CalcularPrecio();
        }
    }

}
