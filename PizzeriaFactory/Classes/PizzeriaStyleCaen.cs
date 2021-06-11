using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class PizzeriaStyleCaen : Pizzeria
    {
        public override IPizza creerPizza(string typePizza)
        {
            IPizza pizza = null;
            // ToDo
            if (typePizza == "Fromage")
            {
                pizza = new PizzaFromageCaen();
            }
            else if (typePizza == "Poivrons")
            {
                pizza = new PizzaPoivronsCaen();
            }

            return pizza;
        }
    }
}
