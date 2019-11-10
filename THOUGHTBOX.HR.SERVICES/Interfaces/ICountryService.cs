using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using System.Data;

namespace THOUGHTBOX.HR.SERVICES.Interfaces
{
    public interface ICountryService
    {
        int Create(Country country);
        int Delete(Int64 Id);
        int Update(Country country);
        String GetAll();
        DataSet GetAll1();
        Country GetById(Int64 Id);
    }
}
