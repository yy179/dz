using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_15_1
{
    internal class Shop : Product
    {
        Random rnd = new Random();
        public Dictionary<int, (string name, double price)> products = new Dictionary<int, (string, double)>();
        public Shop(int id, string name, double price) : base(id, name, price)
        {
            products.Add(id, (name, price));
        }
        public Shop() { }
        
        public void AddProduct(int id, string name, double price) // Я незнал как сделать через Product product, приходилось бы добавлять через new Shop...
        {
            products.Add(id,(name,price));
        }
        public void RemoveProduct(int id)
        {
            products.Remove(id);
        }
        public string GetProductById(int id)
        {
            return products[id].ToString();
        }
        public string GetAllProducts()
        {
            if (products.Count == 0)
            {
                return "No products available";
            }

            string allProducts = "";
            foreach (var product in products)
            {
                allProducts += $"ID: {product.Key}, Product: {product.Value.name}, Price: {product.Value.price}\n";
            }
            return allProducts;
        }
    }
}
