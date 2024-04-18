namespace dz_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть мiсяць: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1: case 2: case 12: Console.WriteLine("Зима");
                    break;
                case 3: case 4: case 5: Console.WriteLine("Весна");
                    break;
                case 6: case 7: case 8: Console.WriteLine("Лiто");
                    break;
                case 9: case 10: case 11: Console.WriteLine("Осiнь");
                    break;
                default: Console.WriteLine("Немає такого місяця на цій планеті");
                    break;
            }
        }
    }
}