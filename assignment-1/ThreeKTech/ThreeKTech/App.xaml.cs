using Prism;
using Prism.Ioc;
using ThreeKTech.Services;
using ThreeKTech.ViewModels;
using ThreeKTech.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace ThreeKTech
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("master");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            
            containerRegistry.RegisterSingleton<IMockPatientService, MockPatientService>();

            containerRegistry.RegisterForNavigation<NavigationPage>("navpage");
            containerRegistry.RegisterForNavigation<MasterTabbedPage>("master");
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("login");
            containerRegistry.RegisterForNavigation<PatientsPage, PatientsPageViewModel>("patients");
            containerRegistry.RegisterForNavigation<HelpPage, HelpPageViewModel>("help");
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>("menu");

        }
    }
}
