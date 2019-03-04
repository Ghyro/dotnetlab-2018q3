using System;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            new SomeService().PrintItems();

            Console.WriteLine("Main Completed");

            Console.ReadLine();
        }
    }
}
