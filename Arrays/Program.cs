using System;
using System.Collections.Generic;

//Program to swap two numbers
//class Exercise5
//{
//    public static void Main(string[] args)
//    {
//        int number1, number2, temp;
//        Console.Write("\nInput the First Number : ");
//        number1 = int.Parse(Console.ReadLine());
//        Console.Write("\nInput the Second Number : ");
//        number2 = int.Parse(Console.ReadLine());
//        temp = number1;
//        number1 = number2;
//        number2 = temp;
//        Console.Write("\nAfter Swapping : ");
//        Console.Write("\nFirst Number : " + number1);
//        Console.Write("\nSecond Number : " + number2);
//        Console.Read();
//    }
//}


//multiplication table
//    class Ex5
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Ënter Number");
//        int x = Convert.ToInt32(Console.ReadLine());

//        for (int i = 1; i < 11; i++)
//        {
//            int m = x * i ;
//            Console.WriteLine(x + "x" + i + "=" + m);
//        }
//    }
//}

//remove specified a character from a non-empty string using index of a character


//class Ex6
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(remove_char("w3resource", 1));   
//    }
//    public static string remove_char(string str, int n)
//    {
//        return str.Remove(n, 1);
//    }
//}



//first and last characters will change their positions

class Ex6
{
    public static void Main(string[] args)
    {
        string cas = "abcdefghijkl";
        char[] array = cas.ToCharArray();
        char temp = cas[0];
        array[0] = array[cas.Length - 1];
        array[cas.Length - 1] = temp;
        Console.WriteLine(array);
    }
}