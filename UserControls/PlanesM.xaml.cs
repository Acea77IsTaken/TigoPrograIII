using Seleccion_de_Planes_de_tigo.Decorators;
using Seleccion_de_Planes_de_tigo.Interfaces;
using Seleccion_de_Planes_de_tigo.ObjetosConcretos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para PlanesM.xaml
    /// </summary>
    public partial class PlanesM : UserControl
    {
        Plan plan;
        public PlanesM()
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

        private void Click_Comprar(object sender, MouseButtonEventArgs e)
        {

        }

        private void Click_Cancel(object sender, MouseButtonEventArgs e)
        {
            App.Navegador.NavegarA(new PlanesBase());
        }


        private void ActualizarPrecio()
        {
            plan = new PlanAvanzado();
            if (RbtnNetflix.IsChecked == true)
            {
                plan = new NetflixDecorator(plan);
            }
            if(RbtnHBO.IsChecked == true)
            {
                plan = new HBODecorator(plan);
            }
            if (RbtnPrimeVideo.IsChecked == true)
            {
                plan = new PrimeVideoDecorator(plan);
            }
            if (RbtnHotPack.IsChecked == true)
            {
                plan = new HotPackDecorator(plan);
            }

            txtPrecio.Text = $"Bs {plan.CalcularPrecio()}.00";
            txtTitulo.Text = $"{plan.NombrePlan()}";
        }

        private void CheckChanged(object sender, RoutedEventArgs e)
        {
            ActualizarPrecio();
        }


        private void Validacion(object sender, TextChangedEventArgs e)
        {
            Regex regex = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            if (!regex.IsMatch(TbxEmail.Text))
            {
                txtemail.Content = "Introduzca un Email Valido";
                txtemail.Foreground = new SolidColorBrush(Colors.Red);
            } else
            {
                txtemail.Content = "Email";
                txtemail.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF787878"));
            }
        }
    }
}
