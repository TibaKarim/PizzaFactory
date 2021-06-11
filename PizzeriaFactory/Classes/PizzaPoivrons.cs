using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzaPoivrons:Pizza
    {


        public override void Cuire()
        {
            Console.WriteLine("Cuison Poivrons");
        }

        public override void couper()
        {
            Console.WriteLine("Coupage Poivrons");
        }
    }
}
