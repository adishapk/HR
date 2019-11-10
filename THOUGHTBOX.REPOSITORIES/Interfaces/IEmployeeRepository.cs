using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using THOUGHTBOX.REPOSITORIES.Classes;

namespace THOUGHTBOX.REPOSITORIES.Interfaces
{
    public interface IEmployeeRepository
    {
        bool Create(Employee mEmployee);
        bool Update();
        bool Delete();
        bool GetAll();
        bool GetById(Int64 Id);
    }
}
