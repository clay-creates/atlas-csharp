using System;

/// <summary>
/// class representing a player character
/// </summary>
public class Player
{
    /// <summary>
    /// Gets or sets the name of the player
    /// </summary>
    /// <value>name string</value>
    private string name { get; set; }
    /// <summary>
    /// Gets or sets the value of player max hp
    /// </summary>
    /// <value>float health value</value>
    private float maxHp { get; set; }
    /// <summary>
    /// Gets or sets the value of player current hp
    /// </summary>
    /// <value>float current hp value</value>
    private float hp { get; set; }

    /// <summary>
    /// player constructor creates instance of player class
    /// </summary>
    /// <param name="name">default "Player"</param>
    /// <param name="maxHp">default 100f</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
