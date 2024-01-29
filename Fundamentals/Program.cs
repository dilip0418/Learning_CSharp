using System;

class Program
{
    private static void Main(string[] args)
    {

        //Writng to the console
        Console.WriteLine("Hello, World!");

        //Console.WriteLine("Enter roll No:");

        ////Reading from the console
        //int roll = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter name:");
        //string name = Console.ReadLine();

        //Console.WriteLine("Enter stream");
        //string stream = Console.ReadLine();
        ////var name = Console.ReadLine();

        ////Using placeholder syntax.
        ////Console.WriteLine("Hi {0}, nice meeting you!", name);

        ////Using sting concatenation syntax.
        ////Console.WriteLine("Hi " + name + ", nice meeting you!");

        //Variables c = new Variables(roll, name, stream);
        //Console.WriteLine(c.ToString());

        //Operators
        //Operators op1 = new Operators(10, 20);
        ////Operators op2 = new Operators(10,20);
        //Operators op2 = new Operators(10, 30);

        //Console.WriteLine(op1.Equals(op2));

        //TypeConversion
        TypeConversion.implicitTypeConversion();
        TypeConversion.explicitTypeConversion();
        
    }
}