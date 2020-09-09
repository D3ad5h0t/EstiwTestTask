using System;
using System.Collections.Generic;
using System.Text;

namespace EstiwDesktop.Models
{
    public class Product
    {
        /// <summary>
        /// Нужно Id и CustomerId
        /// </summary>
        private string _name;
        private decimal _price;
        private int _count;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public int Count
        {
            get => _count;
            set => _count = value;
        }
    }
}
