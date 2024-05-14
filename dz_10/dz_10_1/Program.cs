using System;

namespace dz_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            while (answer == "y")
            {
                Console.WriteLine("Input Name: ");
                string n = Convert.ToString(Console.ReadLine());
                Console.Write("Input age: ");
                int d = int.Parse(Console.ReadLine());
                Person person1 = new Person(n, d);
                person1.Ages = d;
                person1.Name = n;
                person1.PrintDetails();
                Console.WriteLine("Wanna change name? Y/N");
                answer = Console.ReadLine().ToLower();
            }
            Person person2 = new Person("Vlad", 18);
            person2.PrintDetails();

            Person person3 = new Person("Vlad", 18, "Male");
            person3.PrintDetails();
        }
    }
}