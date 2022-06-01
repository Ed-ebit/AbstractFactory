// See https://aka.ms/new-console-template for more information
// Frag: was soll die abstrakte Fabrik können? - Familie von Produkten erstellen ok.- aber ein einzelnes zu einer vorhandenen hinzufügen?
// Kann das pattern nicht allein oder?
// Vgl https://refactoring.guru/design-patterns/abstract-factory
//vs.
//https://www.philipphauer.de/study/se/design-pattern/abstract-factory.php

using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

Console.WriteLine("Hello! Abstract Factory for Creation of Varying Sets of product-types here!");
Console.WriteLine("Holz oder Metallhaus?");
string selection = "";
IAbstractFactory generator = null;

do
{
    selection = Console.ReadLine();
    selection = selection.ToLower();
    if (selection == "holz")
    {
        Console.WriteLine("Holzhaus!");
        generator = new WoodenFactory();
    }
    if (selection == "metall")
    {
        Console.WriteLine("Metallhaus!");
        generator = new MetallFactory();
    }
    else Console.WriteLine("ungültige Eingabe");
} while (selection != "holz" && selection != "metall");

while (true)
{
    Console.WriteLine("press: 1 for a Roof, 2 for a wall, 3 for a Door, 4 for exit");
    selection = Console.ReadLine();
    selection = selection.ToLower();
    if (selection == "1")
    {
        generator.ProduceRoof().Description();
    }
    if (selection == "2")
    {
        generator.ProduceWall().Description();
    }
    if (selection == "3")
    {
        generator.ProduceDoor().Description();
    }
    if (selection == "4")
    {
        return;
    }
}




