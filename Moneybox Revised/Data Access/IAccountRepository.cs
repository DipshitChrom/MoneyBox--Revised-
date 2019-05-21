using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moneybox_Revised.Domain;

namespace Moneybox_Revised.Data_Access
{
    public interface IAccountRepository
    {
        Account GetAccountByID(long id);
        Account GetAccountByName(string accountname);
        void Update(string accountname, decimal amount);
    }
}
