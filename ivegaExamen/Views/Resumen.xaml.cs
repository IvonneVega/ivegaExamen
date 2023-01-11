using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ivegaExamen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuarioConectado, string nombreEstudiante, double pagoMensual, double montoInicial)
        {
            InitializeComponent();
            lblUsuario.Text = usuarioConectado;
            txtNombre.Text = nombreEstudiante;
            double totalPagar = (pagoMensual*5)+montoInicial;
            txtTotalPagar.Text = totalPagar.ToString();
        }

        private void btnAcercaDe_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Acerca de", "Aplicacion desarrollada por Ivonne Vega", "Ok");
        }
    }
}