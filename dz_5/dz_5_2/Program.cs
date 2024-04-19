namespace dz_5_2
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Random rnd = new Random();
        //    int num = rnd.Next(1,147);
        //    //Console.WriteLine(num);
        //    Console.Write("Вгадай число вiд 1 до 146 ");
        //    int usnum = int.Parse(Console.ReadLine());
        //    while (usnum != num) 
        //    {
        //        if (usnum < num) {Console.WriteLine("бiльше");}
        //        else { Console.WriteLine("менше");}
        //        usnum = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine($"Ви вгадали число {num}");
        //}
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int num = rnd.Next(1, 147);
            //Console.WriteLine(num);
            Console.Write("Вгадай число вiд 1 до 146 ");
            int usnum = int.Parse(Console.ReadLine());
            while (usnum != num)
            {
                Console.WriteLine(usnum > num ? "менше" : "бiльше");
                usnum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Ви вгадали число {num}");
        }
    }
}