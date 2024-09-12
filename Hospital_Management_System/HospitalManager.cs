using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class HospitalManager
    {
        private List<Patient> patients = new List<Patient>();
        private List<Doctor> doctors = new List<Doctor>();
        private List<Appointment> appointments = new List<Appointment>();
        private int nextPatientId = 1;
        private int nextDoctorId = 1;
        private int nextAppointmentId = 1;

        // Patient Management
        public void AddPatient(string name, int age, string contactInfo, string medicalHistory)
        {
            Patient newPatient = new Patient(nextPatientId++, name, age, contactInfo, medicalHistory);
            patients.Add(newPatient);
            Console.WriteLine("Patient added successfully.");
        }

        public void ListPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients found.");
            }
            else
            {
                foreach (var patient in patients)
                {
                    patient.DisplayPatient();
                }
            }
        }

        // Doctor Management
        public void AddDoctor(string name, string specialization, string contactInfo)
        {
            Doctor newDoctor = new Doctor(nextDoctorId++, name, specialization, contactInfo);
            doctors.Add(newDoctor);
            Console.WriteLine("Doctor added successfully.");
        }

        public void ListDoctors()
        {
            if (doctors.Count == 0)
            {
                Console.WriteLine("No doctors found.");
            }
            else
            {
                foreach (var doctor in doctors)
                {
                    doctor.DisplayDoctor();
                }
            }
        }

        // Appointment Management
        public void ScheduleAppointment(int patientId, int doctorId, DateTime appointmentDate)
        {
            Patient patient = patients.Find(p => p.PatientID == patientId);
            Doctor doctor = doctors.Find(d => d.DoctorID == doctorId);

            if (patient != null && doctor != null)
            {
                Appointment newAppointment = new Appointment(nextAppointmentId++, patient, doctor, appointmentDate);
                appointments.Add(newAppointment);
                Console.WriteLine("Appointment scheduled successfully.");
            }
            else
            {
                Console.WriteLine("Invalid patient or doctor ID.");
            }
        }

        public void ListAppointments()
        {
            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments found.");
            }
            else
            {
                foreach (var appointment in appointments)
                {
                    appointment.DisplayAppointment();
                }
            }
        }
    }
}
