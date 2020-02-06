using System;
using System.Collections.Generic;

namespace C_Sharp_Human
{

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int Health;

        //"getter" property with set value (so attack method wil be able to add scores to health)
        public int HealthProp
        {
            get
            {
                return Health;
            }
            set{
                Health = value;
            }
        }
        //  constructor 1
        public Human(string Hname)
        {
            Name = Hname;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        // constructor 2
        public Human(string Hname, int Hstr, int Hintel, int Hdex, int HHeal)
        {
            this.Name = Hname;
            this.Strength = Hstr;
            this.Intelligence = Hintel;
            this.Dexterity = Hdex;
            this.Health = HHeal;
        }
        //method
        public virtual int Attack(Human target)
        {
            int temp = 5 * Strength;
            target.Health -= temp;
            Console.WriteLine($"This guy '{this.Name}' attacked this guy '{target.Name}' health: {target.HealthProp}");
            return target.Health;
        }
        //method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Strength is {Strength}");
            Console.WriteLine($"Intelligence is {Intelligence}");
            Console.WriteLine($"Dexterity is {Dexterity}");
            Console.WriteLine($"Health is {Health}");
        }

    }
}