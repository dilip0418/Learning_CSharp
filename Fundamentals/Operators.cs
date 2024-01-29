using System;
/// <summary>
/// Demonstrates the concept of Operators in C#
/// </summary>
public class Operators
{
    int value1;
    int value2;
    public Operators(int val1, int val2)
    {
        this.value1 = val1;
        this.value2 = val2;
    }

    public string Equals(Operators other)
    {
        //Using ternary operator for conditional flow of program control, logical operators for comparision.
        return this.value1 == other.value1 && this.value2 == other.value2 ? "Both the objects are equal" : "Objects are different";
    }

    public void variables()
    {
        //normal non nullable integer type variable
        int? x = null;

        //to make a integer type variable to store a null value "use null coalescing operator"
        int y = x ?? 0;
        Console.WriteLine(y); // Output: 0

        /*explanation: The null coalescing operator in C# is represented by ?? and is used to return the value of its left-hand operand if it is not null, and the value of its right-hand operand otherwise */
    }


}
