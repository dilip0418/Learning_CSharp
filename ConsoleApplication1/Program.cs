using System;
using System.Collections.Generic;


//Delegates - A delegate a type safe function pointer.
public delegate void HelloDelegate(string Message);

public delegate bool IsPromotable(Employee employee);

delegate int DelMultiCast(int x);

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public float Salary { get; set; }
    public int Experience { get; set; }

    public Employee(int id, string name, float salary, int experience)
    {
        this.ID = id;
        this.Name = name;
        this.Salary = salary;
        this.Experience = experience;
    }

    public static void Promotable(List<Employee> employees, IsPromotable isEligibleForPromotion)
    {
        foreach (Employee employee in employees)
        {

            /*
            Here the logic is hardcode whcih checks the employees experience for promotion,
            However this method is limiting the functionality to only this criteria whereas different
            companies has different criterion to promote their employees.

            if(employee.Experience >= 5)
                Console.WriteLine("Employee elilgible for Promotion...!");
            else
                Console.WriteLine("Employee not elilgible for Promotion...!");
             */

            /*
             * Decoupling the Employee class with the use of delgates
             */
            if (isEligibleForPromotion(employee))
                Console.WriteLine($"{employee.Name} is elilgible for Promotion...!");
            else
                Console.WriteLine($"{employee.Name} isnot elilgible for Promotion...!");
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        //Create a delegate similar to a cretion of class - Pass the reference of the function as an arguement
        //Ways to point a delegate to point to a funtion.
        //HelloDelegate hDel = p.Hello;
        //or
        HelloDelegate hDel = new HelloDelegate(Hello);
        hDel("Hello how are you!, I am a delegate");


        List<Employee> employeeList = new List<Employee>();

        employeeList.Add(new Employee(101, "Shivaranjani", 500000, 5));
        employeeList.Add(new Employee(101, "Ganesh", 400000, 3));
        employeeList.Add(new Employee(101, "Shivesh", 300000, 4));
        employeeList.Add(new Employee(101, "Rohith", 600000, 6));


        //Using Delegate to decouple the criterion whcih was hardcoded in the employee entity
        IsPromotable isEligibleForPromotion = new IsPromotable(Promote);
        Employee.Promotable(employeeList, isEligibleForPromotion);



        /*
         * Using lambda expressions to cut short the code
         * lamda expression is an inline, anonymous funtion 
         * behind the scenes the compiler creates a delegate passes the function and executes the
         * fuctionality.
         */
        Console.WriteLine("\n\nUsing Lamda expressions:");
        Employee.Promotable(employeeList, employee => employee.Experience >= 5);


        //Multicast Delegate - with lambda expressions
        DelMultiCast mulDelOne;

        /*
         * using the "+" operator for chaining multiple delegate to a single delegate and "+=" operator used to assign multiple methods to single delegate variable.
         */
        // Assign a lambda expression to the delegate
        mulDelOne = x => x * x;

        // Invoke the delegate
        mulDelOne += x => x * x * x;
        Console.WriteLine(mulDelOne(5));


        //Attributes in C# - attrubutes are class that attach some metadata to classes, methods,properties, etc.
        Console.WriteLine(Attributes.Add(9, 10));
        int[] nums = { 1, 2, 3, 4, 5 };
        List<int> numbers = new List<int>();
        foreach(int i in nums)
        {
            numbers.Add(i);
        }
        Console.WriteLine(Attributes.Add(numbers));

    }

    public static void Hello(string Message)
    {
        Console.WriteLine(Message);
    }

    //Function which checks the criterion for Promotion - decoupled logic from the employee class
    public static bool Promote(Employee employee)
    {
        return employee.Experience >= 5;
    }





}
