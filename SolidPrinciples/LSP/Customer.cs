using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP
{
    class GoldCustomer : Customer
    {
        public override void Add()
        {
            base.Add();
        }
    }

    class SilverCustomer : Customer
    {
        public override void Add()
        {
            base.Add();
        }
    }

    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add();
    }
    class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
    class Customer : IDiscount, IDatabase
    {
        public virtual void Add()
        {
            // Database code goes here  
        }

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
