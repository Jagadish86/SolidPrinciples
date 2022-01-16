using SolidPrinciples.SRP.Interfaces;

namespace SolidPrinciples.SRP
{
    public class Employee
	{

		private readonly IPayroll _payroll;

		public Employee(IPayroll payroll)
		{
			_payroll = payroll;
		}

		public void GetEmployeeDetails(int id)
		{

			_payroll.GetSalaryDetails(id);
		}
	}
}
