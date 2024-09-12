using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ContactInfo { get; set; }
        public string MedicalHistory { get; set; }

        public Patient(int id, string name, int age, string contactInfo, string medicalHistory)
        {
            PatientID = id;
            Name = name;
            Age = age;
            ContactInfo = contactInfo;
            MedicalHistory = medicalHistory;
        }

        public void DisplayPatient()
        {
            Console.WriteLine($"ID: {PatientID}, Name: {Name}, Age: {Age}, Contact: {ContactInfo}, Medical History: {MedicalHistory}");
        }
    }
}
