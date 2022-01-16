using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Classes
{
    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }
}
