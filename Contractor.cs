using System;

namespace FinalProject
{
    public class Contractor
    {
        private string contractorName;
        private string contractorNumber;
        private DateTime contractorStartDate;

        public Contractor()
        {
            contractorName = "";
            contractorNumber = "";
            contractorStartDate = DateTime.MinValue;
        }

        public Contractor(string name, string number, DateTime startDate)
        {
            contractorName = name;
            contractorNumber = number;
            contractorStartDate = startDate;
        }

        public string GetContractorName()
        {
            return contractorName;
        }

        public string GetContractorNumber()
        {
            return contractorNumber;
        }

        public DateTime GetContractorStartDate()
        {
            return contractorStartDate;
        }

        public void SetContractorName(string name)
        {
            contractorName = name;
        }

        public void SetContractorNumber(string number)
        {
            contractorNumber = number;
        }

        public void SetContractorStartDate(DateTime startDate)
        {
            contractorStartDate = startDate;
        }

        public override string ToString()
        {
            return $"Contractor Name: {contractorName}, Number: {contractorNumber}, Start Date: {contractorStartDate.ToShortDateString()}";
        }
    }
}
