using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

namespace Domain.Specifications
{
    public class EmployeeWithLevelNSpecification : BaseSpecifcation<Employee>
    {
        public EmployeeWithLevelNSpecification(int levels) : base(x => x.Level > levels)
        {
            AddOrderByDescending(x => x.Salary);
        }
    }
}
