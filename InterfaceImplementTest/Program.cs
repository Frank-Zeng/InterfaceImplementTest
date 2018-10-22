using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using System.IO;
using Unity;

namespace InterfaceImplementTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "unity.xml");
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            var unitySection = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
            var container = new UnityContainer();
            unitySection.Configure(container, "aopContainer");
            var logger = container.Resolve<IService>();
            ITestService service = new Service();
            service.Add();
            Console.WriteLine("Hello World!");
        }
    }
}
