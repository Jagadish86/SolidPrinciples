using SolidPrinciples.ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Classes
{
    class ToyTrain : IToyAction
    {
        public void Run()
        {
            Console.WriteLine(" Run the train !!");
        }

        public void Stop()
        {
            Console.WriteLine(" Stop the train !!");
        }
    }
}
