using System;
using PizzeriaFactory.Classes;
namespace PizzeriaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pizzeria BoutiqueBrest = new PizzeriaStyleBrest();
            IPizza pizza = BoutiqueBrest.CommanderPizza("Fromage");


           


        }
    }
}
