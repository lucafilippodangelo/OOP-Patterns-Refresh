using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ColleagueThree : ColleagueAbstract
    {
        public ColleagueThree(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            Console.WriteLine("ColleagueThree send message:" + msg);
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("ColleagueThree receive message:" + msg);
        }
    }
}
