namespace dz2_v
{
    //Створіть програму, яка виводить інформацію про книгу, використовуючи форматований рядок. Параметри книги - назва, автор, рік та ціна. 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string title = "Book";
            string author = "Name";
            int year = 2023;
            long price = 140000;
            Console.WriteLine($"Назва: {title}\nАвтор: {author}\nРiк: {year}\nЦiна: {price}");
        }
    }
}