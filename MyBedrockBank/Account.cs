using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBedrockBank
{
    public class Account
    {
        #region Variables
        private decimal balance;
        #endregion

        #region Static
        // Only banks should have access, not the user/customer.
        // Static members
        private static int lastId = 0;
        #endregion

        #region Properties

        //auto properties - backing field (variable behind your property)
        // instance members
        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }

        public decimal Balance {
            get
            {
                return balance;
            }
            // private only allows appropriate person to set the balance.
            private set {
                if (value >= 0)
                {
                balance = value;
                }
            } 
        }
        public virtual Customer Customer { get; set; }
        #endregion

        #region Constructor
        //Constructions are a special kind of method. Write like a method but:
        // No return
        // Has same name as a class name
        // Default constructors do not take any parameters
        // Overloading constructors
        public Account()
        {
            // lastId = lastId + 1
            // last++ -> Post increment
            // ++last -> Pre increment 
            Id = ++lastId;
            Balance = 300;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            
        }
        #endregion

    }
}
