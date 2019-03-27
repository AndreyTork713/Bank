using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public interface IAccount
    {
        //Положить деньги на счет
        void Put(decimal sum);

        //Снять деньги со счета
        void Withdraw(decimal sum);
        
    }
}
