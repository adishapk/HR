using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.REPOSITORIES.Interfaces;

namespace THOUGHTBOX.HR.SERVICES.Classes
{
    public class EmployeeService : IEmployeeService
    {

        private IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
            this._EmployeeRepository = EmployeeRepository;
        }

        public bool Create(Employee mEmployee)
        {
            try
            {
                mEmployee.Id = 1;
               // mEmployee.FName = "Rijaz";
               // mEmployee.MName = "Nalakath";
               // mEmployee.LName = "Sulaiman";

                return this._EmployeeRepository.Create(mEmployee);
            }
            catch (Exception ex)
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
            try
            {
                return this._EmployeeRepository.GetAll();
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

        public Employee GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
