using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string ContactInfo { get; set; }

        public Doctor(int id, string name, string specialization, string contactInfo)
        {
            DoctorID = id;
            Name = name;
            Specialization = specialization;
            ContactInfo = contactInfo;
        }

        public void DisplayDoctor()
        {
            Console.WriteLine($"ID: {DoctorID}, Name: {Name}, Specialization: {Specialization}, Contact: {ContactInfo}");
        }
    }
}
