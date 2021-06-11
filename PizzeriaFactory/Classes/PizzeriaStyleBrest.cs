using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzeriaStyleBrest : Pizzeria
    {
        public override IPizza creerPizza(string typePizza)
        {
            IPizza pizza = null;
            // ToDo
            if (typePizza == "Fromage")
            {
                pizza = new PizzaFromageBrest();
            }
            else if (typePizza == "Poivrons")
            {
                pizza = new PizzaPoivronsBrest();
            }

            return pizza;
        }
    }
}
