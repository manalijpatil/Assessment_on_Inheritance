using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_on_Inheritance
{
    public class SavingsAccount:BankAccount
    {
        private int id;
        private double balance;
        private double amount;

        public SavingsAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public override void Deposit(double amount)
        {
            balance = balance + amount;
        }
        //withdraw method
        public override void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("You have insuffiecent balance!!");
            }
        }
        public override string ToString()
        {
            return $"Balance={balance}";
        }
    }
}
