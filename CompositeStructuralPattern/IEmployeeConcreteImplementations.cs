using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeStructuralPattern
{
    public class IEmployeeConcreteImplementations
    {
        //LDCMP001
        public class Worker : IEmployee
        {
            private string name;
            private int happiness;

            public Worker(string name, int happiness)
            {
                this.name = name;
                this.happiness = happiness;
            }

            void IEmployee.ShowHappiness()
            {
                Console.WriteLine(name + " showed happiness level of " + happiness);
            }
        }

        //LDCMP002
        public class Supervisor : IEmployee
        {
            private string name;
            private int happiness;

            private List<IEmployee> subordinate = new List<IEmployee>();

            public Supervisor(string name, int happiness)
            {
                this.name = name;
                this.happiness = happiness;
            }

            void IEmployee.ShowHappiness()
            {
                Console.WriteLine(name + " showed happiness level of " + happiness);
                //show all the subordinate's happiness level
                foreach (IEmployee i in subordinate)
                    i.ShowHappiness();
            }

            public void AddSubordinate(IEmployee employee)
            {
                subordinate.Add(employee);
            }
        }
    }
}
