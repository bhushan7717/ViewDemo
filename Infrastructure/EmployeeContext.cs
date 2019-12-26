using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace Infrastructure
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EmpAppConnString")
        {
            
        }

        public DbSet Employees { get; set; }
    }
}
