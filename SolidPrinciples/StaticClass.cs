using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class StaticClass
    {
        static string message;
        private StaticClass() 
        { 
            message = "static method"; 
        }
        public void NonStaticMethod() => Console.WriteLine("Non static method");
        public static void StaticMethod() => Console.WriteLine(message);
    }
}
