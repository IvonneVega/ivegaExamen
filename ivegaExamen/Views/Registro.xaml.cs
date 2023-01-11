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
    public partial class Registro : ContentPage
    {
        public Registro(string usuarioConectado)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuarioConectado;
        }

        private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
        {
            try
            {
                double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
                double pagoMensual = Convert.ToDouble(0);

                if (montoInicial > Convert.ToDouble(4000))
                {
                    DisplayAlert("Alerta", "El monto inicial no puede ser mayor a 4000", "Cerrar");
                    txtPagoMensual.Text = "";
                    return;
                }
                if (montoInicial <= 0)
                {
                    DisplayAlert("Alerta", "El monto inicial no puede ser menor o igual a 0", "Cerrar");
                    txtPagoMensual.Text = "";
                    return;
                }

                pagoMensual = ((4000 - montoInicial) / 5) + ((4000*5)/100);
                txtPagoMensual.Text = pagoMensual.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");

            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            if (txtPagoMensual.Text == "" || txtPagoMensual.Text == null)
            {
                DisplayAlert("Alerta", "Calcular el Pago Mensual", "Cerrar");
                return;
            }

            DisplayAlert("Notificacion", "Elemento Guardado", "Ok");
            Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, Convert.ToDouble(txtPagoMensual.Text), Convert.ToDouble(txtMontoInicial.Text)));
        }
    }
}