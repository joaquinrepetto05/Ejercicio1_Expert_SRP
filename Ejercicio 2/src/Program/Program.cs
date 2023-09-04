using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main (string[] args)
        {
            string appointment1 = AppointmentService.CreateAppointment ("Joaquín Repetto" , "56020074" , "0947018610" , "18" , "30/8/2023" , "Clinica Carrasco" , "Julian Alvarez" , "Neurocirujano");
            string appointment2 = AppointmentService.CreateAppointment ("Federico Diaz" , "52894625" , "095899617" , "18" , "30/8/2023" , "Clinica Carrasco" , "Julian Alvarez" , "Neurocirujano");

            Console.WriteLine (appointment1 + "\n");
            Console.WriteLine (appointment2);
        }
    }
}
