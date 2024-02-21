using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz._19
{
    public class SavingsAccount : BankAccount
    {
        private decimal interestRate = 0.1m; // Проценты по вкладу

        // Переопределение метода пополнения счета
        public override void Deposit(decimal amount)
        {
            if (amount >= 10000)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Минимальная сумма для открытия счета должна быть не менее 10000 рублей.");
            }
        }

        // Переопределение метода снятия средств со счета
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Нельзя снимать средства с накопительного счета до истечения срока вклада.");
        }

        // Метод для снятия средств с накопительного счета после определенного количества лет
        public void WithdrawAfterYears(int years)
        {
            decimal totalAmount = Balance * (1 + interestRate * years);
            Console.WriteLine($"Сумма с учетом процентов после {years} лет: {totalAmount}");
        }
    }
}
