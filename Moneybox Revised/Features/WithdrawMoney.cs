using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moneybox_Revised.Data_Access;
using Moneybox_Revised.Domain;
namespace Moneybox_Revised.Features
{
 
    public class WithdrawMoney
    {
        Account account;
        decimal Balance;

        public WithdrawMoney(IAccountRepository takeaccount, long accountId, decimal balance)
        {
            account = takeaccount.GetAccountByID(accountId);
            Balance = account.Balance;
        }


        public void Execute(long AccountID, decimal withdrawamount)
        {
            var withdrawingaccount = AccountID;
          
            NotificationService warningmessages = new NotificationService();
            decimal NewBalance;
            decimal CurrentBalance = account.Balance;

            if (withdrawamount > CurrentBalance)
            {
                warningmessages.WithdrawAmountHigherthanBalance(account.User);   
            }

            if (withdrawamount <= 0)
            {
                warningmessages.WithdrawAmountZeroOrLower();
            }

            else
            {
                NewBalance = CurrentBalance - withdrawamount;
                
            }
        }
    }
}
