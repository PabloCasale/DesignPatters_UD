using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Employees
{
    public class EmployeeBuilderFacade
    {
        protected Employee employee = new();

        public EmployeeJobBuilder Works => new EmployeeJobBuilder(employee);
        public EmployeeAddressBuilder Lives => new EmployeeAddressBuilder(employee);

        public static implicit operator Employee(EmployeeBuilderFacade eb)
        {
            return eb.employee;
        }
    }
}