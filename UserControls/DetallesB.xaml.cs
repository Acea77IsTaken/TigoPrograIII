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
    /// Lógica de interacción para DetallesB.xaml
    /// </summary>
    public partial class DetallesB : UserControl
    {
        public DetallesB()
        {
            InitializeComponent();
        }

        private void Mouse_Hover(object sender, MouseEventArgs e)
        {
            Border button = sender as Border;
            button.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF009ECA"));
        }
        private void Mouse_Leave(object sender, MouseEventArgs e)
        {
            Border button = sender as Border;
            button.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00C7FF"));
        }
    }
}
