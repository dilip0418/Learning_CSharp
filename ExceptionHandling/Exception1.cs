using System;
using System.IO;

class Exception1
{
    public static void testException()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"E:\Test.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        //Mention the most specific exceptions before the most specific one's 
        catch (FileNotFoundException fe)
        {
            Console.WriteLine("File {0} is not found please do check the file!", fe.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //and the finally block which is optional is a good practise to perform actions which are independent of whether an exception is raised or not.
        finally
        {
            if (streamReader != null)
                streamReader.Close();
            Console.WriteLine("Inside finally block!");
        }
    }
}
