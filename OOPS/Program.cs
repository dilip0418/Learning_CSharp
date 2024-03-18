using System;
using OOPS;



//Classes in C#
class Person
{
    private string _firstName;

    //FirstName is a public property that provides access to the _firstName field.
    //The get accessor returns the value of the private field _firstName.
    //The set accessor sets the value of the private field _firstName to the provided value.
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }

    //shorthand form of adding getter and setter ot the fields if there public
    public string _lastName { get; set; }


    public short _age { get; set; }
    public string _nationality { get; set; }

    //Default constructor
    public Person() { }

    public Person(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public override string ToString()
    {
        return "First Name : " + this.FirstName + "\nLast Name : " + this._lastName + "\nAge : " + this._age + "\nNationality : " + this._nationality;
    }

    public static void Greet()
    {
        Console.WriteLine("Hi, Howdy");
    }

    public static void Greet(string name)
    {
        Console.WriteLine("Hi, Howdy {0}", name);
    }
}

//Static and instance members in C#
class Circle
{
    private int _radius;
    private static float _PI = 3.142F;

    public Circle(int Radius)
    {
        this._radius = Radius;
    }

    public float CalculateArea()
    {
        return _PI * this._radius * this._radius;
    }
}

//Inheitance in C#
//Parent or base Class
class Employee
{
    public string _firstName;
    public string _lastName;

    //parameterized constructor
    public Employee(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    //Whenever a default constructor is   
    public Employee() : base() { }

    public void printFullName()
    {
        Console.Write(this._firstName + " " + this._lastName);
    }
}

//Child or derived classes
class FullTimeEMployee : Employee
{
    public float monthlySalary;

    //using the base keyword to invoke a particular base class constructor - base refers to the base/parent class members
    //the below way of syntax lets the user to optional pass the parameters while creating the objects. If we miss out any params the default values for the missed parameters will be assigned to them
    public FullTimeEMployee(string fName = "No First Name", string lName = "No Last Name", float salary = 0.0F) : base(fName, lName)
    {
        this.monthlySalary = salary;
    }

    public void printFTEDetails()
    {
        base.printFullName();
        Console.WriteLine(" " + this.monthlySalary);
    }

}

class PartTimeEMployee : Employee
{
    float hourlySalary;


    public PartTimeEMployee(string fName = "No First Name", string lName = "No Last Name", float salary = 0.0F) : base(fName, lName)
    {
        this.hourlySalary = salary;
    }

    public void printPTEDetails()
    {
        base.printFullName();
        Console.WriteLine(" " + this.hourlySalary);
    }

    //Hiding base class method using "new" keyword
    public new void printFullName()
    {
        Console.WriteLine(this._firstName + " " + this._lastName + " - contractor");
    }
}

class Shape
{
    public string Color { get; set; }
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public Shape(string color, int PosX, int PosY)
    {
        this.Color = color;
        this.PositionX = PosX;
        this.PositionY = PosY;
    }
    public virtual void Draw()
    {
        Console.WriteLine("Shape: Generic \nColor: {0}\nPositionX: {1}\nPositionY: {2}", this.Color, this.PositionX, this.PositionY);
    }
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(string color, int PosX, int PosY, int width, int height) : base(color, PosX, PosY)
    {
        this.Width = width;
        this.Height = height;
    }
    public override void Draw()
    {
        Console.WriteLine("Shape: Rectangle\nColor: {0}\nPositionX: {1}\nPositionY: {2} with Width: {3} & Height: {4}", this.Color, this.PositionX, this.PositionY, this.Width, this.Height);
    }
}

class Circle1 : Shape
{
    public int Radius { get; set; }

    public Circle1(string color, int PosX, int PosY, int radius) : base(color, PosX, PosY)
    {
        this.Radius = radius;
    }
    public override void Draw()
    {
        Console.WriteLine("Shape: Circle\nColor: {0}\nPositionX: {1}\nPositionY: {2} with Radius: {3}", this.Color, this.PositionX, this.PositionY, this.Radius);
    }
}


class Animal
{
    private int _id;
    private string _Name;
    private Tuple<string, string> _Type;

    //auto implementation of getters and setter properties : Compiler BTS will create the implementations for 
    public bool isEndangered { get; set; }

    //Properties in C#
    public int ID
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Id cannot be less than or equal zero");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Name cannot be empty");
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }

    public Tuple<string, string> Type
    {
        set
        {
            if (value == null || string.IsNullOrEmpty(value.Item1) || string.IsNullOrEmpty(value.Item2))
                throw new Exception("The _Type values must be a non null non empty value");

            this._Type = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Type.Item1) || string.IsNullOrEmpty(this._Type.Item2) ? new Tuple<string, string>("No Type1", "No Type2") : this._Type;
        }
    }

    public override string ToString()
    {
        return $"Id: {this.ID}\nName: {this.Name}\nType: {this.Type.Item1}, {this.Type.Item2}";
    }

}


//Structures in C#
struct Employee1
{
    private string _firstName;
    private string _lastName;

    public string FirstName
    {
        get
        {
            return _firstName;
        }

        set
        {
            _firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return _lastName;
        }

        set
        {
            _lastName = value;
        }
    }

    //parameterized constructor
    //public Employee1(string FirstName, string LastName)
    //{
    //    this._firstName = FirstName;
    //    this._lastName = LastName;
    //}

    public void printFullName()
    {
        Console.WriteLine(this._firstName + " " + this.LastName);
    }
    //Note: structures doesn't have an explicit non parameterized constructor.
    // Structures are value type whereas classes are reference type.
}


