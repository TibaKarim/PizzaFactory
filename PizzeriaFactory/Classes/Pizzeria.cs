using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class Pizzeria
    {

        SimpleFabriqueDePizzas _fabrique;
        
        public Pizzeria(SimpleFabriqueDePizzas fabrique)
        {
            _fabrique = fabrique;
        }

        public Pizza commanderPzza(string type)
        {
            Pizza pizza;
            pizza = _fabrique.creerPizza(type);

            pizza.Preparer();
            pizza.Cuire();
            pizza.couper();


            return pizza;
        }

    }
}
