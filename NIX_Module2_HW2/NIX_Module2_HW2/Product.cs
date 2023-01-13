using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Module2_HW2
{
    internal class Product
    {
        internal Product(int prodId, string prodName, int price)
        {
            Random rand = new Random();
            ProductId = prodId;
            ProductName = prodName;
            ProductPrice = price;
        }

        internal string ProductName { get; set; }
        internal int ProductId { get; set; }
        internal int ProductPrice { get; set; }
    }
}
