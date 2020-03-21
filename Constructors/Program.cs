using System;

                                                 //Simple Constructor

//namespace Constructors
//{
//    class Person
//    {
//        public string name;
//        public int age;

//        public Person(string name,int age)
//        {
//            this.name = name;
//            this.age = age;
//        }
//        public string getname()
//        {
//            return this.name;
//        }
//        public int getage()
//        {
//            return this.age;
//        }
//        static void Main(string[] args)
//        {
//            Person Ali = new Person("Ali", 22);
//            Person Awais = new Person("Awais", 25);
//            Console.WriteLine("Name = " + Ali.getname());
//            Console.WriteLine("Age = " + Ali.getage());
//            Console.WriteLine("Name = " + Awais.getname());
//            Console.WriteLine("Age = " + Awais.getage());
//        }
//    }
//}


                                               //Constructor Overloading


namespace Constructors
{
    class Addition
    {
        public Addition(int a ,int b)
        {
            int x = a + b;
            Console.WriteLine("Addition = " + x);
        }

        public Addition (int a , int b , int c)
        {
            int x = a + b + c;
            Console.WriteLine("Addition = " + x);
        }

        static void Main(string[] args)
        {
            Addition obj = new Addition(3, 4);
            Addition obj2 = new Addition(1, 2, 3);
            
        }
        
    }

}