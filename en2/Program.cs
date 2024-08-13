namespace en2
{
    public class Program
    {
        static void Main(string[] args)
        {
             var patientsWithDoctors = AppContext.Patients
                                 .Select(p => new
                                 {
                                     p.Name,
                                     Doctors = p.Appointments.Select(a => a.Doctor.Name).Distinct().ToList()
                                 })
                                 .ToList();


            var doctorsWithAppointments = AppContext.Doctors
                                     .Select(d => new
                                     {
                                         d.Name,
                                         Appointments = d.Appointments.Select(a => new
                                         {
                                             a.Date,
                                             a.Patient.Name
                                         }).ToList()
                                     })
                                     .ToList();



             var totalAppointmentsByDoctor = AppContext.Doctors
                                                   .Select(d => new
                                                   {
                                                       d.Name,
                                                       TotalAppointments = d.Appointments.Count()
                                                   })
                                                   .ToList();



             DateTime specificDate = new DateTime(2020, 1, 1);
            var patientsDiagnosedAfterDate = AppContext.Patients
                                                    .Where(p => p.Diagnoses.Any(d => d.Date > specificDate))
                                                    .Select(p => new { p.Name, DiagnosisDate = p.Diagnoses.Select(d => d.Date).FirstOrDefault() })
                                                    .ToList();



             var doctorsWithoutAppointments = AppContext.Doctors
                                                    .Where(d => !d.Appointments.Any())
                                                    .Select(d => new { d.Name })
                                                    .ToList();


             var doctorsWithoutAppointments = AppContext.Doctors
                                                    .Where(d => !d.Appointments.Any())
                                                    .Select(d => new { d.Name })
                                                    .ToList();



             var patientsWithoutDiagnosis = AppContext.Patients
                                                  .Where(p => p.Appointments.Any() && !p.Diagnoses.Any())
                                                  .Select(p => new
                                                  {
                                                      p.Name,
                                                      AppointmentDates = p.Appointments.Select(a => a.Date).ToList()
                                                  })
                                                  .ToList();


        }
    }
}
