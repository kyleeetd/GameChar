using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character.Models
{
        class Warrior : GameCharacter
        {
            public int Armor { get; private set; }

            public Warrior(string name, int level, int health, int strength)
                : base(name, level, health, 0, strength, 0)
            {
                Armor = 10;
            }

            public override void Attack()
            {
                int baseDamage = Strength * 2;
                bool isCritical = new Random().Next(100) < 20;
                int damage = isCritical ? baseDamage * 2 : baseDamage;

                Console.WriteLine($"{Name} attacks for {damage} damage{(isCritical ? " with a critical hit!" : ".")}");
            }

            public override void Defend()
            {
                bool block = new Random().Next(100) < 15;
                if (block)
                {
                    Console.WriteLine($"{Name} blocks the attack completely!");
                }
                else
                {
                    int damageReduction = Armor / 2;
                    Console.WriteLine($"{Name} reduces the incoming damage by {damageReduction}.");
                }
            }

            public override void LevelUp()
            {
                Level++;
                Strength += 5;
                Health += 20;
                Armor += 2;

                Console.WriteLine($"{Name} leveled up to {Level}! Strength, health, and armor have increased.");
            }
        }

        

}
