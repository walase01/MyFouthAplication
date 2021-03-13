using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace fourthAplicattion.Models
{
    public class Contact
    {
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }
        public string Number { get; set; }

        public static implicit operator Contact(ObservableCollection<Contact> v)
        {
            throw new NotImplementedException();
        }
    }
}
