using System;

public class Loops
{
    public Loops() { }


    //Using while loop to reverse a number
    public void whileLoop(int n)
    {
        int temp = 0, rev = 0;
        while (n != 0)
        {
            temp = n%10;
            rev = (rev * 10) + temp;
            n /= 10;
        }
        Console.WriteLine(rev);
    }

    public void doWhileLoop()
    {
        string input;
        int number;

        do
        {
            Console.Write("Enter a number between 1 and 10: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out number) || number < 1 || number > 10);

        Console.WriteLine("You entered: {0}", number);

    }

    public void forLoop()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteration {0}", i + 1);
        }
    }

    public void forEachLoop()
    {
        int[] arr = new int[10]; //array: a fix sized collection of homogenous elements
        for(int i = 1; i <= arr.Length; i++) arr[i - 1] = i; //storing values 

        foreach (int i in arr) Console.WriteLine(i); //using foreach loop to iterate over the elements present in the collection
        
    }

    //program to check whether a number is prime or not.
    public bool isPrime(int number)
    {
        for(int i = 2; i*i <= number; i++)
        {
            if (number % i == 0)
                return false;
            
        }
        return true;
    }
}