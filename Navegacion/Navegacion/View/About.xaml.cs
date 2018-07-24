using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Navegacion.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class About : ContentPage
	{
		public About ()
		{
			InitializeComponent ();
            BackgroundImage = "Fondo.jpeg";
        }
        protected override void OnAppearing()
        {
            this.BindingContext = new AboutViewModel(Navigation);
        }
    }
}