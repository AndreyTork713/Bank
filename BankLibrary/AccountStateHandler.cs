using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{

    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        //СООБЩЕНИЕ
        public string Message { get; private set; }

        //СУММА на которую изменился счет
        public decimal Sum { get;private set; }

        public AccountEventArgs(string _mes,decimal _sum)
        {
            Message = _mes;
            Sum = _sum;
        }

    }

}