using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit2
{
    public class Fruit : IFruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Fruit(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
