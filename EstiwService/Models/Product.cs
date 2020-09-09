using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace EstiwService.Models
{
    public class Product
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор заказчика
        /// </summary>
        public long CustomerId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Кол-во приобретенного товара
        /// </summary>
        public int Count { get; set; }
    }
}
