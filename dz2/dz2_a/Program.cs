namespace dz2_a
{
    /*Задайте вартість товару та відсоток знижки як змінні (оскільки зчитування даних з консолі не розглядали, то достатньо просто проініціалізувати змінні деякими значеннями в програмі).
    Обчисліть величину знижки.
    Виведіть результат у консоль.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть вартiсть товару: ");
            double Cost = double.Parse(Console.ReadLine());
            Console.Write("Введiть відсоток знижки: ");
            double discount_procent = double.Parse(Console.ReadLine());
            double discount_cost = Cost * (1 - (discount_procent / 100));
            Console.WriteLine($"Цiна зi знижкою: {discount_cost}");
        }
    }
}