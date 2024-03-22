using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception1.testException();
            //InnerExceptions.testInnerException();

            //User Defined Exceptions
            try
            {
                testUserDefinedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void testUserDefinedException()
        {
            throw new UserDefinedException();
            throw new UserDefinedException("Something went wrong");
        }
    }
}
