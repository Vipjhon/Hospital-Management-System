using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Appointment
    {
        public int AppointmentID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Appointment(int id, Patient patient, Doctor doctor, DateTime date)
        {
            AppointmentID = id;
            Patient = patient;
            Doctor = doctor;
            AppointmentDate = date;
        }

        public void DisplayAppointment()
        {
            Console.WriteLine($"Appointment ID: {AppointmentID}, Patient: {Patient.Name}, Doctor: {Doctor.Name}, Date: {AppointmentDate}");
        }
    }
}
