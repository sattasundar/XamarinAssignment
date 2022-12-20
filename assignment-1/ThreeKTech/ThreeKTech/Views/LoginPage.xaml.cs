using Xamarin.Forms;

namespace ThreeKTech.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void OnSelectLanguageClicked(object sender, System.EventArgs e)
        {
            picker.Focus();
        }
    }
}
