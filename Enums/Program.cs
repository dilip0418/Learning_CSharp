using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Shivaranjani",
                gender = Gender.Female
            };
            customers[1] = new Customer
            {
                Name = "Shivesh",
                gender = Gender.Male
            };
            customers[2] = new Customer
            {
                Name = "Stranger",
                gender = Gender.Unknown
            };
            foreach (int i in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine(i);
            }
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name: {0} && Gender: {1}", customer.Name, customer.gender);
            }
        }
    }
    public enum Gender
    {
        Unknown=0,
        Male=1,
        Female=2
    }

    class Customer
    {
        public string Name { get; set; }
        public Gender gender { get; set; }

    }
}
