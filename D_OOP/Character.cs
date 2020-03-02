using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character
    {
        // public
        // internal
        // protected
        private readonly int speed;

        public int Health { get; set; } = 100;
        public string Race { get; private set; }
        public int Armor { get; private set; }

        public Character(string race)
        {
            Race = race;
            Armor = 30;
        }
        public Character(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }
        public Character(string race, int armor, int speed)
        {
            Race = race;
            Armor = armor;
            this.speed = speed;
        }

        public void Hit(int damage) {
            if (damage > Health)
            {
                damage = Health;
            }
            Health -= damage;
        }
        
   
    }
}
