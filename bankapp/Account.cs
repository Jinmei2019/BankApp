using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp
{
    enum AccountType
    {
        Checking,
        Saving,
        CD,
        Loan
    }
    class Account
    {
        #region statics
        private static int lastAccountNumber = 0;
        
        #endregion
        #region Properties
        /// <summary>
        /// /Accountnumber
        /// adfhakdfa
        /// ahdfalfhdla
        /// </summary>
        public int AccountNumber { get;private set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get;private set; }
        public AccountType AccountType { get; set; }
        public DateTime CreatedDate { get; private set; }

        #endregion

        #region Constructor
        public Account()
        {
            //lastAccountNumber++;
            //AccountNumber = lastAccountNumber;

            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;

        }
        
        #endregion


        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns></returns>
        public void Deposit(decimal amount)
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
