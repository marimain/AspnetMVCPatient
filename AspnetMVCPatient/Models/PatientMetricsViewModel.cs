using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetMVCPatient.Models
{
    public class PatientMetricsViewModel
    {
        public PatientMetricsViewModel()
        {

        }
        public IEnumerable<PatientDetail> Patients { get; set; }

    }
}