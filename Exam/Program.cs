using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Exam
{
    class Program
    {
        public static List<Product> ListProducts;

        static void Main(string[] args)
        {
            GenerateMenu();
        }

        static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records.");
                Console.WriteLine("3. Delete product by Id.");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter choice :");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Console.WriteLine("Bye");
                        Environment.Exit(1);
                        break;
                }
            }
        }

        private static void Delete()
        {
            Console.WriteLine("Enter product ID");
            string productID = Console.ReadLine();
            if (ListProducts != null)
            {
                for (int i = 0; i < ListProducts.Count; i++)
                {
                    if (ListProducts[i].Id == productID)
                    {
                        ListProducts.Remove(ListProducts[i]);
                        Console.WriteLine("Deleted");
                    }
                }
            }
        }

        private static void Display()
        {
            if (ListProducts != null)
            {
                Console.WriteLine("{0,15}{1,15}{2,15}", "ProductID", "ProductName", "Price");
                foreach (var item in ListProducts)
                {
                    Console.WriteLine("{0,15}{1,15}{2,15}", item.Id, item.Name, item.Price);
                }
            }
        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter ProductID :");
            string productID = Console.ReadLine();
            Console.WriteLine("Enter Product Name : ");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Price : ");
            int productPrice = Int32.Parse(Console.ReadLine());
            Product product = new Product(productID, productName, productPrice);
            if (ListProducts == null)
            {
                ListProducts = new List<Product>();
            }

            ListProducts.Add(product);
        }
    }
}