using fourthAplicattion.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fourthAplicattion.Services
{
    public class NavegationServices : IAlertServices
    {
        public Task DisplayAlert(string Message)
        {
            throw new NotImplementedException();
        }

        public Task NavegationToAddContact()
        {
            //await App.Current.MainPage.Navigation.PushAsync(new AddUserToContactPage());
            return Task.CompletedTask;

        }
    }
}
