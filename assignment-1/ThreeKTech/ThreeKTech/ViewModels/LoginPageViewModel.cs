using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Diagnostics;

namespace ThreeKTech.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        private bool _isPasswordVisibility;
        public bool IsPasswordVisibility
        {
            get { return _isPasswordVisibility; }
            set { SetProperty(ref _isPasswordVisibility, value); }
        }
        IPageDialogService _pageDialogService;
        public DelegateCommand LogInCommand { get; private set; }
        public DelegateCommand SignUpCommand { get; private set; }
        public DelegateCommand ForgotPasswordCommand { get; private set; }
        public DelegateCommand PasswordVisibilityCommand { get; private set; }
        public DelegateCommand NotYouCommand { get; private set; }
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService)
        {
            this._pageDialogService=dialogService;
            this._isPasswordVisibility = true;
            LogInCommand = new DelegateCommand(OnLogIn);
            SignUpCommand = new DelegateCommand(OnSignUp);
            ForgotPasswordCommand = new DelegateCommand(OnForgotPassword);
            PasswordVisibilityCommand = new DelegateCommand(OnPasswordVisibility);
            NotYouCommand = new DelegateCommand(OnNotYouCommand);
        }

        private void OnForgotPassword()
        {
            this._pageDialogService.DisplayAlertAsync("Alert", "Forgot password clicked!", "Ok");
        }

        private void OnSignUp()
        {
            this._pageDialogService.DisplayAlertAsync("Alert", "Sign up clicked!", "Ok");
        }

        private void OnNotYouCommand()
        {
            this._pageDialogService.DisplayAlertAsync("Alert", "Not you clicked!","Ok");
        }

        private void OnPasswordVisibility()
        {
            IsPasswordVisibility = !IsPasswordVisibility;
            Debug.WriteLine(IsPasswordVisibility);
        }

        private async void OnLogIn()
        {
            try
            {
                await NavigationService.NavigateAsync("master");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
