using lib11;

namespace dz_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введiть рядок: ");
            string b = Console.ReadLine();
            int count = UkrainianStringUtils.CVowels(b);
            Console.WriteLine($"Кількість голосних літер: {count}");
            int count2 = UkrainianStringUtils.CConsonants(b);
            Console.WriteLine($"Кількість приголосних літер: {-count2}");
            Console.WriteLine($"Обернена версiя: {UkrainianStringUtils.Rstring(b)}");
            Console.WriteLine($"Без дублiкатiв: {UkrainianStringUtils.RDuplicates(b)}");
            Console.WriteLine($"Без знакiв пунктуацii: {UkrainianStringUtils.RPunctuation(b)}");
        }
    }
}