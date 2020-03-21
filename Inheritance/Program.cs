using System;

//namespace Inheritance
//{
//    class Employee
//    {
//        public string Empname;
//        public int Empid;
//        public int Empage;
//        public int Empphone;
//    }

//    class TempEmp : Employee
//    {
//        public int tempsalary;
//        public int tvishours;
//    }

//    class PermEmp : Employee
//    {
//        public int Persalary;
//        public int perhour;
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            PermEmp obj = new PermEmp();
//            obj.Empname = "Asad";
//            Console.WriteLine("Employee Name is = " + obj.Empname);

//        }
//    }
//}



//Method Hiding is done using "new" Keyword 


//namespace Inheritance
//{
//    class a1
//    {
//        public void show()
//        {
//            Console.WriteLine("Method 1");
//        }
//    }

//    class a2 : a1
//    {
//        public new void show()
//        {
//            Console.WriteLine("Method 2");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            a2 obj = new a2();
//            obj.show();
//        }
//    }
//}


                             //With Base Keyword we can call parent method

namespace Inheritance
{
    class a1
    {
        public void show()
        {
            Console.WriteLine("Method 1");
        }
    }

    class a2 : a1
    {
        public void show()
        {
            base.show();
            Console.WriteLine("Method 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            a1 obj = new a2();
            obj.show();
        }
    }
}

                                                //Method Overriding


//namespace Inheritance
//{
//    class a1
//    {
//        public virtual void show()
//        {
//            Console.WriteLine("Method 1");
//        }
//    }

//    class a2 : a1
//    {
//        public override void show()
//        {
//            Console.WriteLine("Method 2");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            a2 obj = new a2();
//            obj.show();
//        }
//    }
//}