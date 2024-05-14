using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_9
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;
        private int pages;
        public Book(string title, string author, int year, int pages)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }
        public void DisplayInfo() { Console.WriteLine($"Title: {title}\nAuthor: {author}\nYear: {year}\nPages: {pages}\nIsThick: {isThick()}\n"); }
        public string isThick() 
        {
            int pages = this.pages;
            if (pages <= 500) {  return "Less than 500 pages"; }
            else { return "More than 500 pages"; }
        }
        

    }
}
