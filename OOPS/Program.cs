using System;
using System.Collections.Generic;



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
            if(value <= 0)
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
}


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




    }
}


