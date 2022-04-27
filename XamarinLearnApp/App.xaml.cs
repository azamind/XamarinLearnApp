using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLearnApp.Services;

namespace XamarinLearnApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<ToDoMockService>();
            MainPage = new AppShell();
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
