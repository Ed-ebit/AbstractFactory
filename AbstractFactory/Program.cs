// See https://aka.ms/new-console-template for more information
// Frag: was soll die abstrakte Fabrik können? - Familie von Produkten erstellen ok.- aber ein einzelnes zu einer vorhandenen hinzufügen?
// Kann das pattern nicht allein oder?
// Vgl https://refactoring.guru/design-patterns/abstract-factory
//vs.
//https://www.philipphauer.de/study/se/design-pattern/abstract-factory.php

using AbstractFactory.Classes;

Console.WriteLine("Hallo! Abstract Factory for Creation of Varying Sets of product-types here!");
Console.WriteLine("Holz oder Metallhaus?");
string selection = null;
while (selection == null)
{
    selection = Console.ReadLine();
    selection = selection.ToLower();
    if (selection == "holz")
    {
        WoodenFactory generator = new WoodenFactory();
        Console.WriteLine("Holzhaus!");
    }
    if (selection == "metall")
    {
        MetallFactory generator = new MetallFactory();
        Console.WriteLine("Metallhaus!");

    }
}
