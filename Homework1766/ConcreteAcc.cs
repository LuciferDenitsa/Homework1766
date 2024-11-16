using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Homework1766
{
    internal class ConcreteAcc : IAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        internal ConcreteAcc(double balance)
        {
            Type = "Обычный";
            Balance = balance;
        }

        public void CalculateInterest()
        {
            this.Interest = this.Balance * 0.4;
            if (this.Balance < 1000)
                this.Interest -= this.Balance * 0.2;

            if (this.Balance >= 1000)
                this.Interest -= this.Balance * 0.4;
        }
    }
}