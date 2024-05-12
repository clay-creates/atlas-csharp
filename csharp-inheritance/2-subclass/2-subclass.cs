using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (Type == baseType)
        {
            return false;
        }

        if (Type == derivedType)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
