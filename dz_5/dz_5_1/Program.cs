namespace dz_5_1
{
    //Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений. Правильний пароль нехай буде "root". Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    string password = "root";
        //    bool iscorr = false;
        //    while (!iscorr) 
        //    {
        //        Console.Write("Введiть пароль: ");
        //        string pass = Console.ReadLine();
        //        string res = (pass == password) ? "Правильний пароль." : "Неправильний пароль!";
        //        Console.WriteLine(res);
        //        iscorr = pass == password;
        //    }
        //}
        static void Main(string[] args)
        {
            string password = "root";
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("Введiть пароль: ");
                string pass = Console.ReadLine();
                if (pass == password) {Console.WriteLine("Правильний пароль."); break;}
                else { Console.WriteLine("Неправильний пароль!"); }
            }
        }
    }
}