using System.Text;
namespace dz_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            StringBuilder sb = new StringBuilder();
            Console.Write("Введiть день: ");
            string dayin = Console.ReadLine();
            int day;
            while (!int.TryParse(dayin, out day) || day < 1 || day > 31) 
            {
                Console.WriteLine("Некоректно введений день");
                Console.Write("Введiть день: ");
                dayin = Console.ReadLine();
            }
            Console.Write("Введiть мiсяць: ");
            string monthin = Console.ReadLine();
            int month;
            while (!int.TryParse(monthin, out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Некоректно введений мiсяць");
                Console.Write("Введiть мiсяць: ");
                monthin = Console.ReadLine();
            }
            Console.Write("Введiть рiк: ");
            string yearin = Console.ReadLine();
            int year;
            while (!int.TryParse(yearin, out year) || year < 1)
            {
                Console.WriteLine("Некоректно введений рiк");
                Console.Write("Введiть рiк: ");
                yearin = Console.ReadLine();
            }
            static bool isLeap(int year){ return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); }
            int monthdays;
            switch (month)
            {
                case 2:
                    monthdays = isLeap(year) ? 29 : 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    monthdays = 30;
                    break;
                default:
                    monthdays = 31;
                    break;
            }
            if (day > monthdays) { Console.WriteLine("Некоректна дата. Введений день не підходить для вибраного місяця та року."); }
            else
            {
                sb.Append(day);
                sb.Append("-");
                sb.Append(month);
                sb.Append("-");
                sb.Append(year);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}