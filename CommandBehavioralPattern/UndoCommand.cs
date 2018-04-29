using System;
using System.Collections.Generic;
using System.Text;

namespace CommandBehavioralPattern
{
    //LDCOM002
    public class UndoCommand : ICommand
    {
        private int location;

        public int Location
        {
            get { return location; }
        }

        public UndoCommand(int originalLocation)
        {
            location = originalLocation;
        }

        public void Execute()
        {
            new UndoPerformer().Undo(this);
        }
    }

}
