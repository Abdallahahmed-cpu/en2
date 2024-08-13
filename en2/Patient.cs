using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en2
{
    
      public class Patient
    {
        
       public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Diagnosis> Diagnoses { get; set; }
    }

}

