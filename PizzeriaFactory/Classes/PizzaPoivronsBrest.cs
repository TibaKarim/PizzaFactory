using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzaPoivronsBrest:IPizza
    {


        public  void Cuire()
        {
            Console.WriteLine("Cuison Poivrons Brest");
        }

        public  void couper()
        {
            Console.WriteLine("Coupage Poivrons Brest");
        }

        public void Preparer()
        {
            Console.WriteLine("Prepa Poivrons Brest");
        }
    }
}
