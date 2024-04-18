namespace dz_4_1
{
    //Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа. Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння (чи рівні значення, а якщо ні, яке число більше/менше).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть перше число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введiть друге число: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($" {num1} > {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} < {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} = {num2}");
            }
        }
    }
}