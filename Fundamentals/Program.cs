using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
//using ProjectA.TeamA;
//using ProjectA.TeamB;

//class Program
//{
//    private static void Main(string[] args)
//    {

//        //Writng to the console
//        Console.WriteLine("Hello, World!");

//        //Console.WriteLine("Enter roll No:");

//        ////Reading from the console
//        //int roll = int.Parse(Console.ReadLine());

//        //Console.WriteLine("Enter name:");
//        //string name = Console.ReadLine();

//        //Console.WriteLine("Enter stream");
//        //string stream = Console.ReadLine();
//        ////var name = Console.ReadLine();

//        ////Using placeholder syntax.
//        ////Console.WriteLine("Hi {0}, nice meeting you!", name);

//        ////Using sting concatenation syntax.
//        ////Console.WriteLine("Hi " + name + ", nice meeting you!");

//        //Variables c = new Variables(roll, name, stream);
//        //Console.WriteLine(c.ToString());


//        //Operators op1 = new Operators(10, 20);
//        ////Operators op2 = new Operators(10,20);
//        //Operators op2 = new Operators(10, 30);

//        //Console.WriteLine(op1.Equals(op2));

//        //TypeConversion
//        //TypeConversion.implicitTypeConversion();
//        //TypeConversion.explicitTypeConversion();


//        //Conditionals -[if,if-else, if-elseif]
//        //Conditionals cond = new Conditionals();
//        //cond.ifBlock();
//        //cond.ifElseIFBLock();

//        //Conditionals -[switch, break]
//        //cond.SwitchStatement();


//        //Loops
//        /*
//        Loops loop = new Loops();


//        //loop.whileLoop(1234);
//        //loop.doWhileLoop();
//        //loop.forLoop();
//        //loop.forEachLoop();
//        int start = int.Parse(Console.ReadLine());
//        int end = int.Parse(Console.ReadLine());
//        for(int i = start; i <= end; i++)
//            if (loop.isPrime(i))
//                Console.WriteLine(i);

//    */

//        /*
//            * 
//        Methods in C#

//        string Name = Console.ReadLine();

//        //Invoking static method using class
//        Methods.printNameStaticType(Name);

//        //Invoking instance method using an instance/object of the class
//        Methods method = new Methods();
//        method.printNameInstanceType(Name);
//        */


//        // Method Parameter Types
//        /*
//        MethodParameters mp = new MethodParameters();
//        //Value parameter
//        mp.printNumber(10);

//        //Reference Parameter
//        int i = 0;
//        Console.WriteLine("The value of i before function call is: {0}", i);
//        mp.changeNumber(ref i);
//        Console.WriteLine("The value of i after function call is: {0}", i);

//        //out parameters
//        int sum = 0, product = 0;
//        mp.Calculate(10, 20, out sum, out product);
//        Console.WriteLine("Sum = {0} and Product = {1}", sum, product);

//        //Parameter Arrays
//        int[] arr = { 1, 2, 3, 4 };
//        mp.printNumbers(arr);

//        //Invoking printNumbers method with passing arguements to it.
//        mp.printNumbers(); //if the method definition has the parameters prefixed with params keyword then we can invoke that method with/without passing the arguments prefixed with params keyword and always the paramenters must be mentioned after all the other parameters
//     */

//        //namespaces

//        //Problem that arises if you don't use namespaces
//        // ClassA.print();  Here the compiler get's confused on which class to be chosen to run because of the existence of class in both the namespaces with same name [ClassA]


//        //Calling a function present in ProjectA.TeamA namespace
//        //using fully qualified syntax

//        //ProjectA.TeamA.ClassA.print();
//        //ProjectA.TeamB.ClassA.print();

//        //using aliases
       
//        //PATA.ClassA.print();
//        //PATB.ClassA.print();

//        //We can separate the namespaces into separate assemblies/projects

//        PATA.ClassA.print();
//        PATB.ClassA.print();


//    }
//}

////namespace ProjectA.TeamA
////{
////    class ClassA
////    {
////        public static void print()
////        {
////            Console.WriteLine("Team A print method...!");
////        }
////    }
////}

////namespace ProjectA.TeamB
////{
////    class ClassA
////    {
////        public static void print()
////        {
////            Console.WriteLine("Team B print method...!");
////        }
////    }
////}