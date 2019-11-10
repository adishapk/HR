using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.REPOSITORIES.Interfaces;

namespace THOUGHTBOX.HR.SERVICES.Classes
{
    public class SampleService : ISampleService
    {

        private ISampleRepository _SampleRepository;

        public SampleService(ISampleRepository SampleRepository)
        {
            this._SampleRepository = SampleRepository;
        }

        public bool Create()
        {
            return true;
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool GetAll()
        {
            throw new NotImplementedException();
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
