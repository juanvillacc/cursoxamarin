using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnCambiarTexto.Clicked += BtnCambiarTexto_Clicked1;
        }

        private void BtnCambiarTexto_Clicked1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCambiarTexto_Clicked(object sender, EventArgs e)
        {
            txtTitle.Text = "Demo acceso elemntos no declarativo";
            btnCambiarTexto.Clicked -= BtnCambiarTexto_Clicked;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            txtTitle.Text = "Demo acceso elemntos";
            /*try
            {
                await Navigation.PushAsync(new HelloXAMLPage());

            }
            catch (Exception ex)
            {           
               Console.WriteLine(ex.Message);
               // throw;
            }*/
        }
    }
}
