using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;

namespace THOUGHTBOX.HR.SERVICES.Interfaces
{
    public interface IEmployeeService
    {
        bool Create(Employee mEmployee);
        bool Update();
        bool Delete();
        bool GetAll();
        Employee GetById(Int64 Id);
    }
}
