using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Homework1766
{
    internal class Calculator
    {
        internal IAccount _account;
        internal Calculator(IAccount a)
        {
            _account = a;
        }

        internal void Calculate()
        {
            _account.CalculateInterest();
            Console.WriteLine($"Вывод: {_account.Type}, баланс: {_account.Balance}. Процентная ставка: {_account.Interest}");
        }



    }
}