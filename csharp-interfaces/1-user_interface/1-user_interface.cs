using System;

abstract class Base
{
    public string name = "";
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    public int durability;
    void Break();
}

public interface ICollectable
{
    public bool isCollected;
    void Collect();
}

class TestObject : Base : IInteractive: IBreakable: ICollectable
{

}
