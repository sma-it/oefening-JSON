using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToFile.Models
{
    internal class Book : IItem
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public void DisplayContents()
        {
            Console.WriteLine("---");
            Console.WriteLine(Name);
            Console.WriteLine("Written by " + Author);
            Console.WriteLine("---");
        }
    }
}
