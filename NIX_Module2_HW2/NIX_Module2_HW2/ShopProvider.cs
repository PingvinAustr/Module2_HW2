using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Module2_HW2
{
    internal static class ShopProvider
    {
        internal static void CreateOrder()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n-----------------------------------------------------------\nOrder created.");
            Console.ForegroundColor = ConsoleColor.White;
            Order order = new Order(Cart.ReturnCartProducts(), Cart.ProductsInCartSum);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------------------\nProducts from your order:\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Product product in order.ReturnOrderProducts())
            {
                Console.WriteLine(product.ProductId + " '" + product.ProductName + "' " + product.ProductPrice);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nCart was cleared. ID of your order is " + order.ReturnOrderId() + ". Total price is " + order.OrderSum);
            Console.ForegroundColor = ConsoleColor.White;
            Cart.ClearCart();
        }
    }
}
