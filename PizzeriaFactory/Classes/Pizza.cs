using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public abstract class Pizza
    {



        //Methode
        public void Preparer()
        {
            Console.WriteLine("Prepa");
        }

        public virtual void Cuire()
        {
            Console.WriteLine("Cuison");
        }
        public  virtual void couper()
        {
            Console.WriteLine("Coupage");
        }
    }
}
