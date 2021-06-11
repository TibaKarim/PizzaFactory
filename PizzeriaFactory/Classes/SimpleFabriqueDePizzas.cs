using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class SimpleFabriqueDePizzas
    {
        //Methode
        public Pizza creerPizza(string typePizza)
        {
            Pizza pizza = null ;
            // ToDo
            if(typePizza == "Fromage")
            {
                pizza = new PizzaFromage();
            }
            else if(typePizza == "Poivrons")
            {
                pizza = new PizzaPoivrons();
            }

            return pizza;
        }
    }
}
