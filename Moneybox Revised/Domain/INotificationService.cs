using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moneybox_Revised.Domain
{
    public interface INotificationService
    {
        string LowonFunds(string email);
        string TransferAmountHigherthanBalance(string email);
        string WithdrawAmountHigherthanBalance(string email);
        string AccountDoesNotExist(string accountname);
        string AccountClosed(string accountname);
        string WithdrawAmountZeroOrLower();
        string TransferAmountZeroOrLower();
    }
}

