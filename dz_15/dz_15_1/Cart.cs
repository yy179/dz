using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dz_15_1
{
    internal class Cart : Shop
    {
        private Dictionary<string, double> carthave = new Dictionary<string, double>();

        public Cart(int id, string name, double price) : base(id, name, price)
        {
            carthave.Add(name, price);
        }
        public Cart() { }

        public void AddToCart(int id)
        {
            if (products.ContainsKey(id))
            {
                var product = products[id];
                carthave.Add(product.name, product.price);
            }
            else
            {
                throw new ArgumentException("Product with the given ID does not exist.");
            }
        }
        public void RemoveFromCart(int id) 
        {
            carthave.Remove(GetProductById(id));
        }
        public double GetTotalPrice() 
        {
            return carthave.Sum(obj => obj.Value);
        }
    }
}
