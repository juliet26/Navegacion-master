﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActiveBreaks : TabbedPage
    {
        public ActiveBreaks ()
        {
            InitializeComponent();
            BackgroundImage = "Fondo.jpeg";
        }
    }
}