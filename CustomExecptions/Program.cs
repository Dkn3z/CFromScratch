namespace CustomExecptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account = new BankAccount("123456", 1000);
                Console.WriteLine($" I'm going to buy flowers: {account.Withdraw(500)}");
                Console.WriteLine($" I'm going to take her to Cinepolis: {account.Withdraw(600)}");

            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient balance: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }

    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() : base("Insufficient balance for this operation.")
        {
        }
        public InsufficientBalanceException(string message) : base(message)
        {
        }
        public InsufficientBalanceException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InsufficientBalanceException($"Cannot withdraw {amount} from account {AccountNumber}. Current balance is {Balance}.");
            }
            Balance -= amount;
        
            return $"Withdrawal of {amount} successful. New balance is {Balance}.";
        }
    }
}
