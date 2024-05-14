using System;

abstract class Base
{
    public string name = "";
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    public int durability { get; set; }
    void Break();
}

interface ICollectable
{
    public bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base : IInteractive: IBreakable: ICollectable
{
    int durability { get; set; }
    bool isCollected { get; set; }

    public void Interact
{

}
public void Break()
{

}
public void Collect()
{

}
}
