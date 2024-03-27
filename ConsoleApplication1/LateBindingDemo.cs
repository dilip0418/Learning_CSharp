using System;
using System.Reflection;

namespace ConsoleApplication1
{
    class LateBindingDemo
    {
        public LateBindingDemo()
        {
            //Get the current executing assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //get the Type/class to create an instance
            Type employeeType = executingAssembly.GetType("ConsoleApplication1.Employee1");

            // get the instance/object to invoke the method using the Activator class
            object employeeObject = Activator.CreateInstance(employeeType);



            //populate the params required to invoke the method
            MethodInfo getConstructor = employeeType.GetMethod("GetDetails");

            string[] param = new string[2];
            param[0] = "RamaLakshmi";
            param[1] = "EVRY0001";

            string emp = (string)getConstructor.Invoke(employeeObject, param);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("SSID - Name:\n{0}", emp);

            //Invoke the method 

        }
    }
    class Employee1
    {
        public string GetDetails(string SSID, string Name)
        {
            return (SSID + " - " + Name);
        }
    }
}
