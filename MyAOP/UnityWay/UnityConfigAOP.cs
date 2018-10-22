﻿using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Interception.Interceptors.InstanceInterceptors.TransparentProxyInterception;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;//InterceptionExtension

namespace MyAOP.UnityWay
{
    /// <summary>
    /// 使用EntLib\PIAB Unity 实现动态代理
    /// 
    /// </summary>
    public class UnityConfigAOP
    {
        public static void Show()
        {
            User user = new User()
            {
                Name = "Eleven",
                Password = "12345678934534643"
            };
            {
                IUnityContainer container = new UnityContainer();
                container.RegisterType<IUserProcessor, UserProcessor>();
                IUserProcessor processor = container.Resolve<IUserProcessor>();
                processor.RegUser(user);
            }
            {
                //配置UnityContainer
                IUnityContainer container = new UnityContainer();
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "CfgFiles\\Unity.Config");
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                UnityConfigurationSection configSection = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
                configSection.Configure(container, "aopContainer");

                IUserProcessor processor = container.Resolve<IUserProcessor>();
                processor.RegUser(user);
                User userNew1 = processor.GetUser(user);
                User userNew2 = processor.GetUser(user);
            }
        }
    }
}
