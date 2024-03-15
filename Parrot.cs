using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Parrot : Animal, IFlyer
    {
        public override string Speak() => "Привет, привет!";
        public override void Sit() => Console.WriteLine("Попугай сидит");
        public void Fly() => Console.WriteLine("Попугай летит");
    }
}
