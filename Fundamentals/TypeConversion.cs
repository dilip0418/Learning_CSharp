using System;


/// <summary>
/// Demonstrates the concept of TypeConversion in C#
/// </summary>
public class TypeConversion
{
    public TypeConversion()
    {
    }

    public static void implicitTypeConversion()
    {
        int i = 200;

        //implicit type conversion
        float f = i;

        char c = 'a';
        int d = c;

        Console.WriteLine(d);//output: 97 [Ascii code of 'a' is 97]

        //explanation: Data contained in a variable with a smaller memory size can be set into a variable with a larger memory size.
    }

    public static void explicitTypeConversion()
    {
        float f = 200.015F;
        //explicit type conversion - (as float holds the decimal values if we assign a float value to an integer the decimal value will be lost and the compiler will throw an error as "cannot implicitly convert float to int
        //int j = f;


        //Explicit Conversion
        //Possible fixes
        int j = (int)f; //using type cast operator


        //string number = "2000"; - successfully converts to integer
        string number = "200T0";
        //      int k = int.Parse(number); //Throws an error - string '200T0' isn't in a correct format.
        //Console.WriteLine(number);

        int l;
        //Using TryParse method to tackle the above unhandled exception
        if (int.TryParse(number, out l))
            Console.WriteLine(l);
        else
            Console.WriteLine("Invalid format of number for type conversion....!");
    }
}
