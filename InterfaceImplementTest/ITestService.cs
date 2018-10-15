using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementTest
{
    public interface ITestService : IService
    {
        void Remove();
    }
}
