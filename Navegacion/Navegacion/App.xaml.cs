using Navegacion.Data;
using Navegacion.Helpers;
using Navegacion.Services;
using Navegacion.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Navegacion
{
	public partial class App : Application
	{
        private static IncidenciaDataBase dataBase;
        
        public static IncidenciaDataBase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new IncidenciaDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3"));
                }
                return dataBase;
            }
        }
        private static UsuarioDataBase dataBaseS;

        public static UsuarioDataBase DataBases
        {
            get
            {
                if (dataBaseS == null)
                {
                    dataBaseS = new UsuarioDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db4"));
                }
                return dataBaseS;
            }
        }

        public App ()
		{
			InitializeComponent();

            if (Settings.IsLoggedIn)
            {
                MainPage = new NavigationPage(new SplashImage());
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
                //MainPage = new NavigationPage(new Home());
            }

            //MainPage = new NavigationPage (new SplashImage());
            
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
