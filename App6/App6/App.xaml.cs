using App6.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EditingTextPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
