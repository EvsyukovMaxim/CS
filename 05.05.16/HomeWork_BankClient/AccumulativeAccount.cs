﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class AccumulativeAccount : BaseAccount
    {
        public AccumulativeAccount(string accountNumber) : base (accountNumber)
        {
            _accountNumber = accountNumber;
        }
    }
}