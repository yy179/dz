namespace dz_6_3
{
    internal class Program
    {
        //Потрібно додати до масиву елемент на початок. Нехай масив буде на 10 елементів.
        //Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно. 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++) { arr[i] = rnd.Next(-100, 101); }
            int[] arrnew = new int [arr.Length + 1];
            for (int i = 0; i < arr.Length; i++) { arrnew[i + 1] = arr[i]; }
            arrnew[0] = rnd.Next(-100, 101);
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arrnew));
        }
    }
}