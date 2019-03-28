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

        //Текущая сумма на счету
        public decimal CurrentSum
        {
            get { return _sum; }
        }

        public int Percentage { get { return _percentage; } }

        public int ID { get { return _id; } }

        //****** ВЫЗОВ СОБЫТИЙ ******

        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if (handler != null && e != null)
            {
                handler(this, e);
            }
        }
        //Вызов отдельных событий. Для каждогособытия определяется свой виртуальный метод
        protected virtual void OnOpen(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }

        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }

        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }

        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }

    }
}
