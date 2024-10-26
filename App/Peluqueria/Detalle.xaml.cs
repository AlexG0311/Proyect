using System.Collections.ObjectModel;
using Peluqueria.Models;



namespace Peluqueria;

public partial class Detalle : ContentPage
{
    public ObservableCollection<Producto> producto_inicio { get; set; }
    public ObservableCollection<Servicio> servicio { get; set; }

    public ObservableCollection<Promocion> promocion { get; set; }
    public Detalle()
	{
		InitializeComponent();

        producto_inicio = new ObservableCollection<Producto>();

        servicio = new ObservableCollection<Servicio>();

        promocion = new ObservableCollection<Promocion>();

        // SERVICIOS

        servicio.Add(new Servicio
        {
            Nombre = "Degradado",
            Imagen = "degradado.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",


        }); ;

        servicio.Add(new Servicio
        {
            Nombre = "Taper",
            Imagen = "corte_peinado.png",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",

        });

        servicio.Add(new Servicio
        {
            Nombre = "Mohicano",
            Imagen = "mohicano.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",

        });

        servicio.Add(new Servicio
        {
            Nombre = "Fade V",
            Imagen = "fade_v.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",

        });

        ColleccionServicio.ItemsSource = servicio;


        // producto_inicio

        producto_inicio.Add(new Producto
        {

            Nombre = "Espuma",
            Imagen = "producto_1.jpg",
             Calificacion = "\u2605\u2605\u2605\u2605\u2606",

        });

        producto_inicio.Add(new Producto
        {

            Nombre = "Espuma",
            Imagen = "producto_2.jpg",
             Calificacion = "\u2605\u2605\u2605\u2605\u2606",
        });


        ProductosInicio.ItemsSource = producto_inicio;


        // PROMOCIONN

        promocion.Add(new Promocion
        {
            Nombre = "Minoxidil",
            Imagen = "producto_3.jpg",
            Calificacion = "\u2605\u2605\u2605\u2606\u2606",

        });

        promocion.Add(new Promocion
        {
            Nombre = "Shampo",
            Imagen = "producto_4jpg.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",

        });

        promocion.Add(new Promocion
        {
            Nombre = "Postquam - Champu de hierbas",
            Imagen = "postquam.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",

        });


        ColleccionPromocion.ItemsSource = promocion;

    }

    private async void OnCartTapped(object sender, EventArgs e)
    {
        // Simula un efecto de "presionado" reduciendo el tamaño y volviendo a su estado original
        await CarritoFrame.ScaleTo(0.9, 100);  // Reducción de tamaño al presionar
        await CarritoFrame.ScaleTo(1, 100);    // Regresa al tamaño original

        // Navega a la página del carrito
        await Navigation.PushAsync(new CarritoPage());
    }

    private async void VerMaServicios(object sender, EventArgs e)
    {
        // Navegar a la página de destino (reemplaza DestinationPage con la página correspondiente)
        await Navigation.PushAsync(new Servicios());
    }

    private async void VerMasProductos(object sender, EventArgs e)
    {
        // Navegar a la página de destino (reemplaza DestinationPage con la página correspondiente)
        await Navigation.PushAsync(new Productos());
    }

    private void IrServicio(object sender, TappedEventArgs e)
    {
        var frame = (Frame)sender;
        var itemSelected = frame.BindingContext as Servicio;

        if (itemSelected != null)
        {
            // Navegar a la página "General" pasando el objeto seleccionado
            NavigationToPage(new DetallesServicio(itemSelected));
        }
    }


    private void NavigationToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = false;
    }
}