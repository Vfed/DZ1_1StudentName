using System;

namespace W1DZ1studentName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            name = name.Trim();
            if (name.Length > 0)
            {
                Console.WriteLine("Hi ," + name +" you are a student now");
            }
            else
            {
                Console.WriteLine("It`s a problem you haven`t a name.");
            }
            Console.ReadKey();
        }
    }
}
