using lab11.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab11
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Operacions();
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
