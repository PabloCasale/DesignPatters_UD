using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Employees
{
    public class Employee
    {
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int AnnualIncome { get; set; }

        public override string ToString()
        {
            return $" {nameof(StreetAddress)}: {StreetAddress},\n {nameof(PostCode)}: {PostCode},\n {nameof(City)}: {City},\n {nameof(CompanyName)}: {CompanyName},\n {nameof(Position)}: {Position},\n {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}