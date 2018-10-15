using System;

namespace InterfaceImplementTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestService service = new Service();
            service.Add();
            Console.WriteLine("Hello World!");
        }
    }
}
