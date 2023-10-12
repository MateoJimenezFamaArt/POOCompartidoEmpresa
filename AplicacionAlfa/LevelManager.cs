using System;

public class LevelManagerSystem
{

    private int currentLevel;
    private Character player;

    public LevelManager(Character player)
    {
        this.player = player;
        currentLevel = 1;

    }

}

class Character // Character class that controls the character object. It is necessary to keep track of current level (as the character changes per level) and to know when the level should change, since it needs to know if the character dies.
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Character(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void SpecialMove()
    {
        Console.WriteLine($"{Name} realiza un ataque poderoso!");
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} se defiende. El proximo ataque vera su daño reducido.");
    }

}
