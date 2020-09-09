using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
using System.Windows.Data;
using EstiwDesktop.Core.Commands;
using EstiwDesktop.Models;

namespace EstiwDesktop.ViewModels
{
    class ApplicationViewModel : BaseViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        private Customer _selectedCustomer;
        private Customer _selectedCustomerCopy;

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
                UpdateCopy(value);
            }
        }

        public Customer SelectedCustomerCopy
        {
            get => _selectedCustomerCopy;
            set
            {
                _selectedCustomerCopy = value;
                OnPropertyChanged("SelectedCustomerCopy");
            }
        }

        public void UpdateCopy(Customer customer)
        {
            if (customer != null)
            {
                SelectedCustomerCopy = new Customer
                {
                    LastName = customer.LastName,
                    FirstName = customer.FirstName,
                    Phone = customer.Phone,
                    Address = customer.Address
                };
            }
        }

        #region Команда добавления нового объекта

        private RelayCommand _addCommand;
        public RelayCommand AddCommand =>
            _addCommand ??= new RelayCommand(obj =>
            {
                Customer customer = new Customer();
                Customers.Insert(0, customer);
                SelectedCustomer = customer;
            });

        #endregion

        #region Команда удаления объекта из списка

        private RelayCommand _removeCommand;
        public RelayCommand RemoveCommand =>
            _removeCommand ??= new RelayCommand(obj =>
                {
                    if (obj is Customer customer)
                    {
                        Customers.Remove(customer);
                    }
                },
                (obj) => Customers.Count > 0);

        #endregion

        #region Команда сохранения изменений

        private RelayCommand _saveCommand;

        public RelayCommand SaveCommand => _saveCommand ??= new RelayCommand(obj =>
            {
                if (obj is Customer customer)
                {
                    SelectedCustomer = SelectedCustomerCopy;
                    OnPropertyChanged("SelectedCustomer");
                }
            });

        #endregion

        #region Команда отмены изменений

        private RelayCommand _cancelCommand;

        public RelayCommand CancelCommand => _cancelCommand ??= new RelayCommand(obj => SelectedCustomerCopy = SelectedCustomer);

        #endregion

        /// <summary>
        /// Добавить получение пользователей через сервер
        /// </summary>
        public ApplicationViewModel()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer
                {
                    FirstName = "Mihail",
                    LastName = "Ivanov",
                    Phone = "74333",
                    Address = "Kamskiy pereulok"
                },
                new Customer
                {
                    FirstName = "Alex",
                    LastName = "Roman",
                    Phone = "444522",
                    Address = "Moscow, Russia"
                },
                new Customer
                {
                    FirstName = "Bill",
                    LastName = "Clinton",
                    Phone = "990072171",
                    Address = "Washington"
                }
            };

            SelectedCustomer = Customers.FirstOrDefault();
        }
    }
}
