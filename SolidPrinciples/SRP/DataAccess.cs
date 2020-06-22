using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    // Data access class is only responsible for data base related operations 
    public static class DataAccess
    {
        public static void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
        }
    }
    
}
