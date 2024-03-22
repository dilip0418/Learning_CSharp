using System;
using System.IO;


namespace ExceptionHandling
{
    class InnerExceptions
    {
        public static void testInnerException()
        {

            int num1, num2;
            try
            {

                try
                {
                    Console.WriteLine("Enter two numbers: ");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(num1 / num2);
                }
                catch (Exception ex)
                {
                    string filePath = @"E:\Test.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Close();
                        Console.WriteLine("Something went wrong, Please try after sometime!");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " doesn't exists!", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Current Exception: " + ex.GetType().Name);
                if (ex.InnerException != null)
                    Console.WriteLine("Inner Exception: " + ex.InnerException.GetType().Name);
            }
        }
    }
}
