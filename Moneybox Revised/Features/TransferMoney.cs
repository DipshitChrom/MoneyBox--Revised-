using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moneybox_Revised.Domain;
using Moneybox_Revised.Data_Access;

namespace Moneybox_Revised.Features
{
    public class TransferMoney
    {
        IAccountRepository accounts;
        

        public TransferMoney(IAccountRepository account)
        {
            accounts = account;
        }

        public void Execute(long fromAccountID, long toAccountId, decimal transferamount)
        {
            var fromAccount = accounts.GetAccountByID(fromAccountID);
            var toAccount = accounts.GetAccountByID(toAccountId);

            Account account = new Account();
            //var fromAccountBalance = account.Balance();
        }
    }
}
