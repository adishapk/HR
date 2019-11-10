using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using THOUGHTBOX.REPOSITORIES.Interfaces;

namespace THOUGHTBOX.REPOSITORIES.Classes
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public bool Create(Employee mEmployee)
        {
            try
            {
                //DB Persistent Login Here

                //String mQuery = "Insert into employees(fname, mname, lname)values('" + mEmployee.FName + "','" + mEmployee.MName + "','" + mEmployee.LName + "')";

                //OracleClient.ExecuteQuery(mQuery);

                //If Success Return True, Else False

                throw new Exception("Error Occured in Database Insert!");

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //
            }
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool GetAll()
        {
            return true;
        }

        public bool GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
