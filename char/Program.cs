using System;

abstract class GameCharacter
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }

    protected GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
    {
        Name = name;
        Level = level;
        Health = health;
        Mana = mana;
        Strength = strength;
        Intelligence = intelligence;
    }

    public abstract void Attack();
    public abstract void Defend();
    public abstract void LevelUp();

    public override string ToString()
    {
        return $"{Name} - Level: {Level}, Health: {Health}, Mana: {Mana}, Strength: {Strength}, Intelligence: {Intelligence}";
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        
        Warrior thor = new Warrior("Thor", 1, 100, 15);
        Mage merlin = new Mage("Merlin", 1, 80, 50, 20);

        
        Console.WriteLine("Initial State:");
        Console.WriteLine(thor);
        Console.WriteLine(merlin);

        
        Console.WriteLine("\nActions:");
        thor.Attack();
        thor.Defend();
        thor.LevelUp();

        merlin.Attack();
        merlin.Defend();
        merlin.LevelUp();

        
        Console.WriteLine("\nUpdated State:");
        Console.WriteLine(thor);
        Console.WriteLine(merlin);
    }
}
