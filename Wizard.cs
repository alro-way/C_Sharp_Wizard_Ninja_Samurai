using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{
    class Wizard: Human
    {
        public Wizard(string wname) : base(wname)
        {
            Intelligence = 25;
            Health = 50;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is WIZARD");
            base.DisplayInfo();
        }

        public override int Attack(Human target)
        {
            int temp = Intelligence * 5;
            target.Intelligence -= temp;
            this.HealthProp += temp;
            Console.WriteLine($"This WIZARD '{this.Name}' attacked this guy '{target.Name}' health: {target.HealthProp} intelligence: {target.Intelligence}");
            return target.HealthProp;
        }
        public int Heal(Human target)
        {
            int temp = Intelligence * 10;
            target.Intelligence += temp;
            Console.WriteLine($"This WIZARD '{this.Name}' HEAls this guy '{target.Name}' and his intelligence now is: {target.Intelligence}");
            return target.Intelligence;
        }
        

    }
} 