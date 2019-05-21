using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moneybox_Revised.Domain;

namespace Moneybox_Revised.Features
{
    class NotificationService : INotificationService
    {
        public string LowonFunds(string accountname)
        {
            string message = accountname + " is low on funds please add more funds";
            return message;
        }

        public string TransferAmountHigherthanBalance(string accountname)
        {
            string message = accountname + " is transfering more money than in account";
            return message;
        }

        public string WithdrawAmountHigherthanBalance(string accountname)
        {
            string message = accountname + " is withdrawing more money than in account";
            return message;
        }

        public string AccountDoesNotExist(string accountname)
        {
            string message = accountname + " does not exist";
            return message;
        }

        public string AccountClosed(string accountname)
        {
            string message = accountname + " has been closed";
            return message;
        }

        public string WithdrawAmountZeroOrLower()
        {
            string message = "The withdraw amount must be greater than zero";
            return message;
        }

        public string TransferAmountZeroOrLower()
        {
            string message = "The transfer amount must be greater than zero";
            return message;
        }
    }
}
