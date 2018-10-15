using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementTest
{
    public class BasicService : IService
    {
        public void Add()
        {
            Console.WriteLine("Add");
        }
    }
}
