﻿using System;

abstract class Base
{
    public string name { get; set; }
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
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {

    }
    public void Break()
    {

    }
    public void Collect()
    {

    }
}
