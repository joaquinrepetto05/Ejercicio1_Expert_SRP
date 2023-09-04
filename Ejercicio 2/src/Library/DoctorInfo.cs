using System;

namespace Library
{
    public class DoctorInfo
    {
        public String name { get; }
        public String speciality { get; }

        public DoctorInfo (String dname , String dspeciality)
        {
            this.name = dname;
            this.speciality = dspeciality;
        }
    }
}