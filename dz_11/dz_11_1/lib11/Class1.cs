using System.Xml.Linq;

namespace lib11
{
    public static class UkrainianStringUtils
    {
        private static int c = 0;
        private static char[] str2 = { 'і', 'ї', 'и', 'е', 'є', 'а', 'я', 'о', 'у', 'ю' };
        public static int CVowels(string b)
        {
            return c = b.Count(i => str2.Contains(i)); ; 
        }
        public static int CConsonants(string b)
        {
            c = b.Count(i => str2.Contains(i));
            return c - b.Length ;
        }
        public static string Rstring(string b) 
        {   
            return new string(b.Reverse().ToArray());
        }
        public static string RDuplicates(string b)
        {
            return new string(b.Distinct().ToArray());
        }
        public static string RPunctuation(string b)
        {
            return new string(b.Where(i => !char.IsPunctuation(i)).ToArray());
        }
    }
}