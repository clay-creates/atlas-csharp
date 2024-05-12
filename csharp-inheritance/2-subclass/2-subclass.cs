﻿using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return!baseType.IsAssignableFrom(derivedType);
        }
        else
        {
            return false;
        }
    }
}
