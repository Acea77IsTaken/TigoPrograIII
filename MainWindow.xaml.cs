using Seleccion_de_Planes_de_tigo.UserControls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Seleccion_de_Planes_de_tigo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool _isSubMenuOpen = false;
        private Storyboard _openAnimation;
        private Storyboard _closeAnimation;
        Color color = (Color)ColorConverter.ConvertFromString("#FF5C5E60");

        string[] NombresBotonesMovil = { "Portabilidad", "Prepago", "Pospago", "Paquetigos", "Roaming" };
        string[] NombresBotonesTelevision = { "Planes", "Premium", "Lista de Canales", "One TV", "Tigo Sports" };

        //Funcion de las animaciones, pueden ignorar
        private void ToggleSubMenu(object sender, RoutedEventArgs e)
        {
            _openAnimation = (Storyboard)FindResource("OpenSubMenu");
            _closeAnimation = (Storyboard)FindResource("CloseSubMenu");
            var button = sender as Label;

            SubMenuContent.Children.Clear();

            // Cargar contenido según el botón
            if (button == BtnMovil)
            {
                for (int i = 0; i < 4; i++)
                {
                    var btn = new Label
                    {
                        Content = NombresBotonesMovil[i],
                        Margin = new Thickness(10),
                        Padding = new Thickness(5,0,5,0),
                        Foreground = new SolidColorBrush(color),
                        FontSize = 16,
                    };
                    SubMenuContent.Children.Add(btn);
                    
                    
                }
            } else if (button == BtnTelevision)
            {
                for (int i = 0; i < 4; i++)
                {
                    var btn = new Label
                    {
                        Content = NombresBotonesTelevision[i],
                        Margin = new Thickness(10),
                        Padding = new Thickness(5, 0, 5, 0),
                        Foreground = new SolidColorBrush(color),
                        FontSize = 16,
                    };
                    SubMenuContent.Children.Add(btn); //suscribo el unico boton que sirve a la funcion
                    if (i == 0)
                    {
                        btn.MouseLeftButtonUp += LlevarAPlanes;
                    }
                }
            }

            // Alternar animación
            if (_isSubMenuOpen)
            {
                _closeAnimation.Begin(SubMenu);
            }
            else
            {
                SubMenu.Height = 0;
                SubMenu.Visibility = Visibility.Visible;
                _openAnimation.Begin(SubMenu);
            }

            _isSubMenuOpen = !_isSubMenuOpen;
        }

        private void LlevarAPlanes(object sender, MouseButtonEventArgs e)
        {
            PlanesBase planesBase = new PlanesBase();
            UserControlMain.Content = planesBase;
            if (_isSubMenuOpen){
            _closeAnimation.Begin(SubMenu);
                _isSubMenuOpen = !_isSubMenuOpen;
            }
        }
    }
}
