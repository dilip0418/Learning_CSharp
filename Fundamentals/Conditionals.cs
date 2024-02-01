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

    public void SwitchStatement()
    {
        Console.WriteLine("Enter any number:");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", n);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30...");
                break;
        }
    }
}