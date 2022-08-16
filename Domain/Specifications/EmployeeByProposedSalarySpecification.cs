using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

namespace Domain.Specifications
{
    public class EmployeeByProposedSalarySpecification : BaseSpecifcation<Employee>
    {
        public EmployeeByProposedSalarySpecification()
        {
            AddOrderByDescending(x => x.Salary);
        }
    }
}
