﻿using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp2.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double cfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, cfee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));
                }
                else
                {
                    Console.Write("Discont: ");
                    double discont = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price, discont));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.Name + product.priceTag());
            }
        }
    }
}