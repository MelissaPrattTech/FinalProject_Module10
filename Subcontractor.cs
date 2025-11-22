using System;

namespace FinalProject
{
    public class Subcontractor : Contractor
    {
        // Attributes specific to Subcontractor
        private int shift;              // 1 = Day, 2 = Night
        private double hourlyPayRate;   

        // Default constructor
        public Subcontractor() : base()
        {
            shift = 1;
            hourlyPayRate = 0.0;
        }

        // Overloaded constructor
        public Subcontractor(string name, string number, DateTime startDate,
                             int shift, double hourlyPayRate)
            : base(name, number, startDate)
        {
            this.shift = shift;
            this.hourlyPayRate = hourlyPayRate;
        }

        // Accessors
        public int GetShift()
        {
            return shift;
        }

        public double GetHourlyPayRate()
        {
            return hourlyPayRate;
        }

        // Method to compute pay with 3% shift differential for night shift
        public float ComputePay(float hoursWorked)
        {
            double rate = hourlyPayRate;

            if (shift == 2) // Night shift
            {
                rate *= 1.03; // 3% increase
            }

            return (float)(rate * hoursWorked);
        }

        // Optional: Display info
        public override string ToString()
        {
            return base.ToString() +
                   $", Shift: {shift}, Hourly Pay: {hourlyPayRate}";
        }
    }
}
