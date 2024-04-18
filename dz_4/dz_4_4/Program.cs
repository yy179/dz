namespace dz_4_4
{
    internal class Program
    {
        static void abc(out int a, out int b,out int c)
        {
            Random rnd = new Random();
            a = rnd.Next(1,10);
            b = rnd.Next(1, 10);
            c = rnd.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            abc(out int a, out int b, out int c);
            int disc = b * b - 4 * a * c;
            switch (Math.Sign(disc))
            {
                case 1:
                    double x1 = (-b + Math.Sqrt(disc)) / (2.0 * a);
                    double x2 = (-b - Math.Sqrt(disc)) / (2.0 * a);
                    Console.Write($"x1 = {x1}\nx2 = {x2}");
                    break;
                case 0:
                    double x = -b / (2 * a);
                    Console.Write($"x1 = {x}");
                    break;
                case -1:
                    Console.Write("Нема коренiв");
                    break;
            }
        }
    }
}