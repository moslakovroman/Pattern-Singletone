using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SingletonClass1 temp1 = SingletonClass1.SingletonGetInstanse();
            SingletonClass1 temp2 = SingletonClass1.SingletonGetInstanse();

            if (temp1 == temp2)
            {
                Console.WriteLine("All works well");
            }
        }
    }
}
