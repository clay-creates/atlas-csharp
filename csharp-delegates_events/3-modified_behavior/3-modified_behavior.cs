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
    /// <summary>
    /// prints the players current health
    /// </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Delegate blueprint for methods that calculate health
    /// </summary>
    /// <param name="amount">a float amount to be used for damage or healing</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Method for calculating damage amounts
    /// </summary>
    /// <param name="damage">float amount of damage to player</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            System.Console.WriteLine($"{name} takes 0 damage!");
            return;
        }
        else
        {
            System.Console.WriteLine($"{name} takes {damage} damage!");
        }
        ValidateHP(this.hp - damage);

    }

    /// <summary>
    /// Method for calculating healing amounts
    /// </summary>
    /// <param name="heal">float amount of healing to player</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            System.Console.WriteLine($"{name} heals 0 HP!");
            return;
        }
        else
        {
            System.Console.WriteLine($"{name} heals {heal} HP!");
        }
        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Validates the calculated health changes from taking dmg or getting healed
    /// </summary>
    /// <param name="newHp">var to update player hp</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    /// <summary>
    /// Method to apply calulations to base by modifier from enum
    /// </summary>
    /// <param name="baseValue">value to calculate</param>
    /// <param name="modifier">what to calculate by</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float returnVal = baseValue;
        switch (modifier)
        {
            case Modifier.Weak:
                returnVal = baseValue * 0.5f;
                break;
            case Modifier.Strong:
                returnVal = baseValue * 1.5f;
                break;
            case Modifier.Base:
                returnVal = baseValue * 1f;
                break;
        }
        return returnVal;
    }
}

/// <summary>
/// Enum for different calfulation modifiers
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// Delegate blueprint for Calculations using the Modifier Enums
/// </summary>
/// <param name="baseValue">float to be calculated</param>
/// <param name="modifier">modifier from enum to use in calculation</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);