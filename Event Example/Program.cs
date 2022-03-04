using System;

namespace Event_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes a member of staff called Jane
            Staff Jane = new("Jane");
            Console.WriteLine("Press enter to simulate another transaction.");
            while (true)
            {
                // simulates transactions in an infinite loop.
                Console.ReadLine();
                Transaction.AnotherTransaction();
            }
        }
    }
}
