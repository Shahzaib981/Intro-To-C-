using System;



//Nullable Data Types
//using System;
//class Program
//   {
//   static void Main(string[] args)
//   {
//       int AvailableTickets = 100;
//       int? TicketsOnSale = null;

//       if (TicketsOnSale == null)
//       { Console.WriteLine("No Tickets are Available"); }
//       else
//       { Console.WriteLine("Tickets Available =" + AvailableTickets); }
//       }
//   }



//Array Program For printing and adding all elements
class Array
{
    static void Main(string[] args)
    {
        int i, n, x = 0;
        int[] a = new int[5];

        Console.WriteLine("Enter No. Of Values to store in an array");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Enter No. to store in an array");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int items in a)
        {
            Console.WriteLine("Array Elements Are = " + items);
        }

        for (i = 0; i < n; i++)
        {
            x = a[i] + x;
        }
        Console.WriteLine("Addition of all Elements in an Array is = " + x);
    }

}


