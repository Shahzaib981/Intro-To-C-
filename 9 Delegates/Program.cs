using System;
using System.Collections.Generic;

//Simple Delegates

//namespace Delegates
//{
//    class Employee
//    {
//        public int ID { get; set; }
//        public string name { get; set; }
//        public int Salary { get; set; }
//        public int Experience { get; set; }

//        public static void PromoteEmployee(List<Employee> employeelist, Ispromotable IsEligibleToPromote)
//        {
//            foreach (Employee employee in employeelist)
//            {
//                if (IsEligibleToPromote(employee))
//                {
//                    Console.WriteLine(employee.name + " promoted");
//                }
//            }
//        }
//    }

//    delegate bool Ispromotable(Employee empl);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> emplist = new List<Employee>();
//            emplist.Add(new Employee() { ID = 101, name = "Mary", Salary = 5000, Experience = 5 });
//            emplist.Add(new Employee() { ID = 102, name = "JON", Salary = 5000, Experience = 4 });
//            emplist.Add(new Employee() { ID = 103, name = "Alex", Salary = 2000, Experience = 5 });
//            emplist.Add(new Employee() { ID = 104, name = "May", Salary = 3000, Experience = 3 });

//            Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5);
//        }
//    }


//MultiCast Delegate


//namespace Delegates
//    {
//        public delegate void sampledelegate();
//        class Program
//        {
//            static void Main(string[] args)
//            {
//            sampledelegate del = new sampledelegate(method1);
//            del += method2;
//            del += method3;
//            del();
//            }
//        public static void method1()
//        {
//            Console.WriteLine("method 1");
//        }
//        public static void method2()
//        {
//            Console.WriteLine("method 2");
//        }
//        public static void method3()
//        {
//            Console.WriteLine("method 3");
//        }
//    }

//    }


//namespace Delegates
//{
//    public delegate void hellomessage(string message);
//    class Employee
//    {
//        static void Main(string[] args)
//        {
//            hellomessage del = new hellomessage(Hello);
//            del("Hello Delegate");
//        }

//        public static void Hello(string strmessage)
//        {
//            Console.WriteLine(strmessage);
//        } 
//    }
//}






//namespace Delegates
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> emplist = new List<Employee>();

//            emplist.Add(new Employee() { ID = 101, name = "Mary", Salary = 5000, Experience = 5 });
//            emplist.Add(new Employee() { ID = 102, name = "JON", Salary = 5000, Experience = 4 });
//            emplist.Add(new Employee() { ID = 103, name = "Alex", Salary = 2000, Experience = 5 });
//            emplist.Add(new Employee() { ID = 104, name = "May", Salary = 3000, Experience = 3 });
            
            
//            Employee.PromoteEmployee(emplist);
//        }

//        class Employee
//        {
//            public int ID { get; set; }
//            public string name { get; set; }
//            public int Salary { get; set; }
//            public int Experience { get; set; }

//            public static void PromoteEmployee(List<Employee> employeelist)
//            {
//                foreach (Employee employee in employeelist)
//                {
//                    if (employee.Experience >= 5)
//                    {
//                        Console.WriteLine(employee.name +" Promoted");
//                    }
//                }
//            }    
//        }

//    }
//}



//namespace Delegates
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> emplist = new List<Employee>();

//            emplist.Add(new Employee() { ID = 101, name = "Mary", Salary = 5000, Experience = 5 });
//            emplist.Add(new Employee() { ID = 102, name = "JON", Salary = 5000, Experience = 4 });
//            emplist.Add(new Employee() { ID = 103, name = "Alex", Salary = 2000, Experience = 5 });
//            emplist.Add(new Employee() { ID = 104, name = "May", Salary = 3000, Experience = 3 });


//            Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5 );
//        }
//        delegate bool IsPromotable(Employee empl);
//        class Employee
            
//        {
//            public int ID { get; set; }
//            public string name { get; set; }
//            public int Salary { get; set; }
//            public int Experience { get; set; }

//            public static void PromoteEmployee(List<Employee> employeelist, IsPromotable IsEligibleToPromote)
//            {
//                foreach (Employee employee in employeelist)
//                {
//                    if (IsEligibleToPromote(employee))
//                    {
//                        Console.WriteLine(employee.name + " Promoted");
//                    }
//                }
//            }
//        }

//    }
//}



namespace Delegate
{

    //delegate that returns true or false depending upon the passed number and expression
    //delegate bool NumberComparerDelegate(int n); --> no need for this now

    class Program
    {
        static void Main(string[] args)
        {

            var sampleArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Running Filter Numbers");
            IEnumerable<int> result2 = FilterNumbers(sampleArray, n => n < 5);

            foreach (int num in result2)
            {
                Console.WriteLine(num);
            }

        }

        private static IEnumerable<int> FilterNumbers(IEnumerable<int> sampleArray, Func<int, bool> numberComparer)
        {
            foreach (int number in sampleArray)
            {
                if (numberComparer(number))
                    yield return number;
            }
        }

    }
}


