using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            var NewHuman = new Human("Keo", 10, 50, 5, 20);
            Console.WriteLine($"This is first guy {NewHuman.Name}");
            NewHuman.DisplayInfo();
            Console.WriteLine("-------------------------");
            var NewHuman2 = new Human("Oli");
            Console.WriteLine("-------------------------");
            NewHuman.Attack(NewHuman2);
            NewHuman2.DisplayInfo();
            Console.WriteLine("-------------------------");
            Wizard NewWiz = new Wizard("Sasha");
            NewWiz.DisplayInfo();
            Console.WriteLine("-------------------------");
            Ninja NewNinja = new Ninja("Alex", 14, 50, 100);
            NewNinja.DisplayInfo();
            Console.WriteLine("-------------------------");
            Samurai NewSami = new Samurai("Foru", 4, 63, 71);
            int var = NewSami.HealthProp;
            NewSami.DisplayInfo();
            // Wizard attack HUM
            NewWiz.Attack(NewHuman);            
            Console.WriteLine("------------NEW HUm-------------");
            NewHuman.DisplayInfo();
            // Ninja attack Hum
            NewNinja.Attack(NewHuman);         
            Console.WriteLine("-----------NEW Hum--------------");
            NewHuman.DisplayInfo();
            // Samurai attack Hum
            NewSami.Attack(NewHuman);         
            Console.WriteLine("-----------NEW Sam--------------");
            NewHuman.DisplayInfo();

             // Wizard HEALS Hum
            Console.WriteLine("-----------WIZ heals Hum--------------");
            NewWiz.Heal(NewHuman);
            NewHuman.DisplayInfo();

            // Samurai MEDITATE
            Console.WriteLine("-----------OLD Sam--------------");
            NewHuman.Attack(NewSami); 
            NewSami.DisplayInfo();
            NewSami.Meditate(var);
            Console.WriteLine("-----------NEW Sam--------------");
            NewSami.DisplayInfo();

            // Ninja STEAL
            NewHuman.DisplayInfo();
            NewNinja.Steal(NewHuman);         
            Console.WriteLine("-----------NEW NIN--------------");
            NewNinja.DisplayInfo();
            Console.WriteLine("-----------NEW Hum--------------");
            NewHuman.DisplayInfo();







        }
    }
}
