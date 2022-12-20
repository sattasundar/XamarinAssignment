using Prism.Navigation;

namespace ThreeKTech.ViewModels
{
    public class HelpPageViewModel : ViewModelBase
    {
        public HelpPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Help";
        }
    }
}
