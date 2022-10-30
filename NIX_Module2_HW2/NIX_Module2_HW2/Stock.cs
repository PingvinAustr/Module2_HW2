using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Module2_HW2
{
    internal static class Stock
    {
        private static List<Product> _productsOnStock = new List<Product>();

        internal static void AddProductToStockSingle(Product product)
        {
            _productsOnStock.Add(product);
        }

        internal static void AddProductToStockList(List<Product> products)
        {
            foreach (Product product in products)
            {
                _productsOnStock.Add(product);
            }
        }

        internal static List<Product> ReturnStockProducts()
        {
            return _productsOnStock;
        }
    }
}
