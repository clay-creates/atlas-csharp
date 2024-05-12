using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubClassOf(baseType))
        {
            return !baseType.IsAssignableFrom(derivedType);
        }
        else
        {
            return false;
        }
    }
}
