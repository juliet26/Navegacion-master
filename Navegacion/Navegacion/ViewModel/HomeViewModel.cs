﻿using Navegacion.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Navegacion.ViewModel
{
    public class HomeViewModel
    {
        public Command CalendarCommand { get; set; }
        public Command ReportCommand { get; set; }
        public Command PauseCommand { get; set; }
        private INavigation Navigation;

    
    public HomeViewModel(INavigation navigation)
    {
        CalendarCommand = new Command(async () => await CalendarPage());
        ReportCommand = new Command(async () => await ReportPage());
        PauseCommand = new Command(async () => await PausePage());
        Navigation = navigation;
    }

        private async Task PausePage()
        {
            await Navigation.PushAsync(new ActiveBreaks());
        }

        private async Task ReportPage()
        {
            await Navigation.PushAsync(new MainPage());
            //await Navigation.PushAsync(new IncidenciaRPage());
        }

        private async Task CalendarPage()
        {
            await Navigation.PushAsync(new About());
        }
    }
}
