
namespace dz_8
{
    internal class Program
    {
        static int cost = 0;
        static string[] arr = new string[0];
        static void Main(string[] args)
        {while (true) { Display(); }}
        static void Display()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Виберiть опцiю:\n1. Add item\n2. Display product and price\n3. Exit");
            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n1. Book\n2. Food\n3. Electronic\n4. Clothes");
                    ConsoleKeyInfo input2 = Console.ReadKey(true);
                    switch (input2.Key)
                    {
                        case ConsoleKey.D1:
                            EnumDisplay(typeof(books));
                            ConsoleKeyInfo input3 = Console.ReadKey(true);
                            switch (input3.Key)
                            {
                                case ConsoleKey.D1:
                                    cost += 120;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Govard";
                                    break;
                                case ConsoleKey.D2:
                                    cost += 111;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Bredberi";
                                    break;
                                case ConsoleKey.D3:
                                    cost += 200;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Steven_King";
                                    break;
                                case ConsoleKey.D4:
                                    cost += 180;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Konan_Doil";
                                    break;
                                case ConsoleKey.D5:
                                    cost += 150;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Shekspir";
                                    break;
                                default:
                                    Console.WriteLine("\nExiting...");
                                    Environment.Exit(0);
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D2:
                            EnumDisplay(typeof(Food));
                            ConsoleKeyInfo input4 = Console.ReadKey(true);
                            switch (input4.Key)
                            {
                                case ConsoleKey.D1:
                                    cost += 10;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "meat";
                                    break;
                                case ConsoleKey.D2:
                                    cost += 3;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "oranges";
                                    break;
                                case ConsoleKey.D3:
                                    cost += 1;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "apples";
                                    break;
                                case ConsoleKey.D4:
                                    cost += 2;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "bananas";
                                    break;
                                case ConsoleKey.D5:
                                    cost += 8;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "eggs";
                                    break;
                                default:
                                    Console.WriteLine("\nExiting...");
                                    Environment.Exit(0);
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D3:
                            EnumDisplay(typeof(Electronics));
                            ConsoleKeyInfo input5 = Console.ReadKey(true);
                            switch (input5.Key)
                            {
                                case ConsoleKey.D1:
                                    cost += 300;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Smartphone";
                                    break;
                                case ConsoleKey.D2:
                                    cost += 1100;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "TV";
                                    break;
                                case ConsoleKey.D3:
                                    cost += 1000;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "PC";
                                    break;
                                case ConsoleKey.D4:
                                    cost += 400;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Laptop";
                                    break;
                                case ConsoleKey.D5:
                                    cost += 200;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "Microwave";
                                    break;
                                default:
                                    Console.WriteLine("\nExiting...");
                                    Environment.Exit(0);
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            EnumDisplay(typeof(Clothes));
                            ConsoleKeyInfo input6 = Console.ReadKey(true);
                            switch (input6.Key)
                            {
                                case ConsoleKey.D1:
                                    cost += 40;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "tshirt";
                                    break;
                                case ConsoleKey.D2:
                                    cost += 5;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "socks";
                                    break;
                                case ConsoleKey.D3:
                                    cost += 200;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "sneakers";
                                    break;
                                case ConsoleKey.D4:
                                    cost += 70;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "trousers";
                                    break;
                                case ConsoleKey.D5:
                                    cost += 30;
                                    Array.Resize(ref arr, arr.Length + 1);
                                    arr[arr.Length - 1] = "shorts";
                                    break;
                                default:
                                    Console.WriteLine("\nExiting...");
                                    Environment.Exit(0);
                                    break;
                            }
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("\nExiting...");
                            break;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine($"Item list: {string.Join(", ", arr)}\nTotal cost = {cost}");
                    break;
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
            }
        }

        static void EnumDisplay(Type enumType)
        {
            Array allItems = Enum.GetValues(enumType);
            Console.WriteLine("\n");
            for (int i = 0; i < allItems.Length; i++)
            {
                object item = allItems.GetValue(i);
                Console.WriteLine($"{i + 1}. {item} - {Convert.ToInt32(item)}$");
                
            }
            Console.WriteLine("6. Exit");
        }
    }
}