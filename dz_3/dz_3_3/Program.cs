namespace dz_3_3
{
    //Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
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
            Console.WriteLine($"{num2}{num1}{num3}");
        }
    }
}