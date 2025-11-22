using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subcontractor> subcontractors = new List<Subcontractor>();

            Console.WriteLine("=== Subcontractor Management System ===");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Subcontractor");
                Console.WriteLine("2. List Subcontractors");
                Console.WriteLine("3. Compute Pay");
                Console.WriteLine("4. Exit");

                Console.Write("Enter selection: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSubcontractor(subcontractors);
                        break;

                    case "2":
                        ListSubcontractors(subcontractors);
                        break;

                    case "3":
                        ComputePay(subcontractors);
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddSubcontractor(List<Subcontractor> list)
        {
            Console.Write("\nEnter Contractor Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Contractor Number: ");
            string number = Console.ReadLine();

            Console.Write("Enter Start Date (MM/DD/YYYY): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Shift (1 = Day, 2 = Night): ");
            int shift = int.Parse(Console.ReadLine());

            Console.Write("Enter Hourly Pay Rate: ");
            double rate = double.Parse(Console.ReadLine());

            Subcontractor sc = new Subcontractor(name, number, startDate, shift, rate);
            list.Add(sc);

            Console.WriteLine("Subcontractor added successfully!");
        }

        static void ListSubcontractors(List<Subcontractor> list)
        {
            Console.WriteLine("\n=== Subcontractors ===");

            if (list.Count == 0)
            {
                Console.WriteLine("No subcontractors found.");
                return;
            }

            foreach (var sc in list)
            {
                Console.WriteLine(sc.ToString());
            }
        }

        static void ComputePay(List<Subcontractor> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\nNo subcontractors available to compute pay.");
                return;
            }

            Console.Write("\nEnter the contractor number to compute pay: ");
            string number = Console.ReadLine();

            Subcontractor sc = list.Find(x => x.GetContractorNumber() == number);

            if (sc == null)
            {
                Console.WriteLine("Contractor not found.");
                return;
            }

            Console.Write("Enter hours worked: ");
            float hours = float.Parse(Console.ReadLine());

            float pay = sc.ComputePay(hours);

            Console.WriteLine($"Pay for {sc.GetContractorName()}: ${pay:F2}");
        }
    }
}
