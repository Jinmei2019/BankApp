using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp
{
    class Account
    {
        #region
        /// <summary>
        /// /Accountnumber
        /// adfhakdfa
        /// ahdfalfhdla
        /// </summary>
        public int AccountNumber { get; set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns></returns>
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion

    }
}
