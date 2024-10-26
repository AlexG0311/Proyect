using System.Collections.ObjectModel;
using Peluqueria.Models;

namespace Peluqueria
{
    public partial class App : Application
    {

        public static Producto selectedServicio;

        public static ObservableCollection<Producto> ProductosCombos;


        public static FlyoutPage FlyoutPage { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Inicio();
        }
    }
}
