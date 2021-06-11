using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzaFromage: IPizza
    {

        public  void Cuire()
        {
            Console.WriteLine("Cuison Fromage");
        }

        public  void couper()
        {
            Console.WriteLine("Coupage Fromage");
        }

        public void Preparer()
        {
            Console.WriteLine("Preparation Fromage");
        }
    }
}
