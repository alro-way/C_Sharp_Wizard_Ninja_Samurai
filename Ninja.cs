using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{
    class Ninja: Human
    {
        public Ninja(string Niname, int Nistr, int Niintel, int Niheal) : base(Niname)
        {
            this.Name = Niname;
            this.Strength = Nistr;
            this.Intelligence = Niintel;
            this.Dexterity = 175;
            this.Health = Niheal;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is NINJA");
            base.DisplayInfo();
        }

        public override int Attack(Human target)
        {
            int temp = Dexterity * 5;
            target.Dexterity -= temp;
            Random RandChance = new Random();
            int randInt = RandChance.Next(1,5);
            if (randInt == 1)
            {
                target.Dexterity -= 10;
            }
            Console.WriteLine($"This guy '{this.Name}' attacked this guy '{target.Name}' Dexterity: {target.Dexterity}");
            return target.Dexterity;
        }
        public int Steal(Human target)
        {
            int temp = 5;
            target.HealthProp -= temp;
            this.HealthProp += temp;
            Console.WriteLine($"This Ninja'{this.Name}' with health {this.HealthProp} STEAL from '{target.Name}' and his health now is: {target.HealthProp}");
            return target.HealthProp;
        }





    }
} 