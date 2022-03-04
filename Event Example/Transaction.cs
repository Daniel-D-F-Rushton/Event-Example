using System;

namespace Event_Example
{
    public static class Transaction
    {
        // keeps count of the number of transactions
        public static int NumberOfTransactions { get; set; } = 999990;
        // Emulates a new transaction.
        public static void AnotherTransaction()
        {
            NumberOfTransactions++;
            Console.Write(Transaction.NumberOfTransactions + " purcahses:");
            // checks to see if there has been a million transactions
            if (NumberOfTransactions == 1000000) MillionTransactions(new(), EventArgs.Empty);
        }

        // This is what the member of staff 'subscribes to' When it activates they are notified.
        public static event EventHandler MillionTransactions;
    }
}