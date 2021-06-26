using System;
using System.Collections.Generic;
using System.Text;

namespace CoursoOrder02.Entitys
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
