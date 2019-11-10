using System;
using System.Collections.Generic;
using System.Text;

namespace THOUGHTBOX.REPOSITORIES.Interfaces
{
    public interface ISampleRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        bool GetAll();
        bool GetById(Int64 Id);
    }
}
