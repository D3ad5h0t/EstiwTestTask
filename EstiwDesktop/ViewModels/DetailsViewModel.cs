using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using EstiwDesktop.Core.Actions;
using EstiwDesktop.Models;

namespace EstiwDesktop.ViewModels
{
    public class DetailsViewModel : BaseActions
    {
        private Customer _customer;

        public ObservableCollection<Product> Products { get; set; }

        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public DetailsViewModel(Customer customer)
        {
            Customer = customer;
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Id = 1,
                    CustomerId = 1,
                    Name = "Грибы",
                    Price = (decimal) 45.456,
                    Count = 5
                },
                new Product
                {
                    Id = 2,
                    CustomerId = 1,
                    Name = "Кетчуп",
                    Price = 210,
                    Count = 1
                }
            };
        }
    }
}
