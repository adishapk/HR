using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.REPOSITORIES.Interfaces;

namespace THOUGHTBOX.HR.SERVICES.Interfaces
{
    public interface ISampleService
    {
        bool Create();
        bool Update();
        bool Delete();
        bool GetAll();
        bool GetById(Int64 Id);
    }
}
