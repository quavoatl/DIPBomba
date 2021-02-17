using System;
using System.Collections.Generic;
using Composite.ConcreteClasses;
using Composite.Interfaces;


namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMenuComponent breakfastMenu = new Menu("BreakFast", "Things you can eat in the morning");
            AbstractMenuComponent lunchMenu = new Menu("Lunch", "Things you can eat from 12:00 to 14:00");
            AbstractMenuComponent dinnerMenu = new Menu("Dinner", "Things you can eat in the afternoon");
            List<AbstractMenuComponent> allMenus = new List<AbstractMenuComponent>(new AbstractMenuComponent[] { breakfastMenu, lunchMenu, dinnerMenu });

            breakfastMenu.add(new MenuItem("Porridge", "Ovaz cu lapte, banana si afine", true, 3.12));
            breakfastMenu.add(new MenuItem("Oua fierte", "Oua fierte cu paine si salam", false, 4.42));
            breakfastMenu.add(new MenuItem("Ceai", "Ceai cu dulceata si unt", true, 2.52));

            lunchMenu.add(new MenuItem("Angus Burger", "Chfila, rosii, ceapa, carne vita", false, 20.50));
            lunchMenu.add(new MenuItem("Cheese Burger", "Chfila, rosii, cascaval, carne vita", false, 17.50));
            lunchMenu.add(new MenuItem("Soy Burger", "Chfila, rosii, cheddar, soy  beans", true, 14.50));

            AbstractMenuComponent dessertsInLunchMenu = new Menu("Desserts", "Delicious desserts for your lunch");

            dessertsInLunchMenu.add(new MenuItem("Cheesecake", "Prajitura cu branza si afine", true, 12.00));
            dessertsInLunchMenu.add(new MenuItem("Clatite", "Clatite cu finetti", true, 10.00));
            lunchMenu.add(dessertsInLunchMenu);

            dinnerMenu.add(new MenuItem("Orez", "orez cu legume", true, 5.20));
            Chelner chelner = new Chelner(allMenus);
            //chelner.print();
            chelner.Print(new VegetarianSpecification());
            Console.WriteLine("**********************");
            chelner.Print(new PriceLowerThan5());
            Console.WriteLine("**********************");
            chelner.Print();




        }
    }
}
