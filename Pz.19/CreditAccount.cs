using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz._19
{
    public class CreditAccount : BankAccount
    {
        private decimal interestRate = 10; // Проценты по счету

        // Переопределение метода пополнения счета
        public override void Deposit(decimal amount)
        {
            decimal minDeposit = balance + (balance * (interestRate / 100));
            if (amount >= minDeposit)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine($"Минимальная сумма пополнения должна быть не менее {minDeposit} рублей.");
            }
        }

        // Переопределение метода снятия средств со счета
        public override void Withdraw(decimal amount)
        {
            decimal withdrawalAmount = amount + (amount * 0.1m); // Сумма снятия с комиссией 10%
            if (withdrawalAmount <= Balance)
            {
                base.Withdraw(withdrawalAmount);
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете для снятия указанной суммы.");
            }
        }
    }
}
