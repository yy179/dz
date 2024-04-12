namespace dz_3_5
{
    internal class Program
    {
        //Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть радіус круга:");
            double radius = double.Parse(Console.ReadLine());
            double S = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площа круга: {S}");
        }
    }
}