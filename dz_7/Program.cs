namespace dz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initialize(out int[] Matharr, out int[] Englisharr, out int[] Physicarr);
            Display( Matharr, Englisharr, Physicarr);
        }
        static void Initialize(out int[] Matharr, out int[] Englisharr, out int[] Physicarr)
        {
            Matharr = new int[0];
            Englisharr = new int[0];
            Physicarr = new int[0];
        }
        static void Display(int[] Matharr, int[] Englisharr, int[] Physicarr)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Виберiть опцiю:\n1. Ввести оцiнку\n2. Вивести оцiнки\n3. Середня оцiнка\n4. Вихiд");
            ConsoleKeyInfo input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n1. Математика\n2. Англiйська\n3. Фiзика\n4. Вихiд");
                    ConsoleKeyInfo input2 = Console.ReadKey(true);
                    switch(input2.Key) 
                    {
                        case ConsoleKey.D1:
                            Add(ref Matharr);
                            Console.Clear();
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D2:
                            Add(ref Englisharr);
                            Console.Clear();
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D3:
                            Add(ref Physicarr);
                            Console.Clear();
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine("\nExiting program");
                            return;
                        default:
                            Console.WriteLine("\nInvalid option");
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\n1. Математика\n2. Англiйська\n3. Фiзика\n4. Вихiд");
                    ConsoleKeyInfo input3 = Console.ReadKey(true);
                    switch (input3.Key)
                    {
                        case ConsoleKey.D1:
                            if (Matharr.Length == 0){Console.WriteLine("\nНемає оцінок для виведення.");}
                            else{Console.WriteLine(string.Join(", ", Matharr));}
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D2:
                            if (Englisharr.Length == 0) { Console.WriteLine("\nНемає оцінок для виведення."); }
                            else { Console.WriteLine(string.Join(", ", Englisharr)); }
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D3:
                            if (Physicarr.Length == 0) { Console.WriteLine("\nНемає оцінок для виведення."); }
                            else { Console.WriteLine(string.Join(", ", Physicarr)); }
                            Display(Matharr, Englisharr, Physicarr); ;
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine("\nExiting program");
                            return;
                        default:
                            Console.WriteLine("\nInvalid option");
                            break;
                    }
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\n1. Математика\n2. Англiйська\n3. Фiзика\n4. Вихiд");
                    ConsoleKeyInfo input4 = Console.ReadKey(true);
                    switch (input4.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine($"Середня оцінка з математики: {Average(Matharr)}");
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine($"Середня оцінка з англiйськоi: {Average(Englisharr)}");
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine($"Середня оцінка з фiзики: {Average(Physicarr)}");
                            Display(Matharr, Englisharr, Physicarr);
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine("\nExiting program");
                            return;
                        default:
                            Console.WriteLine("\nInvalid option");
                            break;
                    }
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("\nExiting program");
                    return;
                default:
                    Console.WriteLine("\nInvalid option");
                    break;
            }
        }
        static void Add(ref int[] arr)
        {
            Console.Write($"\nВведiть кiлькiсть оцiнок для добавлення: ");
            int count = int.Parse(Console.ReadLine());
            Array.Resize(ref arr, arr.Length + count);
            for (int i = arr.Length - count; i < arr.Length; i++)
            {
                Console.Write("Введiть оцiнку: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
        }
        static double Average(int[] arr)
        {
            if (arr.Length == 0)
                return 0;
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }
    }
}
