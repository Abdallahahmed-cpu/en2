using en2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en2
{


    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
 }
