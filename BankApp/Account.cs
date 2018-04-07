using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        #region
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string  EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        #endregion

    }
}
