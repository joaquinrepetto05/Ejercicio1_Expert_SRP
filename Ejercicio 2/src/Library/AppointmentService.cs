using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string patientname, string patientid, string patientphonenumber, string patientage, string appointmentdate, string appointmentplace, string doctorname, string doctorspeciality)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(patientname))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patientid))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patientphonenumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patientage))
            {
                stringBuilder.Append("Unable to schedule appointment, 'age' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentdate))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment date' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentplace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorname))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorspeciality))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor speciality' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                Patient newpatient = new Patient (patientname, patientid, patientphonenumber, patientage);
                DoctorInfo newdoctor = new DoctorInfo (doctorname, doctorspeciality);
                Appointment newappointment = new Appointment (newpatient , newdoctor , appointmentdate , appointmentplace);
                stringBuilder.Append("Appoinment scheduled for " + patientname + " (" + patientid + ")" + " the " + appointmentdate + " at " + appointmentplace);
            }

            return stringBuilder.ToString();
        }
    }
}