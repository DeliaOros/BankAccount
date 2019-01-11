using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class IbanAccount
    {
        private StringBuilder ibanCode;

        public StringBuilder IbanCode

        {
            get { return ibanCode; }
            set { ibanCode = value; }
        }

        public IbanAccount(long account)
        {
            if (account > 100000000000)
            {
                StringBuilder ibanCode = new StringBuilder();
                ibanCode.Append("RO");
                ibanCode.Append(CheckNumber(account));
                ibanCode.Append("BANK");
                ibanCode.Append(account);
                Console.WriteLine(ibanCode.ToString());
                this.IbanCode = ibanCode;
            }

        }
        private long CheckNumber(long number)
        {
            long checkNumber = 0;
            if (number > 100000000000)
            {
                while (number > 10)
                {
                    checkNumber += number % 10;
                    number = number % 10;
                }
                checkNumber += number;
                checkNumber = checkNumber % 100;
            }
            return checkNumber;
        }

        public override string ToString()
        {
            return $"IBAN account: {this.IbanCode}";
        }

    }
}
