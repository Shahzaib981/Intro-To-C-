using System;

namespace Generics
{
    public class Program
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual<string>("AB", "AB");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

    }
}
