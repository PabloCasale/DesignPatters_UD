namespace Builder.Employees
{
    public class EmployeeAddressBuilder : EmployeeBuilderFacade
    {
        public EmployeeAddressBuilder(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeAddressBuilder At(string streetAddress)
        {
            employee.StreetAddress = streetAddress;
            return this;
        }

        public EmployeeAddressBuilder WithPostCode(string postCode)
        {
            employee.PostCode = postCode;
            return this;
        }

        public EmployeeAddressBuilder City(string city)
        {
            employee.City = city;
            return this;
        }
    }
}