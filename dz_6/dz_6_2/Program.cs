namespace dz_6_2
{
    internal class Program
    {
        //Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку. В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int[rnd.Next(1, 50)];//Не знаю на сколько нужно но чтобы было удобно пусть будет 50
            for (int i = 0; i < arr.Length; i++) { arr[i] = rnd.Next(-100, 101); }
            //1. Console.WriteLine(string.Join(" ", arr.Reverse().ToArray()));

            //2. int[] res = arr.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", res));

            //3. Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ",arr));

            //4. int[] arrnew = new int[arr.Length];
            //for (int i = 0;i < arr.Length; i++) { arrnew[i] = arr[arr.Length - 1 - i]; }
            //Console.WriteLine(string.Join(" ", arrnew));

            for (int i = 0; i < arr.Length / 2; i++) 
            { 
                int n = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = n;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
//Честно сказать так и не понял что именно от меня нужно поэтому наклипал все что мог ¯\_(ツ)_/¯