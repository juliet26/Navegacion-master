using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Navegacion.ViewModel
{
    public class AboutViewModel
    {
        private INavigation navigation;

        public AboutViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        public ICommand NavigateCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
    }
}
