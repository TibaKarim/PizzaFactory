using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzaPoivrons:IPizza
    {


        public  void Cuire()
        {
            Console.WriteLine("Cuison Poivrons");
        }

        public  void couper()
        {
            Console.WriteLine("Coupage Poivrons");
        }

        public void Preparer()
        {
            Console.WriteLine("Prepa Poivrons");
        }
    }
}
