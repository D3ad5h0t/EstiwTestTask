using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstiwService.Models
{
    public class Customer
    {
        /// <summary>
        /// Идентификатор заказчика
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Имя заказчика
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия заказчика
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Телефон для контакта с заказчиком
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Адрес доставки товаров
        /// </summary>
        public string Address { get; set; }
    }
}
