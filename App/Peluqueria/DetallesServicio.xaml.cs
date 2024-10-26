namespace Peluqueria;

using Microsoft.Maui.ApplicationModel.Communication;
using Peluqueria.Models;
using System.Collections.ObjectModel;
using static Android.Graphics.ColorSpace;

public partial class DetallesServicio : ContentPage
{
    public Servicio detalleServicios { get; set; }
    public DetallesServicio(Servicio detalle)
    {
		InitializeComponent();

        this.detalleServicios = detalle;

        this.BindingContext = this;





    }
}