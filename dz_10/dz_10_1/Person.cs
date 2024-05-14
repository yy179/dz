using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_10_1
{
    internal class Person
    {
        private string name;
        private int age;
        private string sex;
        public Person(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public Person(string name) : this(name, 0, "Not indicated") { }
        public int Ages
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person(string name, int age) : this(name, age, "Not indicated") { }
        public void PrintDetails() { Console.WriteLine($"Name: {name}\nAge: {age}\nSex: {sex}\nIsAdult: {isAdult()}\n"); }
        public bool isAdult()
        {
            return age >= 18;
        }
        private string ChangeName(string name)
        {
            Console.WriteLine("New name: ");
            this.name = Console.ReadLine();
            return this.name;
        }
    }
}
