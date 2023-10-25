using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreePartOne
{
    internal class SavingCalculator
    {
        //Variable for getter and setter
        private double deposit;
        private double period;

        // Variable for calculation of deposit and intterest
        //private int numOfMonths;
        private int numOfYears;
        private double interestRate = 0.10 / 12;
        private double totalDepositOfPeriod;
        private double balance;
        private double monthlyDeposit;

        //Start getter and setter
        public double GetDeposit()
        {
            return deposit;
        }

        public void SetDeposit(double deposit)
        {
            if(deposit >= 0.0)
            this.deposit = deposit;
        }

        public double GetPeriod()
        {
            return period;
        }
        public void SetPeriod(double period)
        {
            if(period >= 0)
                this.period = period;
        }

        //Calculation of Total deposit has received
        public double AmountPaidCalculation()
        {
            
            double perYearDeposit = deposit * 12;
            totalDepositOfPeriod = period * perYearDeposit;

            return totalDepositOfPeriod;
        }

        //Calculation of total deposit and interest with compound interest rate.
        public double FinalBalanceCalculation()
        {
            double totalMonths = period * 12;

            for (int month = 1; month <= totalMonths; month++)
            {
                double interestEarned = interestRate * balance;
                balance += interestEarned + deposit;
            }

            return balance;
        }
    }
}
