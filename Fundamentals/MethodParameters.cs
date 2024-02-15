using System;

class MethodParameters
{
    //Mehod Parameters are of 4 types:
    /*
     * 1. Value Parameters
     * 2. Reference Parameter
     * 3. out parameters
     * 4. Parameter Arrays
     */
     //1. Value Parameters
     public void printNumber(int Number)
    {
        Console.WriteLine("This is a method which demonstrates value parameters and here's the value parameter: {0}", Number);
    }

    //Reference Parameters
    public void changeNumber(ref int Num)
    {
        Num = 100;
    }

    //Out Parameters
    public void Calculate(int Num1, int Num2, out int Sum, out int Product)
    {
        Sum = Num1 + Num2;
        Product = Num1 * Num2;
    }

    //Parameter Arrays - Using the "params" attribute/keyword we can invoke the methods with/without parameters (means optional)
    public void printNumbers(params int[] Numbers)
    {
        foreach(int i in Numbers)
            Console.WriteLine(i);
    }

}

