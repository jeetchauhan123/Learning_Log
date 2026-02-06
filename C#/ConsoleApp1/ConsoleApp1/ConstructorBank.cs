using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ConstructorBank
    {
        int accno;
        string acchold;
        double Balance;
        public ConstructorBank(int no, string hold, double Bal)
        {
            accno = no;
            acchold = hold;
            Balance = Bal;
        }
        internal void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {accno}");
            Console.WriteLine($"Account Holder Name: {acchold}");
            Console.WriteLine($"Account Balance: {Balance}");
        }
    }
}
