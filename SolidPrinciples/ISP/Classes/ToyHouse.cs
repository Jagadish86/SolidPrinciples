using SolidPrinciples.ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Classes
{
    class ToyHouse : IToy
    {
        public void Color()
        {
            Console.WriteLine(" Color of the Toy!!");
        }
    }
}
