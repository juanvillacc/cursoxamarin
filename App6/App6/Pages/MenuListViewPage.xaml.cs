using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuListViewPage : ContentPage
    {
        public MenuListViewPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PageDataViewModel paginaSeleccionada = (PageDataViewModel)e.SelectedItem;

            Page pagina = (Page)Activator.CreateInstance(paginaSeleccionada.Tipo);
            Application.Current.MainPage = new NavigationPage(pagina);

        }
    }
}