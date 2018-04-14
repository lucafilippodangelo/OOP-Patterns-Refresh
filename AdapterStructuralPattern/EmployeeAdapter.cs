using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterStructuralPattern
{
    //LDADP002
    //LD this is the most important class, inherits from the Consultant class while it implements the IEmployee interface:
    public class EmployeeAdapter : Consultant, IEmployee
    {
        public EmployeeAdapter(string name) : base(name)
        {
        }

        //LDADP003
        void IEmployee.ShowHappiness()
        {
            base.ShowSmile();  //call the parent Consultant class
        }
    }
}
