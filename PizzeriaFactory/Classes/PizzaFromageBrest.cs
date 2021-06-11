using System;

namespace PizzeriaFactory.Classes
{
    internal class PizzaFromageBrest : IPizza
    {
        public void couper()
        {
            Console.WriteLine("Coupage Fromage Brest");
        }

        public void Cuire()
        {
            Console.WriteLine("Cuison Fromage Brest");
        }

        public void Preparer()
        {
            Console.WriteLine("Prepa Fromage Brest");
        }
    }
}