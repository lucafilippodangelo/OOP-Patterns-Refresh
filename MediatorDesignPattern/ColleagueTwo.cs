using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ColleagueTwo : ColleagueAbstract
    {
        public ColleagueTwo(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            Console.WriteLine("ColleagueTwo send message:" + msg);
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("ColleagueTwo receive message:" + msg);
        }

    }
}
