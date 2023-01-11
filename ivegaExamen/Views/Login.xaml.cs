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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string password = "uisrael2023";

            if (usuario == txtUsuario.Text && password == txtContraseña.Text)
            {
               Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
            }

        }
    }
}