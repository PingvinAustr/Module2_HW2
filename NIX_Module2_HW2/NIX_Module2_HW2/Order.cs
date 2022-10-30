using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Module2_HW2
{
    internal class Order
    {
        private List<Product> _productsInOrder = new List<Product>();
        private int _orderId;

        internal Order(List<Product> products)
        {
            _productsInOrder = products;
            Random random = new Random();
            _orderId = random.Next(0, 1000);
        }

        internal List<Product> ReturnOrderProducts()
        {
            return _productsInOrder;
        }

        internal int ReturnOrderId()
        {
            return _orderId;
        }
    }
}
