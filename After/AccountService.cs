using System;

namespace SOLID.SRP.After
{
    internal class AccountService
    {
        public void Deposit(Account account, decimal amount) 
        {
            var transactionMessage = "";
           
            if (amount > 0)
            {
                account.Balance += amount;

                transactionMessage =
                    $"OK Deposit {amount.ToString("C2")}" +
                    $", current balance {account.Balance.ToString("C2")}";
            } 

            var emailClient = new EmailClient();
            emailClient.Send(account, transactionMessage, DateTime.Now);
    
        }
        public void WithDraw(Account account, decimal amount)
        {
            var transactionMessage = "";

       
            if (account.Balance < amount)
            {
                transactionMessage =
                $"OVERDRAFT when trying to withdraw " +
                $"{ Math.Abs(amount).ToString("C2")}," +
                $" current balance {account.Balance.ToString("C2")}";
            }
            else
            {
                account.Balance -= amount;
                transactionMessage =
                    $"OK Withdraw { Math.Abs(amount).ToString("C2")}" +
                    $", current balance {account.Balance.ToString("C2")}";
            }
       

            var emailClient = new EmailClient();
            emailClient.Send(account, transactionMessage, DateTime.Now);

        }
    }
}
