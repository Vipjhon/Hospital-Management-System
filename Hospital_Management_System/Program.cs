using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalManager manager = new HospitalManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nHospital Management System:");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. List Patients");
                Console.WriteLine("3. Add Doctor");
                Console.WriteLine("4. List Doctors");
                Console.WriteLine("5. Schedule Appointment");
                Console.WriteLine("6. List Appointments");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Patient Name: ");
                        string patientName = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Contact Info: ");
                        string contactInfo = Console.ReadLine();
                        Console.Write("Enter Medical History: ");
                        string medicalHistory = Console.ReadLine();
                        manager.AddPatient(patientName, age, contactInfo, medicalHistory);
                        break;

                    case "2":
                        manager.ListPatients();
                        break;

                    case "3":
                        Console.Write("Enter Doctor Name: ");
                        string doctorName = Console.ReadLine();
                        Console.Write("Enter Specialization: ");
                        string specialization = Console.ReadLine();
                        Console.Write("Enter Contact Info: ");
                        string doctorContactInfo = Console.ReadLine();
                        manager.AddDoctor(doctorName, specialization, doctorContactInfo);
                        break;

                    case "4":
                        manager.ListDoctors();
                        break;

                    case "5":
                        Console.Write("Enter Patient ID: ");
                        int patientId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Doctor ID: ");
                        int doctorId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
                        DateTime appointmentDate = DateTime.Parse(Console.ReadLine());
                        manager.ScheduleAppointment(patientId, doctorId, appointmentDate);
                        break;

                    case "6":
                        manager.ListAppointments();
                        break;

                    case "7":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
