namespace dz_6_4
{
    internal class Program
    {
        //Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1. Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int[rnd.Next(1,12)];
            for (int i = 0; i < arr.Length; i++) { arr[i] = rnd.Next(-6, 6); }
            Array.FindIndex(arr, i => i == -1);
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < Array.FindIndex(arr, i => i == -1); i++){ Console.WriteLine(arr[i]); }
        }
    }
}