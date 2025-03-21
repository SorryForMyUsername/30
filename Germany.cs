using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30
{
    internal class Germany : Person
    {
        public Germany() { }

        public Germany(string name)
        {
            Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{Name} sagt: Hallo!");
        }
    }
}
