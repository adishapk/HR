using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using System.Data;

namespace THOUGHTBOX.HR.SERVICES.Interfaces
{
    public interface ICurrencyService
    {
        int Create(Currency currency);
        int Delete(Int64 Id);
        int Update(Currency currency);
        String GetAll();
        Currency GetById(Int64 Id);
    }
}
