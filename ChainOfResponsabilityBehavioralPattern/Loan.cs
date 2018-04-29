using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsabilityBehavioralPattern
{
    public class Loan
    {
        private int amount;

        public int Amount
        {
            get { return amount; }
        }

        public Loan(int amount)
        {
            this.amount = amount;
        }
    }
}
