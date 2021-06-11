using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaFactory.Classes
{
    public class SimpleFabriqueDePizzas
    {
        /// <summary>
        /// la fabrique responsable de la creation des objetcs Pizza
        /// </summary>
        /// <param name="typePizza"></param>
        /// <returns></returns>



        public static IPizza GetPizza(string typePizza)
        {
            IPizza pizza = null ;
            // ToDo
            if(typePizza == "Fromage")
            {
                pizza = new PizzaFromage();
            }
            else if(typePizza == "Poivrons")
            {
                pizza = new PizzaPoivronsBrest();
            }

            return pizza;
        }
    }
}
