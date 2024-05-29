﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_15_1
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        public Product() { }
        public Product(int id,string name, double price) 
        {
            this.id = id;
            this.name = name;
            this.price = price;
            
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
    }
}
