namespace dz_3_2
{
    //Написати програму, яка обчислює квадрат будь-якого введеного числа(бажано використати Math).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа: {Math.Pow(num,2)}");
        }
    }
}