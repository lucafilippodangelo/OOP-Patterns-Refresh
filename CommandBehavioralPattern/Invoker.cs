using System;
using System.Collections.Generic;
using System.Text;

namespace CommandBehavioralPattern
{
    //LDCOM004
    public class Invoker
    {
        private Stack<ICommand> commandList = new Stack<ICommand>();

        public void RunCommand()
        {
            while (commandList.Count > 0)
                commandList.Pop().Execute();
        }

        public void AddCommand(ICommand c)
        {
            commandList.Push(c);
        }
    }
}
