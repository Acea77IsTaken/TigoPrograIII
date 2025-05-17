using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Seleccion_de_Planes_de_tigo.UserControls
{
    /// <summary>
    /// Lógica de interacción para PlanesBase.xaml
    /// </summary>
    public partial class PlanesBase : UserControl
    {
        public PlanesBase()
        {
            InitializeComponent();
        }

        private void Click_PlanB(object sender, MouseButtonEventArgs e)
        {
            App.Navegador.NavegarA(new DetallesB());
        }

        private void Click_PlanM(object sender, MouseButtonEventArgs e)
        {
            App.Navegador.NavegarA(new PlanesM());
        }

        private void Click_PlanA(object sender, MouseButtonEventArgs e)
        {
            App.Navegador.NavegarA(new DetallesA());
        }

        private void Mouse_hover(object sender, MouseEventArgs e)
        {
            Border button = sender as Border;
            button.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF009ECA"));
        }

        private void Mouse_Leave(object sender, MouseEventArgs e)
        {
            Border button = sender as Border;
            button.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00C7FF"));
        }
    }
}
