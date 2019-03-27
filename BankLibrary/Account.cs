using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public abstract class Account : IAccount
    {
        //******** СОБЫТИЯ ********

        //Событие возникающее при выводе денег
        protected internal event AccountStateHandler Withdrawed;

        //Событие возникающее при добавлении денег на счет
        protected internal event AccountStateHandler Added;

        //Событие возникающее при открытии счета
        protected internal event AccountStateHandler Opened;

        //Событие возникающее при закрытии счета
        protected internal event AccountStateHandler Closed;

        //Событие возникающее при начислении процентов
        protected internal event AccountStateHandler Calculated;

        //****************************

        protected int _id;
        static int counter = 0;

        protected decimal _sum; //Переменная для хранения суммы
        protected int _percentage; //Переменная для хранения процента

        protected int _days = 0; //время с момента открытия счета

        public Account(decimal sum,int percentage)
        {
            _sum = sum;
            _percentage = percentage;
            _id = ++counter;
        }

        public void Put(decimal sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal sum)
        {
            throw new NotImplementedException();
        }
    }
}
