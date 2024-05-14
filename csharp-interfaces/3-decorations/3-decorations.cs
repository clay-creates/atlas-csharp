using System;

/// <summary>
/// Represents a base class for objects that have a name.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

/// <summary>
/// Defines a contract for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Performs an interaction with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Defines a contract for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Breaks the object.
    /// </summary>
    void Break();
}

/// <summary>
/// Defines a contract for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets a value indicating whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collects the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents a door that can be interacted with.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the Door class.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interacts with the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// Represents an item with durability that can be interacted with
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Boolean to determine if item is a Quest Item
    /// </summary>
    public bool isQuestItem { get; set; }
    /// <summary>
    /// Initializes an instance of Decoration
    /// </summary>
    /// <param name="name">Name of the decorations</param>
    /// <param name="durability">Amount of durability of item</param>
    /// <param name="isQuestItem">Is this item a quest item?</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
    }
    /// <summary>
    /// Interacts with the decoration / item
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }

        if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You looki at the {this.name}. Not much to see here.");
        }
    }
    /// <summary>
    /// What happens at various stages of durability
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}