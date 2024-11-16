using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Homework1766
{
    internal class SalaryAcc : IAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        internal SalaryAcc(double balance)
        {
            Type = "Зарплатный";
            Balance = balance;
        }

        public void CalculateInterest()
        {
            this.Interest = this.Balance * 0.5;
        }
    }
}