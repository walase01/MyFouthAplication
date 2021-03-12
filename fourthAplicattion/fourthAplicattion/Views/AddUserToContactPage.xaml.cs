using fourthAplicattion.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fourthAplicattion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUserToContactPage : ContentPage
    {
        public AddUserToContactPage(ObservableCollection<Contact> contacts)
        {
            InitializeComponent();
            this.BindingContext = new AddUserToContactPage(contacts);
        }
    }
}