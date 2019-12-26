﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IEmployeeRepository
    {
        void Add(Employee e);
        void Edit(Employee e);
        void Remove(int id);
        IEnumerable GetEmployees();
        Employee FindById(int id);
    }
}
