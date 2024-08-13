using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en2
{
    public class Treatment
    {
        public int TreatmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }

}
