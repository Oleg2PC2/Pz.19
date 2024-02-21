using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz._19
{
    public class BankAccount
    {
        // Поля класса
        protected string accountNumber;
        protected decimal balance;
        protected string accountHolder;

        // Свойства для доступа к полям
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        // Виртуальный метод для пополнения счета
        public virtual void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Счет {accountNumber}: пополнение на сумму {amount}. Новый баланс: {balance}");
        }

        // Виртуальный метод для снятия средств со счета
        public virtual void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Со счета {accountNumber} снято {amount}. Новый баланс: {balance}");
            }
            else
            {
                Console.WriteLine($"Недостаточно средств на счете {accountNumber} для снятия {amount}");
            }
        }
    }

    public class DebitAccount : BankAccount
    {
        // Переопределение метода пополнения счета
        public override void Deposit(decimal amount)
        {
            if (amount >= 100)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Минимальная сумма пополнения должна быть не менее 100 рублей.");
            }
        }

        // Переопределение метода снятия средств со счета
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете для снятия указанной суммы.");
            }
        }
    }
}
