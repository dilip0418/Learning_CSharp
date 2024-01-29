using System;

public class Conditionals
{
    public Conditionals() {}

    public void ifBlock()
    {
        int n, number;
        Console.WriteLine("Enter any number");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            n = number;
            Console.WriteLine("The number {0} and it's a valid number...!", n);
        }
        else Console.WriteLine("Invalid Number...!");
    }

    public void ifElseIFBLock()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 10)
        {
            Console.WriteLine("The value of n is 10");
        }
        else if (n <= 10)
        {
            Console.WriteLine("The value of n is less than 10");
        }
        else
        {
            Console.WriteLine("The value is greater than 10");
        }
    }
}