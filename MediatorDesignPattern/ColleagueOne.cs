using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    //LD STEP005 any concrete "Colleague" class can "Send" and "Receive" messages from the "Mediator".
    // the class use a referement to "Mediator" 
    public class ColleagueOne : ColleagueAbstract
    {
        public ColleagueOne(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            Console.WriteLine("ColleagueOne send message:" + msg);
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("ColleagueOne receive message:" + msg);
        }
    }
}
