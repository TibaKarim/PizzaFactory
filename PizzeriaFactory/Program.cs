using System;
using PizzeriaFactory.Classes;
namespace PizzeriaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SimpleFabriqueDePizzas fabrique = new SimpleFabriqueDePizzas();

            Pizzeria client = new Pizzeria(fabrique);
            string type = "Fromage";

            client.commanderPzza(type);


        }
    }
}
