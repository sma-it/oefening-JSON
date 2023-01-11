using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToFile.Models
{
    internal interface IItem
    {
        string Name { get; set; }

        public void DisplayContents();
    }
}
