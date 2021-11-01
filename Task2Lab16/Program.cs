﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Task2Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Gusev_A_D\\source\\repos\\Task1Lab16\\Task1Lab16\\bin\\Debug\\Products.json";
            string jsonstring = File.ReadAllText(path);
            Product[] arrayProduct = JsonSerializer.Deserialize<Product[]>(jsonstring);
            Product productWithMaxPrice = arrayProduct[0];
            foreach (Product p in arrayProduct)
            {
                if (p.Price > productWithMaxPrice.Price)
                {
                    productWithMaxPrice = p;
                }
            }
            Console.WriteLine("Самый дорогой товар:");
            Console.WriteLine($"{productWithMaxPrice.Code} {productWithMaxPrice.Name} {productWithMaxPrice.Price}");
            Console.ReadKey();
        }
    }
    class Product
    {
        public int Code { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}


