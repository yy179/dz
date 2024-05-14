namespace dz_9
{

    internal class Program
    {
        static void Main(string[] args)
        {
           Book book1 = new Book("Title_","Author_",1990,600);
           book1.DisplayInfo();
           Book book2 = new Book("Title__", "Author__", 1990, 300);
           book2.DisplayInfo();
           Console.ReadKey();
        }
    }
}