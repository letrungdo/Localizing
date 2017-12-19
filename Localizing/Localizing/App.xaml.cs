using Localizing.ViewModels;
using Localizing.Views;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Localizing
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //
            //// This lookup NOT required for Windows platforms - the Culture will be automatically set
            //if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
            //{
            //    // determine the correct, supported .NET culture
            //    var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            //    Resx.AppResources.Culture = ci; // set the RESX for resource localization
            //    DependencyService.Get<ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
            //}
            //

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
