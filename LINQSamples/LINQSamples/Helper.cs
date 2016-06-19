﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
   public  class Helper
    {
       public static void LogMethodName()
        {
            var stackTrace = new StackTrace();
            var methodBase = stackTrace.GetFrame(1).GetMethod();
            Console.WriteLine(methodBase.Name);
        }

       public static void Dump<T>(IEnumerable<T> data)
        {
            foreach (var s in data)
            {
                Console.WriteLine(s);
            }
        }

       public static void InvokeAllStaticMethods(Type type)
        {
            var methodInfos = type.GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);

            foreach(var info in methodInfos)
            {
                info.Invoke(null,null);
            }

        }

    }
}
