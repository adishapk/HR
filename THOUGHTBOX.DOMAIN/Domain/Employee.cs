using System;
using System.Collections.Generic;
using System.Text;

namespace THOUGHTBOX.DOMAIN.Domain
{
    public class Employee
    {
        public Int64 Id { get; set; }
        public string Employeecode { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Dateofbirth { get; set; }
        public string Bloodgroup { get; set; }
        public string Visatype { get; set; }
        public string Emailid { get; set; }
        public string Employeestatus { get; set; }
        public string Employeeremarks { get; set; }
        public string Employeephoto { get; set; }
        public string Employeeidcard { get; set; }
        public string YearlyLeavestatus { get; set; }
        public string Passportstatus { get; set; }
        public string Joiningdate { get; set; }
        public string Fundamount { get; set; }
        public string Fundjoiningdate { get; set; }
        public string Mcnumber { get; set; }
        public string Recommendstatus { get; set; }
        public string Arriveddate { get; set; }
        public string Recommendothers { get; set; }
        public Int64 Mentorid { get; set; }
        public string Salarytype { get; set; }
        public string Accountno { get; set; }
        public string Cardtype { get; set; }
        public string Roomcapacity { get; set; }
        public string Roomindate { get; set; }
        public string Roomoutdate { get; set; }
        public Region Region { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
        public Division Division { get; set; }
        public Country Country { get; set; }
        public Employee ReportedTo { get; set; }
        public Employee RecommendBy { get; set; }
    }
}