//Interfaces in C#
interface ICompany
{
    string getName();
    void setName(string Name);
    int getNumberOfEmployees();
    void setNumberOfEmployees(int numberOfEmps);
}

interface ITest
{
    void test();
}

class TEG : ICompany, ITest
{

    private int _noOfEmployees;
    private string _companyName;

    public string getName()
    {
        return this._companyName;
    }

    public int getNumberOfEmployees()
    {
        return this._noOfEmployees;
    }

    public void setName(string Name)
    {
        this._companyName = Name;
    }

    public void setNumberOfEmployees(int numberOfEmps)
    {
        this._noOfEmployees = numberOfEmps;
    }

    public override string ToString()
    {
        return $"Company Name: {this.getName()}\nNo of Employees: {this.getNumberOfEmployees()}";
    }

    public void test()
    {
        Console.WriteLine("Test Interface method.");
    }
}

interface I1
{
    void print();
}

interface I2
{
    void print();
}

//Abstract classes in C#
public abstract class Vehicle
{
    //An abstract class can have abstract & composite methods also.
    //An abstract class cannot be sealed.
    //If any class has an abstract method then it must be marked as abstract.
    //Any class inheriting the abstract class must implement all the abstract methods of the base class otherwise it should also be marked as abstract.


    public abstract void startVehicle();
    public void honk()
    {
        Console.WriteLine("Vehicle Honking...!");
    }

}

//The Diamond Problem
/*
class A
{
    public virtual void Print()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("Class B");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("Class C");
    }
}

//Here class D inherits both B & C class and doesn't implement the "Print" method so when class c object invokes the Print method their arises an ambiguity of whcih method to be invoked B's or C's. This ambiguit is know as the Diamond problem.
class D: B, C
{
    
}
*/

//class Program : I1, I2
//class Program: Vehicle
class Program
{
    public static void Main(string[] args)
    {

        //Person person = new Person()
        //{
        //    FirstName = "Dilip",
        //    _lastName = "Kumar B K",
        //    _age = 23,
        //    _nationality = "Indian"
        //};
        //Console.WriteLine("Person Details:\n" + person);

        //Circle circle1 = new Circle(10);
        //float area1 = circle1.CalculateArea();
        //Console.WriteLine("The area of the circle is : {0}", area1);



        //Inheritance

        //FullTimeEMployee FTE = new FullTimeEMployee("Dilip", "Kumar B K", 50000);
        ////FTE.printFullName();

        //FTE.printFTEDetails();

        //PartTimeEMployee PTE = new PartTimeEMployee("Shivesh", "V G", 1500);
        //PTE.printPTEDetails();

        ////In the below object the salary argument isn't passed so it'll take default value 0.0F
        //FullTimeEMployee FTE1 = new FullTimeEMployee("Ganesh","Chitriki");

        //FTE1.printFTEDetails();


        //Hiding base class methods
        //PartTimeEMployee PTE = new PartTimeEMployee();
        //PTE.printFullName();

        //Polymorphism 
        /*
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("Red", 10, 10, 3, 5));
        shapes.Add(new Circle1("Blue", 5, 5, 5));

        foreach (Shape shape in shapes)
            shape.Draw();
            */


        //Method Overloading
        /*
        Person.Greet();
        Person.Greet("Martin");
        */


        //Properties in C#
        /*
        Animal animal = new Animal();
        animal.ID = 101;
        animal.Name = "Lion";
        animal.Type = new Tuple<string,string>("Wild","Carnivores");

        Console.WriteLine("Animal Details:\n{0}", animal);

        Console.WriteLine("");

        Animal animal2 = new Animal();
        animal2.ID = 102;
        animal2.Name = "Cow";
        animal2.Type = new Tuple<string, string>("Domestic", "Herbivores");
        Console.WriteLine(animal2);
        */

        //Structures
        ///Structures are sealed types - a sealed entity restricts inheritance
        //Using object initializer syntax to initialize the employee object.
        /*
        Employee1 employee = new Employee1()
        {
            FirstName= "Chris",
            LastName = "Hemsworth"
        };

        employee.printFullName();
        */

        //Interfaces
        /*
        TEG teg = new TEG();
        teg.setName("TEG Global Infrastructures Pvt Ltd");
        teg.setNumberOfEmployees(18);
        Console.WriteLine($"Company details:\n{teg}");
        teg.test();

        Program P = new Program();

        //Note: Explicitly implemented methods shouldn't be prefixed with access modifiers
        //We cannot invoke an Explicitly implemented method with the object reference, it can be done using interface reference only.

        P.print(); //this will default to the print method implemented for Interface I1.

        ((I2)P).print(); //type casting the object of type Program to Inteface of type I2.
        //or
        I2 i2 = new Program(); //As we know that a base class reference can be used to create an object of child class
        i2.print();
        */

        //Abstract related code

        /*Vehicle vehicle = new Program();
        vehicle.startVehicle();

        vehicle.honk();
        */


        //Indirectly achieving Mutliple inheritance using interfaces
        /*
        AB ab = new AB();
        ab.APrint();
        ab.BPrint();
        */

    }




    //Note: A class implementing an Interface (I1) which inturn inherits another interface (I2), should implement all the methods of Interface (I1) & Interface (I2).

    //Explicit impletation for interface methods

    //Default method implementation - I1 inteface
    /*
    public void print()
    {
        Console.WriteLine("I1 interface print method");
    }

    //Explicitly implemented method
    void I2.print()
    {
        Console.WriteLine("I2 interface print mehtod");
    }
    */


    //Abstract type entities (classes, methods, etc)
    /*
    public override void startVehicle()
    {
        Console.WriteLine("Vehicle Started.");
    }
    */

    



}


