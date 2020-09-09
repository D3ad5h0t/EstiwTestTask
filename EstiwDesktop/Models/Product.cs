using System.Windows.Documents;
using EstiwDesktop.Core.Actions;

namespace EstiwDesktop.Models
{
    public class Product : BaseActions
    {
        private string _name;
        private decimal _price;
        private int _count;

        public long Id { get; set; }

        public long CustomerId { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("Count");
            }
        }
    }
}
