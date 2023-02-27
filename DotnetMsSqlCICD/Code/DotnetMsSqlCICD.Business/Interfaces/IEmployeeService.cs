using DotnetMsSqlCICD.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetMsSqlCICD.Business.Interfaces
{
    public interface IEmployeeService
    {      
        IEnumerable<Employee> GetAll();
        Employee Save(Employee classification);
        Employee Update(Employee classification);
        bool Delete(int id);
        Employee  GetById(int id);

    }
}
