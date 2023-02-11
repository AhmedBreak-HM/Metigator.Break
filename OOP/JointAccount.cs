using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class JointAccount
    {
        private const int MaxAccountSize = 3;

        private Account[] _accountList = new Account[MaxAccountSize];

        public Account this[int index]
        {

            get
            {
                if (index >= 0 && index <= -1)
                    return _accountList[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index <= -1)
                    _accountList[index] = value;
            }
        }
    }
}
