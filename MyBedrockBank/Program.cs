using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ////instances of the class -> objects
            ////'new' is the constructor
            //var account = new Account();
            //// account.Id = 1;
            //account.Name = "May";
            //account.Deposit(400);
            //account.Withdraw(200);
            ////account.Balance = 100000000;
            //// {0}, {1} are placeholders. Can reuse placeholder values again in string.
            //Console.WriteLine("Id: {0}, Name: {1}, Balance: {2:c}", account.Id, account.Name, account.Balance);

            //var account2 = new Account();
            //account2.Name = "My Savings";
            //Console.WriteLine("Id: {0}, Name: {1}, Balance: {2:c}", account2.Id, account2.Name, account2.Balance);
            var c1 = Bank.CreateCustomer("May", "may@may.com", "Redmond, WA");
        }
    }
}
