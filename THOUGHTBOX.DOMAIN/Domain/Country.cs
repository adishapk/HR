using System;
using System.Collections.Generic;
using System.Text;

namespace THOUGHTBOX.DOMAIN.Domain
{
    public class Country
    {
        public Int64 Id { get; set; }
        public Int64 Currencyid { get; set; }
        public string Name_Eng { get; set; }
        public string Name_Arb { get; set; }
        public string Code { get; set; }
        public Currency Currency { get; set; }
    }
}
