using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToFile.Models
{
    internal class Library
    {
        public string Name { get; set; }
        public List<IItem> Items { get; set; } = new List<IItem>();
    }
}
