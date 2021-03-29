﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            var service1 = Context.GetInstance().GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            var service2 = Context.GetInstance().GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            Context.GetInstance().SetSettings("2", "X");
            service2 = Context.GetInstance().GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}
