using System;
using System.Collections.Generic;
using ISubjectComponent;
using ObserverComponent;

namespace ObserverDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IShopSubject pcGarage = new ShopSubject();

            IShopObserver user1 = new ShopObserver("gtx");
            IShopObserver user2 = new ShopObserver("skullcandy");

            pcGarage.Subscribe(user1);
            pcGarage.Subscribe(user2);

            pcGarage.UpdateListOfItems(new List<string>(new []{"procesor intel","casti sony","gtx"}));

            pcGarage.NotifyObservers();

            ListUserChoices(new List<IShopObserver>(new[] { user1, user2 }));

            pcGarage.UpdateListOfItems(new List<string>(new[] { "skullcandy" }));

            pcGarage.NotifyObservers();

            ListUserChoices(new List<IShopObserver>(new[] { user1, user2 }));

            Console.ReadKey();
        }

        public static void ListUserChoices(List<IShopObserver> list)
        {
            foreach (var shopObserver in list)
            {
                Console.WriteLine("This user has in his cart:");
                foreach (var cartItem in shopObserver.GetCartItems())
                {
                    Console.WriteLine($"--{cartItem}");
                }
            }
            Console.WriteLine("**********************");
        }
    }
}
