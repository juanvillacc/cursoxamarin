using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App6.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PresentationControlsPage : ContentPage
    {
        public PresentationControlsPage()
        {
            InitializeComponent();

            //ConfigurarMap();

            //MostrarBoxVIew();
        }

        void ConfigurarMap()
        {
            /*this.maps = new Xamarin.Forms.Maps.Map(
                MapSpan.FromCenterAndRadius( 
                    new Position(4.652390050274889, -74.10369634315376),
                    Distance.FromKilometers(10)
                ));*/
        }
        private void MostrarBoxVIew()
        {
            BoxView box = new BoxView
            {
                Color = Color.Magenta,   
                HeightRequest = 150,
                WidthRequest = 150,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,  
            };

            Label label = new Label
            {
                Text = "Encabezado"
            };

            this.Content = new StackLayout
            {
                Children = {
                    label,
                    box
                }
            }; 

        }
    }
}