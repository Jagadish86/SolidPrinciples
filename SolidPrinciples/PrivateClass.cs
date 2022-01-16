using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class PrivateClass
    {
        static string message = string.Empty;
        private PrivateClass()
        {
            message = "Private class";
        }

        public static void DisplayMessage() => Console.WriteLine(message);
    }
}
