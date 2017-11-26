using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IMediator
    {
        //LD STEP001 the Mediator has the ability to send the specific message "msg" created by a caller.
        // the caller will be a concrete "Colleague"
        void SendMessage(ColleagueAbstract caller, string msg);
    }
}
