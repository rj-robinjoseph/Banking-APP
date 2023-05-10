using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    internal class SavingsAccount
    {
        public SavingsAccount()
        {
            accountNumber = "";
            interestRate = 0;
            balance = 0;
        }

        public string accountNumber { get; set; }

        public decimal interestRate { get; set; }

        public decimal balance { get; set; }
    }
}
