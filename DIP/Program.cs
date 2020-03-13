using System;
using DIP.Classes;
using DIP.Interfaces;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PersoanaCuPermisacio persoanaCuPermisacio = (PersoanaCuPermisacio)
                Factory.CreateAPerson(Enums.PersonType.PersoanaCuPermis);
            PersoanaAutorizata persoanaAutorizata = (PersoanaAutorizata)
                Factory.CreateAPerson(Enums.PersonType.PersoanaAutorizata);



            persoanaAutorizata.BagaCategorieInPermis(persoanaCuPermisacio,
                Enums.CategoriePermis.TIR);

            persoanaCuPermisacio.CumparaVehicul(Enums.VehiculDetinut.TIR);

            Politianu politianu = (Politianu)
                Factory.CreateAPerson(Enums.PersonType.Politianu);

            politianu.VerificaPulaiDePermis(persoanaCuPermisacio);
        }
    }
}
