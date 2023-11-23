using System;
using Newtonsoft.Json;
namespace Bai_10_Package
{
    class Program
    {
        class Product
        {
            public string name { get; set; }
            public DateTime Expiry { get; set; }
            public string Size { get; set; }
        }
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "Samsung";
            product.Expiry = new DateTime(2023, 12, 12);
            product.Size = "Big";

            string json = JsonConvert.SerializeObject(product);
            Console.Write(json);
        }
    }
}