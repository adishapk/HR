using System;
using System.Collections.Generic;
using System.Text;

namespace THOUGHTBOX.DOMAIN.Domain
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Decimals { get; set; }

    }
}
