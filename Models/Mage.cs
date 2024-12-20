using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character.Models 
{ 

        class Mage : GameCharacter
        {
            public int SpellPower { get; private set; }

            public Mage(string name, int level, int health, int mana, int intelligence)
                : base(name, level, health, mana, 0, intelligence)
            {
                SpellPower = 10;
            }

            public override void Attack()
            {
                int baseDamage = Intelligence * 3 + SpellPower;
                bool isBurning = new Random().Next(100) < 25;
                Console.WriteLine($"{Name} casts a spell for {baseDamage} damage{(isBurning ? " and applies a burning effect!" : ".")}");
            }

            public override void Defend()
            {
                bool evade = new Random().Next(100) < 20;
                if (evade)
                {
                    Console.WriteLine($"{Name} evades the attack completely!");
                }
                else
                {
                    int damageReduction = Mana / 4;
                    Console.WriteLine($"{Name} reduces the incoming damage by {damageReduction}.");
                }
            }

            public override void LevelUp()
            {
                Level++;
                Intelligence += 5;
                Mana += 15;
                SpellPower += 3;

                Console.WriteLine($"{Name} leveled up to {Level}! Intelligence, mana, and spell power have increased.");
            }
        }
    
}
