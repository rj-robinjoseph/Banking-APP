using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    internal class CDAccount : SavingsAccount
    {
        public CDAccount() {
            maturityDate = "";
        }

        public string maturityDate { get; set; }
    }
}
