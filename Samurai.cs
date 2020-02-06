
using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{
    class Samurai: Human
    {
        public Samurai(string Saname, int Sastr, int Saintel, int Sadex) : base(Saname)
        {
            this.Name = Saname;
            this.Strength = Sastr;
            this.Intelligence = Saintel;
            this.Dexterity = Sadex;
            this.Health = 200;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is SAMURAI");
            base.DisplayInfo();
        }
        public override int Attack(Human target)
        {
            if (target.HealthProp < 50)
            {
                target.HealthProp = 0;
            }
            Console.WriteLine($"This guy '{this.Name}' attacked this guy '{target.Name}' health: {target.HealthProp}");
            return target.HealthProp;
        }
        public int Meditate(int var)
        {
            int temp = var;
            this.HealthProp = temp;
            Console.WriteLine($"This SAMURAI '{this.Name}' HEALS himself his Health now is: {this.HealthProp}");
            return this.HealthProp;
        }



    }
} 