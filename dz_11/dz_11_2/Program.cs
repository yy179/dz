namespace dz_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть свiй вiк: ");
            string age = Console.ReadLine();
            int age2;
            try
            {
                if (!int.TryParse(age, out age2) || age2 < 0 ) 
                {
                    throw new FormatException("Вік не може бути від'ємним або не цiлим числом.");
                }
                else { Console.WriteLine($"Введений вiк: {age}"); }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Помилка: {e.Message}");
                Console.ReadKey();
            }
            
        }
    }
}