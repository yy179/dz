namespace dz_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть число вiд 1 до 100: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100) 
            { 
                string outp = (num % 15 == 0) ? "FizzBuzz" : (num % 5 == 0) ? "Buzz" : (num % 3 == 0) ? "Fizz" : "Число не кратне 15,5,3";
                Console.WriteLine(outp);
            }
            else { Console.Write("Число вiд 1 до 100"); }
        }
    }
}