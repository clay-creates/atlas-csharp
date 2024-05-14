using System;
using System.Collections.Generic;

abstract class Base
{
    public abstract string name { get; }
    public override string ToString()
    {
        return $"{name} is a {this.GetType().name}";
    }
}
