using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emppayrollrest
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
        string[] department { get; set; }
        public string startDate { get; set; }
    }
     
    
}
