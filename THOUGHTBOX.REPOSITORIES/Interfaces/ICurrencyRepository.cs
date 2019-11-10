using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.REPOSITORIES.Classes;
using THOUGHTBOX.DOMAIN.Domain;
using System.Data;

namespace THOUGHTBOX.REPOSITORIES.Interfaces
{
    public interface ICurrencyRepository
    {
        int Create(Currency currency);
        int Update(Currency currency);
        int Delete(Int64 Id);
        DataSet GetAll();
        Currency GetById(Int64 Id);

    }
}
