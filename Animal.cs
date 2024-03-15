using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Animal
    {
        public abstract string Speak();
        public virtual void Move() // Виртуальный метод передвижения
        {
            Console.WriteLine("Животное двигается");
        }
        public virtual void Sit()
        {
            Console.WriteLine("Животное сидит");
        }
    }
}
