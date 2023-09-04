using System;

namespace Library
{
    public class Patient
    {
        public String name { get; }
        public String id { get; }
        public String phonenumber { get; }
        public String age { get; }

        public Patient (String patientname, String patientid, String patientphonenumber, String patientage) 
        {
            this.name = patientname;
            this.id = patientid;
            this.phonenumber = patientphonenumber;
            this.age = patientage;
        }

    }
}