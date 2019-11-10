using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using System.Data;

namespace THOUGHTBOX.REPOSITORIES.Interfaces
{
    public interface ICountryRepository
    {
        int Create(Country country);
        int Update(Country country);
        int Delete(Int64 Id);
        DataSet GetAll();
        Country GetById(Int64 Id);
    }
}
