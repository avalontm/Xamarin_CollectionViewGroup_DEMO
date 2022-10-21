using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDEMO.Views;

namespace XamarinDEMO
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new DemoSvgPage();
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
