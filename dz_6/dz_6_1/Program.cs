namespace dz_6_1
{
    internal class Program
    {
        //Задати масив із 10 елементів. Заповнити цей масив рандомними числами від -100 до 100. Знайти кількість додатніх чисел у масиві. Вивести на екран масив і кількість порахованих чисел. 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int [10];
            for (int i = 0; i < arr.Length; i++) {arr[i] = rnd.Next(-100, 101);}
            int[] res = arr.Where(i => i > 0 ).ToArray();
            Console.WriteLine(string.Join(" ", res));
            Console.Write(res.Length);
        }
    }
}