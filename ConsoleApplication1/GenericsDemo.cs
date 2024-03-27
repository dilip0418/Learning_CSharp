using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GenericsDemo
    {
        //Example for generic method
        // T - is a generic type which the compiler matches to the type caller params 
        public bool AreEqual<T>(T var1, T var2)
        {
            return var1.Equals(var2);
        }
    }

    class GenericDemo1<T>
    {
        public T CombineVars(T var1, T var2)
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)(var1.ToString() +" "+ var2.ToString());
            }
            else if (typeof(T).IsNumericType())
            {
                dynamic result = Convert.ToDecimal(var1) + Convert.ToDecimal(var2);
                return (T)result;
            }
            else
            {
                throw new ArgumentException("Unsupported parameter type.");
            }
        }
    }


    //Extending the builting Type class with a custom method IsNumeric
    /*
     * 
     */ 
    public static class TypeExtensions
    {
        public static bool IsNumericType(this Type type)
        {
            return type == typeof(int) || type == typeof(long) || type == typeof(float)
                || type == typeof(double) || type == typeof(decimal);
        }
    }
}
