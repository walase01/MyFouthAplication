using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fourthAplicattion.Services
{
    public class AlertServices : IAlertServices
    {
        public Task DisplayAlert(string Message)
        {
            return App.Current.MainPage.DisplayAlert("A ocurrido un error",Message, "Cancel");
        }

        public Task NavegationToAddContact()
        {
            throw new NotImplementedException();
        }
    }
}
