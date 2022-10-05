using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_JSON
{
    public class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int salary { get; set; }
        public string email { get; set; }
    }
}
