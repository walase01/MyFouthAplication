using fourthAplicattion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace fourthAplicattion.ViewModels
{
    public class AddContactViewModel
    {
        public String AddNewCellCommand { get; set; }
        public String AddNewNameCommand { get; set; }
        public ICommand AddContact { get; set; }

        public ObservableCollection<Contact> contact;
        public AddContactViewModel(ObservableCollection<Contact> Contacts)
        {
            this.contact = Contacts; 
        }
        public void OnAddContact()
        {
            
            contact.Add(new Contact(AddNewNameCommand, AddNewCellCommand));

        }
    }
}
