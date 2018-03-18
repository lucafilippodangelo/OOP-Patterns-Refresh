using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    //LD_MEDIATOR_004 this class has a reference to the "Mediator"
    public abstract class ColleagueAbstract
    {
        protected IMediator _mediator;

        public ColleagueAbstract(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
