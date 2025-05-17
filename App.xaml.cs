using Seleccion_de_Planes_de_tigo.Singletons;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Seleccion_de_Planes_de_tigo
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Navegacion Navegador { get; } = new Navegacion();
    }
}
