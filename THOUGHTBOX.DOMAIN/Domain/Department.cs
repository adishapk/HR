using System;
using System.Collections.Generic;
using System.Text;

namespace THOUGHTBOX.DOMAIN.Domain
{
    public class Department
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string HMCStatus { get; set; }
        public IList<Division> Divisions { get; set; }
    }
}
