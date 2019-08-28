using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class Task
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Customer { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
