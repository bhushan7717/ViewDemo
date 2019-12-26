using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    class EmployeeInitDB : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            base.Seed(context);
            context.Employees.Add(new Employee() { EmpId = 1, EmpName = "Emp 1" });
            context.Employees.Add(new Employee() { EmpId = 2, EmpName = "Emp 2" });
        }
    }
}
