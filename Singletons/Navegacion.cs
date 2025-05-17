using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Seleccion_de_Planes_de_tigo.Singletons
{
    public class Navegacion
    {
        public event Action<UserControl> VistaCambiada;

        public void NavegarA(UserControl nuevaVista)
        {
            VistaCambiada?.Invoke(nuevaVista);
        }
    }
}
