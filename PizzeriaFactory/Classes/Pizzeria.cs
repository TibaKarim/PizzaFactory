using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class Pizzeria
    {
        // Le Client

        public void CommanderPizza(string type)
        {
            IPizza pizza;
            pizza = SimpleFabriqueDePizzas.GetPizza(type);
            pizza.Preparer();
            pizza.Cuire();
            pizza.couper();
        }
        
    }
}
