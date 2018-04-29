using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsabilityBehavioralPattern
{
    //LDCOR005
    public class Manager : LoanApprover
    {
        public override void ApproveLoan(Loan i)
        {
            if (i.Amount <= 100000)
                Console.WriteLine("Loan amount of " + i.Amount + " approved by the Manager");
            else
                nextApprover.ApproveLoan(i);
        }
    }

    public class Director : LoanApprover
    {
        public override void ApproveLoan(Loan i)
        {
            if (i.Amount <= 250000)
                Console.WriteLine("Loan amount of " + i.Amount + " approved by the Director");
            else
                nextApprover.ApproveLoan(i);
        }
    }

    public class VicePresident : LoanApprover
    {
        public override void ApproveLoan(Loan i)
        {
            Console.WriteLine("Loan amount of " + i.Amount + " approved by the Vice President");
        }
    }
}
