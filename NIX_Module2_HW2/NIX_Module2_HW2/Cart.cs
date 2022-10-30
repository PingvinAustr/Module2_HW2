using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Module2_HW2
{
    internal static class Cart
    {
        private static List<Product> _productsInCart = new List<Product>();
        internal static int ProductsInCartSum { get; set; }

        internal static void AddProductToCart(Product product)
        {
            _productsInCart.Add(product);
            ProductsInCartSum += product.ProductPrice;
        }

        internal static void RemoveProductFromCart(Product product)
        {
            _productsInCart.Remove(product);
            ProductsInCartSum -= product.ProductPrice;
        }

        internal static List<Product> ReturnCartProducts()
        {
            return _productsInCart;
        }

        internal static void ClearCart()
        {
            _productsInCart.Clear();
            ProductsInCartSum = 0;
        }
    }
}
