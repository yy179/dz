namespace dz_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;i <= 10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.Write($"\t{i} * {j} = {i*j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}