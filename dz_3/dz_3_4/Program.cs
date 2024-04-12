namespace dz_3_4
{
    //Написати програму, яка обчислює середнє арифметичне двох чисел.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть перше число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введiть друге число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write($"Середне арифметичне: {(num1 + num2) / 2}");
            //Console.Write($"Середне арифметичне: {mid(num1,num2)}");
        }
        //static int mid(int num1,int num2)
        //{
        //    return (num1 + num2) / 2 ;
        //}
    }
}