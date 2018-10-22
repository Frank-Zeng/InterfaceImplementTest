using MyAOP.UnityWay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAOP
{
    /// <summary>
    /// 1 AOP面向切面编程
    /// 2 静态实现AOP
    /// 3 动态实现AOP
    /// 4 Unity、MVC中的AOP
    /// 
    /// AOP:面向切面编程   编程思想
    /// OOP：一切皆对象，对象交互组成功能，功能叠加组成模块，模块叠加组成系统
    ///      类--砖头     系统--房子
    ///      类--细胞     系统--人
    ///      面向对象是非常适合做大型系统
    ///      应对需求变化扩展的时候，比较困难；
    ///      面向对象是静态的：任何需求的细微变化，都可能导致比较大的影响
    ///      
    /// 设计模式：设计出灵活 可扩展 可重用 的架构    可以解决部分问题
    ///           都在折腾抽象/类
    /// 永远无法解决类的内部变化
    /// 
    /// AOP：面向切面编程  编程思想  
    ///      就是解决类的内部变化问题
    ///      能做到让开发者动态的修改一个静态的面向对象模型，
    ///      在不破坏封装的前提下，去增加各种功能：非业务逻辑，是一些公共逻辑
    ///      是对OOP的有效补充
    ///      有了AOP之后，OOP也变得简单了
    ///      
    /// Unity的AOP实现  依赖注入容器
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.Net高级班vip课程，今天学习面向切面AOP");
                #region AOP show
                //Console.WriteLine("************DecoratorAOP***********");
                //DecoratorAOP.Show();

                //Console.WriteLine("************ProxyAOP***********");
                //ProxyAOP.Show();
                //Console.WriteLine("************RealProxyAOP***********");
                //RealProxyAOP.Show();
                //Console.WriteLine("************CastleProxyAOP***********");
                //CastleProxyAOP.Show();
                Console.WriteLine("************UnityAOP***********");
                UnityConfigAOP.Show();

                //UnityAOP.Show();
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
