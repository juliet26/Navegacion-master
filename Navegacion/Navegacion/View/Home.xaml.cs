﻿using Navegacion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion.View
{
	
	public partial class Home : ContentPage
    {

        public Home ()
		{
            InitializeComponent();
            BackgroundImage = "Fondo1.jpeg";

        }
        protected override void OnAppearing()
        {
            this.BindingContext = new HomeViewModel(Navigation);
        }
    }
}