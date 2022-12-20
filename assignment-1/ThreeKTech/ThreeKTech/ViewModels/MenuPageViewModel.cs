using Prism.Navigation;

namespace ThreeKTech.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public MenuPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Menu";
        }
    }
}
