using Geolocation.Services;
using Geolocation.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Geolocation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            DependencyService.Register<MockDataStore>();
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
