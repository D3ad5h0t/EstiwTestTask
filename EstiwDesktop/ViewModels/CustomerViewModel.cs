using System.Collections.ObjectModel;
using System.Linq;
using EstiwDesktop.Core.Actions;
using EstiwDesktop.Core.Commands;
using EstiwDesktop.Models;

namespace EstiwDesktop.ViewModels
{
    class CustomerViewModel : BaseActions
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
                SelectedCustomerCopy = customer.Clone() as Customer;
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
                var oldCustomer = Customers.FirstOrDefault(x => x.Id == SelectedCustomer.Id);

                if (oldCustomer != null)
                {
                    oldCustomer.Id = SelectedCustomerCopy.Id;
                    oldCustomer.FirstName = SelectedCustomerCopy.FirstName;
                    oldCustomer.LastName = SelectedCustomerCopy.LastName;
                    oldCustomer.Address = SelectedCustomerCopy.Address;
                    oldCustomer.Phone = SelectedCustomerCopy.Phone;
                }
            });

        #endregion

        #region Команда отмены изменений

        private RelayCommand _cancelCommand;

        public RelayCommand CancelCommand => _cancelCommand ??= new RelayCommand(obj =>
        {
            SelectedCustomerCopy = SelectedCustomer.Clone() as Customer;
        });

        #endregion

        #region Команда для отображения подробной информации о заказчике

        private RelayCommand _detailsCommand;

        public RelayCommand DetailsCommand => _detailsCommand ??= new RelayCommand(obj =>
        {
            if (obj is Customer customer)
            {
                DetailsWindow window = new DetailsWindow(customer);
                window.Show();
            }
        });

        #endregion

        /// <summary>
        /// Добавить получение пользователей через сервер
        /// </summary>
        public CustomerViewModel()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Mihail",
                    LastName = "Ivanov",
                    Phone = "74333",
                    Address = "Kamskiy pereulok"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Alex",
                    LastName = "Roman",
                    Phone = "444522",
                    Address = "Moscow, Russia"
                },
                new Customer
                {
                    Id = 3,
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
