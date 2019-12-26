using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Interfaces;
using System.Data.Entity;

namespace Infrastructure
{
    class EmployeeRepository : IEmployeeRepository
    {
        EmployeeContext context = new EmployeeContext();
        public void Add(Employee e)
        {
            context.Employees.Add(e);
            context.SaveChanges();
        }

        public void Edit(Employee e)
        {
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public Employee FindById(int id)
        {

            //var result = from r in context.Employees
            //             where r.EmpId == id select r;
            throw new NotImplementedException();
        }

        public IEnumerable GetEmployees()
        {
            return context.Employees;
        }

        public void Remove(int id)
        {
            Employee e = (Employee) context.Employees.Find(id);
            context.SaveChanges();
        }
    }
}
