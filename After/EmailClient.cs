using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.After
{
    internal class EmailClient
    {
        public void Send(Account account, string transactionMessage, DateTime transactionDate)
        {
            Console.WriteLine(
          $"\n\n\t\t To: {account.Email}" +
          $"\n\t\t Subject: Fake Bank Account Activity" +
          $"\n\n\t\t Dear {account.Name}," +
          $"\n\n\t\t\t A recent activity on your account occures at {transactionDate.ToString("yyyy-MM-dd hh:mm")}" +
          "\n\t\t\t\t ===> {0}" +
          $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
          $"\n\n\t\t--------------------------- ", transactionMessage);

        }
    }
}
