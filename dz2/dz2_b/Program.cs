namespace dz2_b
{
    //    Задайте час у годинах, хвилинах та секундах як змінні. Обчисліть загальний час у секундах. Виведіть результат у консоль.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть години: ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("Введiть хвилини: ");
            double minutes = double.Parse(Console.ReadLine());
            Console.Write("Введiть секунди: ");
            long seconds = long.Parse(Console.ReadLine());
            double result = hours * 3600 + minutes * 60 + seconds;
            Console.WriteLine($"Час в секундах: {result}");
        }
    }
}