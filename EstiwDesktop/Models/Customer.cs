using System.ComponentModel;
using System.Runtime.CompilerServices;
using EstiwDesktop.Core.Actions;

namespace EstiwDesktop.Models
{
    public class Customer : BaseActions
    {
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _address;

        public long Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }
    }
}
