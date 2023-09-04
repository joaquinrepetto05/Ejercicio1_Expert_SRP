using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public Patient patient { get; set; }
        public DoctorInfo doctor { get; set; }
        public String date { get; set; }
        public String place { get; set; }

        public Appointment (Patient newpatient, DoctorInfo newdoctor, String newdate, String newplace)
        {
            this.patient = newpatient;
            this.doctor = newdoctor;
            this.date = newdate;
            this.place = newplace;
        }
    }
}
