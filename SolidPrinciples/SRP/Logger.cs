using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // Logger class is only responsible for logging related operations 
    public class Logger
    {
        public static void WriteLog()
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
        }
    }
}
