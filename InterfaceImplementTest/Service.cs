using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceImplementTest
{
    /// <summary>
    /// 这里很巧妙的通过继承的BasicService实现了ITestService的Add接口，
    /// 避免子类再去重新实现一次。
    /// </summary>
    public class Service : BasicService, ITestService
    {
        public void Remove()
        {
            Console.WriteLine("Remove");
        }
    }
}
