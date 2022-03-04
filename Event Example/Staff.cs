using System;

namespace Event_Example
{
    // Staff class to emulate a person performing a task
    public class Staff
    {
        private readonly string _Name;
        public Staff(string name)
        {
            // set the name of the staff
            _Name = name;
            // says that the staff member wishes to be subscribed, and notified when a million transactions have taken place
            Transaction.MillionTransactions += this.StaffSaysCongratulations;
        }

        // this is what happens when the millionth transaction takes place, (according to this member of staff)
        private void StaffSaysCongratulations(object sender, EventArgs e)
        {
            Console.WriteLine($" Hi, I'm {_Name}, Congratulations on making the 1000000th purchase!");
        }
    }
}