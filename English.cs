using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30
{
    internal class English : Person
    {
        public English() { }

        public English(string name)
        {
            Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{Name} speak: Hello!");
        }
    }
}
