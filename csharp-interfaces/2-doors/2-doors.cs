using System;

public abstract class Base
{
    public string name { get; set; }
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public string name(value)
    {
        get { return name; }
        set { name = value; }
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
