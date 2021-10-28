using System;
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
            string[] massive = jsonstring.Split();
            foreach (string s in massive)
            {
                Console.WriteLine("{0}", s);       //и на этом всё.. фантазия закончилась.
            }
            //Console.WriteLine(jsonstring);
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


