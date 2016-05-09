﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Родительский класс
    class GeneralAccount
    {
        readonly string _accountNumber;
        readonly string _ownerName;
        protected double _currentSum;
        protected bool _isActive;

        public GeneralAccount ()
        {
            _accountNumber = "1234567890123456";
            _ownerName = "Евсюков М.В.";
            _currentSum = 100000;
            _isActive = true;
        }

        public bool CloseAccount()
        {
            if (_currentSum <= 0)
            {
                _isActive = false;
                return _isActive;
            }
            else
            {
                return _isActive;
            }
        }

        public string PrintNames()
        {
            Console.WriteLine("ФИО и номер счета: " + _ownerName + " " + _accountNumber);
            return "";
        }

        public double ReturnCurrentSum()
        {
            return _currentSum;
        }
    }
}
