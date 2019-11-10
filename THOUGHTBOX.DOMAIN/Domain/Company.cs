using System;
using System.Collections.Generic;
using System.Text;

namespace THOUGHTBOX.DOMAIN.Domain
{
    public class Company
    {
        public Int64 Id { get; set; }
        public Company Parent { get; set; }
        public string Suffix { get; set; }

        //Fields
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string POBox { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public string Details { get; set; }
        public string Logo { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public Country Country { get; set; }
        public Region Region { get; set; }

        public IList<Department> Departments { get; set; }
    }
}
