namespace dz_3_1
{
    //Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть 3-х значне число: ");
            int num = int.Parse(Console.ReadLine());
            int num3 = num % 10;
            int num2 = (num / 10) % 10;
            int num1 = num / 100;
            Console.WriteLine($"{num3}{num2}{num1}");
        }
    }
}