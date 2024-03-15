using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dog : Animal, ISwimmer, IRun
    {
        public void Run() => Console.WriteLine("Собака бежит");

        public override string Speak() => "Гав-гав";
        public override void Sit() => Console.WriteLine("Собака сидит");
        public void Swim() => Console.WriteLine("Собака плывет");
    }
}
