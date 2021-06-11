using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public  abstract class Pizzeria
    {
        // Le Client

        public IPizza CommanderPizza(string type)
        {
            IPizza pizza;
            pizza = creerPizza(type);
            pizza.Preparer();
            pizza.Cuire();
            pizza.couper();

            return pizza;
        }

        public abstract IPizza creerPizza(string type);
    }
}
