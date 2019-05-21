using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moneybox_Revised.Domain
{
    public class Account
    {
        public long Id { get; set; }
        public string User { get; set; }
        public string Accountname { get; set;}
        public decimal Balance { get; set;}
        
    }
}
