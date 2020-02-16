using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Masmusculo.Views;

namespace Masmusculo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new NavigationPage(new WaitingViewPage());
            //MainPage = new NavigationPage(new MainViewPage());
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
