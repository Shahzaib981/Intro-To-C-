//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//Use Of Parameter Array


//namespace Optional_Parameters
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            AddNumbers(10, 30);
//        }

//        public static void AddNumbers(int Fnum, int Snum, params object[] restofnum)
//        {
//            int result = Fnum + Snum;
//            if(restofnum != null)
//            {
//                foreach(int i in restofnum)
//                {
//                    result += i;
//                }
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }
//}

//if we want to add new numbers in method then use array with the same type e.g. new Object[]

//namespace Optional_Parameters
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Addnum(2, 3, new object[] { 2, 3, 2 });
//        }

//        public static void Addnum(int F1 , int F2, params object[] restofnum)
//        {
//            int result = F1 + F2;
//            if (restofnum != null)
//            {
//                foreach (int i in restofnum)
//                {
//                    result += i;
//                }
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }
//}


//using Method Overloading


//namespace Optional_Parameters
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Addnum(2, 3, new int[] { 3, 4, 5 });
//        }

//        public static void Addnum(int F1, int F2)
//        {
//            Addnum(F1, F2, null);
//        }
//        public static void Addnum(int F1, int F2, int[] restofnum)
//        {
//            int result = F1 + F2;
//            if (restofnum != null)
//            {
//                foreach (int i in restofnum)
//                {
//                    result += i;
//                }
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }
//}



//By making Default value. e.g. null



//namespace Optional_Parameters
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Addnum(2, 3, new int[] { 2, 3, 2 });
//        }

//        public static void Addnum(int F1, int F2, int[] restofnum = null)
//        {
//            int result = F1 + F2;
//            if (restofnum != null)
//            {
//                foreach (int i in restofnum)
//                {
//                    result += i;
//                }
//            }
//            Console.WriteLine("Sum = " + result);
//        }
//    }
//}

//My intention is to pass 2 as Argument for c 

//namespace Optional_Parameters
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            test(1, c: 2);   
//        }

//        public static void test(int a, int b = 10, int c= 20)
//        {
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine(c);
//        }
//    }
//}


                          //using Optional Keyword using System.Runtime.InteropServices

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Addnum(2, 3, new int[] { 2, 3, 2 });
        }

        public static void Addnum(int F1, int F2, [Optional] int[] restofnum)
        {
            int result = F1 + F2;
            if (restofnum != null)
            {
                foreach (int i in restofnum)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = " + result);
        }
    }
}


