using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsabilityBehavioralPattern
{
    //LDCOR001 
    public abstract class LoanApprover
    {
        //LDCOR002
        protected LoanApprover nextApprover;

        //LDCOR003
        public void SetNextApprover(LoanApprover nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        //LDCOR004
        public abstract void ApproveLoan(Loan i);
    }
}
