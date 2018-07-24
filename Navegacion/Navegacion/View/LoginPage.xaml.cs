
using Navegacion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion.View
{
	public partial class LoginPage : ContentPage
	{
        private LoginPageViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent();
            BackgroundImage = "Fondo.jpeg";
            BindingContext = viewModel = new LoginPageViewModel();
            viewModel.Navigation = this.Navigation;
        }
        protected override bool OnBackButtonPressed()
        {
            // This prevents a user from being able to hit the back button and leave the login page.
            return true;
        }
    }
}