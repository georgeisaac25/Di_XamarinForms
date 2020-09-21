using System;
using CommonServiceLocator;
using DiUsingUnity.Interfaces;
using DiUsingUnity.Services;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;

namespace DiUsingUnity
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();
            // register dependencies
            unityContainer.RegisterType<IProductsService, ProductsService>();
            var unityServiceLocator = new UnityServiceLocator(unityContainer);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

            MainPage = new MainPage();
         
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
