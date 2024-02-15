using System;
class Methods
{
    /*Methods are of two types
    *1. Static methods &
    * 2. Instance methods.
    */

    //Static method
    public static void printNameStaticType(string Name)
    {
        Console.WriteLine("Hello! my name is {0}", Name);
    }

    public void printNameInstanceType(string Name)
    {
        Console.WriteLine("Hello! my name is {0}", Name);
    }
}
