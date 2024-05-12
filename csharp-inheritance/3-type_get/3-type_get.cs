using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type objInfo = myObj.GetType();

        Console.WriteLine($"{objInfo.name} Properties:");
        foreach (PropertyInfo objProp in objInfo.GetProperties())
        {
            Console.WriteLine(objProp.Name);
        }

        Console.WriteLine($"{info.Name} Methods:");
        foreach (MethodInfo objMethod in objInfo.GetMethods())
        {
            Console.WriteLine(objMethod.Name);
        }
    }
}
