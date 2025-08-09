using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 1: Inheritance and Method Overriding ===");
            InheritanceDemo.Run();

            Console.WriteLine("\n=== Task 2: Abstract Classes and Methods ===");
            AbstractDemo.Run();

            Console.WriteLine("\n=== Task 3: Interfaces ===");
            InterfaceDemo.Run();
        }
    }
}
