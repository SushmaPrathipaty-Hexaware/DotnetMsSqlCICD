using DotnetMsSqlCICD.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetMsSqlCICD.Business.Interfaces
{
    public interface ITeacherService
    {      
        IEnumerable<Teacher> GetAll();
        Teacher Save(Teacher classification);
        Teacher Update(Teacher classification);
        bool Delete(int id);
        Teacher  GetById(int id);

    }
}
