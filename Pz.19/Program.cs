namespace Pz._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип счета:");
            Console.WriteLine("1. Дебетовый счет");
            Console.WriteLine("2. Кредитный счет");
            Console.WriteLine("3. Накопительный счет");
            Console.Write("Введите номер выбранного типа счета: ");
            int accountType = int.Parse(Console.ReadLine());

            BankAccount account;

            switch (accountType)
            {
                case 1:
                    account = new DebitAccount();
                    break;
                case 2:
                    account = new CreditAccount();
                    break;
                case 3:
                    account = new SavingsAccount();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Программа завершена.");
                    return;
            }

            Console.Write("Введите номер счета: ");
            account.AccountNumber = Console.ReadLine();
            Console.Write("Введите имя владельца счета: ");
            account.AccountHolder = Console.ReadLine();

            Console.Write("Введите сумму для пополнения счета: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Введите сумму для снятия со счета: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            Console.ReadLine();
        }
    }
}
