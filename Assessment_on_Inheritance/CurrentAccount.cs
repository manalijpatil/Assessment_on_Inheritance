using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_on_Inheritance
{
    public class CurrentAccount:BankAccount
    {
        private int id;
        private double balance;

        public CurrentAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }
       public override void Deposit(double amount)
        {
            balance += amount;
            
        }
       public override void Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                Console.WriteLine("After Withdrawn balance=", balance);
            }
        }
        public override string ToString()
        {
            return $"Balance Details: Id={id},Balance={balance}";
        }

    }
}
