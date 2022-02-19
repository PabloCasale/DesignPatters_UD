using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Employees
{
    public class EmployeeJobBuilder : EmployeeBuilderFacade
    {
        public EmployeeJobBuilder(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeJobBuilder At(string companyName)
        {
            employee.CompanyName = companyName;
            return this;
        }

        public EmployeeJobBuilder AsA(string position)
        {
            employee.Position = position;
            return this;
        }

        public EmployeeJobBuilder Earning(int amount)
        {
            employee.AnnualIncome = amount;
            return this;
        }
    }
}