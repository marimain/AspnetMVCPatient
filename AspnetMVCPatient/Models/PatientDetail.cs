using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetMVCPatient.Models
{
    public class PatientDetail
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
    }
}