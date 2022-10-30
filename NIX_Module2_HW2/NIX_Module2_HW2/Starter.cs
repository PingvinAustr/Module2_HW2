using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIX_Module2_HW2
{
    internal class Starter
    {
        internal static void SeedStockWithProducts()
        {
            Product prod1 = new Product(1, "Mac", 2000);
            Product prod2 = new Product(2, "IPhone 14", 2000);
            Product prod3 = new Product(3, "IPhone 7", 600);
            Product prod4 = new Product(4, "Lenovo Legion 7", 1500);
            Product prod5 = new Product(5, "Nokia 3310", 100);
            Product prod6 = new Product(6, "IPhone 13", 1400);
            Product prod7 = new Product(7, "Hyperx mouse", 100);
            Product prod8 = new Product(8, "Airpods", 200);
            Product prod9 = new Product(9, "Airpods 2", 300);
            Product prod10 = new Product(10, "Airpods Pro", 400);
            Product prod11 = new Product(11, "Apple Watch", 500);
            Product prod12 = new Product(12, "MSI Leopard Pro", 1500);
            Product prod13 = new Product(13, "IPhone 6", 400);
            Product prod14 = new Product(14, "RTX Geforce 3060", 1500);
            Product prod15 = new Product(15, "AMD Ryzen 5000", 1000);
            Stock.AddProductToStockSingle(prod1);
            Stock.AddProductToStockSingle(prod2);
            Stock.AddProductToStockSingle(prod3);
            Stock.AddProductToStockSingle(prod4);
            Stock.AddProductToStockSingle(prod5);
            Stock.AddProductToStockSingle(prod6);
            Stock.AddProductToStockSingle(prod7);
            Stock.AddProductToStockSingle(prod8);
            Stock.AddProductToStockSingle(prod9);
            Stock.AddProductToStockSingle(prod10);
            Stock.AddProductToStockSingle(prod11);
            Stock.AddProductToStockSingle(prod12);
            Stock.AddProductToStockSingle(prod13);
            Stock.AddProductToStockSingle(prod14);
            Stock.AddProductToStockSingle(prod15);
        }

        internal static void RandomlyAddProductsToCart()
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int generatedNum = random.Next(1, 16);
                foreach (Product prod in Stock.ReturnStockProducts())
                {
                    if (prod.ProductId == generatedNum)
                    {
                        Cart.AddProductToCart(prod);
                        break;
                    }
                }
            }
        }

        internal static void Run()
        {
            // Seed stock with initial products
            SeedStockWithProducts();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------------------\nAll products that are on stock:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Product product in Stock.ReturnStockProducts())
            {
                Console.WriteLine(product.ProductId + " '" + product.ProductName + "' " + product.ProductPrice);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n-----------------------------------------------------------\nAll products that have been added to your cart:");
            Console.ForegroundColor = ConsoleColor.White;
            RandomlyAddProductsToCart();
            foreach (Product product in Cart.ReturnCartProducts())
            {
                Console.WriteLine(product.ProductId + " '" + product.ProductName + "' " + product.ProductPrice);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total sum of cart:" + Cart.ProductsInCartSum);
            Console.ForegroundColor = ConsoleColor.White;

            ShopProvider.CreateOrder();
        }
    }
}
