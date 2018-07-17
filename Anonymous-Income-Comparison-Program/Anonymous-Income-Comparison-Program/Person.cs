using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Person
    {
        private double hourlyRate;
        private double hoursWorked;

        public void SetHourlyRate(string hourlyRate)
        {
            this.hourlyRate = Convert.ToDouble(hourlyRate);
        }

        public void SetHoursWorked(string hoursWorked)
        {
            this.hoursWorked = Convert.ToDouble(hoursWorked);
        }
        
        public double GetHourlyRate()
        {
            return this.hourlyRate;
        }

        public double GetHoursWorked()
        {
            return this.hoursWorked;
        }

        public int GetAnnualSalary()
        {
            double moneyPerWeek = this.hourlyRate * this.hoursWorked;
            //A year has 52 weeks in it so moneyPerWeek times 52 equals annual salary
            int annualSalary = (int)moneyPerWeek * 52;
            return annualSalary;
        }
    }
}
