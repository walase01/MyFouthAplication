using fourthAplicattion.Models;
using fourthAplicattion.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using fourthAplicattion.Views;

namespace fourthAplicattion.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Contact> Contacts { get; }

        public ICommand AddContact { get; }
        public ICommand DeleteCommand { get; }
        public ICommand MoreCommand { get; }

        AddUserToContactPage ToContactPage;

        private IAlertServices AlertServices;
        public MainViewModel(IAlertServices alertServices)
        {
            Contacts = new ObservableCollection<Contact>();
            AddContact = new Command(AddContactToList);
            DeleteCommand = new Command<Contact>(DeleteContact);
            MoreCommand = new Command<Contact>(OnMoreCommandClick);
            AlertServices = alertServices;
            ToContactPage = new AddUserToContactPage(Contacts);

        }

        public  async void AddContactToList()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddUserToContactPage(Contacts));
        }
        public void DeleteContact(Contact contact)
        {
            if(Contacts != null)
            {
                Contacts.Remove(contact);
            }
             
        }
        public async void OnMoreCommandClick(Contact contact)
        {
            //var categori = await AlertServices.AccionSheet($"Call +{contact.Number}");
            var category = await App.Current.MainPage.DisplayActionSheet("Select the option","Cancel",null,new string[] { $"Call +{contact.Number}","Edit"});
            if(category != "Edit")
            {
                try
                {
                    PhoneDialer.Open(contact.Number);
                }
                catch (ArgumentNullException anEx)
                {
                    string mensaje = anEx.Message;
                    await App.Current.MainPage.DisplayAlert("A ocurrido un error",mensaje,"Cancel");
                }
            }
            else
            {
                contact.Name = await App.Current.MainPage.DisplayPromptAsync("Editar el nombre","Digite el nombre","Ok","Cancel");
                contact.Number = await App.Current.MainPage.DisplayPromptAsync("Editar el Telefono", "Digite el numero Telefonico", "Ok", "Cancel");
                Contacts.Add(new Contact(contact.Name,contact.Number));
            }

        }
    }
}
