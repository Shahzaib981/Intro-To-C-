using System;
using System.IO;



//practical example of inheritance


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(@"C:\VS Programs\log.txt");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} ", ex.FileName);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                Console.WriteLine("Block");
            }
        }
    }
}
