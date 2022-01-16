using SolidPrinciples.SRP.Interfaces;
using System;

namespace SolidPrinciples.SRP
{
    public class Payroll : IPayroll
	{
		public void GetSalaryDetails(int id)
		{
			Console.WriteLine($"Employee salary of {id}");
		}
	}

}
