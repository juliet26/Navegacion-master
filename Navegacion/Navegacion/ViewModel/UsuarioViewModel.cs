using Navegacion.Model;
using Navegacion.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion.ViewModel
{
    public class UsuarioViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public bool IsEnabled { get; set; }
        public Usuario FriendModel { get; set; }
        private INavigation Navigation;

        public UsuarioViewModel(INavigation navigation)
        {
            FriendModel = new Usuario();
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public UsuarioViewModel(INavigation navigation, Usuario friend)
        {
            FriendModel = friend;
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
            IsEnabled = true;
            DeleteCommand = new Command(async () => await DeleteFriend());
        }
        public async Task SaveFriend()
        {
            await Navigation.PushAsync(new Home());
        }
        public async Task DeleteFriend()
        {
            await App.DataBases.DeleteFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }
    }

}