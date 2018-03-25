using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class Mediator : IMediator
    {
        public static void Main(string[] args) { }

        //LD_MEDIATOR_002 the concrete "Mediator" has referiment to the objects that need to communicate
        public ColleagueOne c1 { get; set; }
        public ColleagueTwo c2 { get; set; }
        public ColleagueThree c3 { get; set; }

        public void SendMessage(ColleagueAbstract caller, string msg)
        {
            //LD_MEDIATOR_003 the concrete "Mediator" cointain the logic to distribute the messages
            if (caller == c1)
            {
                c2.Receive(msg);
                c3.Receive(msg);
            }

            if (caller == c2)//else
                c1.Receive(msg);
        }
    }
}
