using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzaFromage: Pizza
    {

        public override void Cuire()
        {
            Console.WriteLine("Cuison Fromage");
        }

        public override void couper()
        {
            Console.WriteLine("Coupage Fromage");
        }
    }
}
