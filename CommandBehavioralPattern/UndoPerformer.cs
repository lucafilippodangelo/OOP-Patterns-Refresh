using System;
using System.Collections.Generic;
using System.Text;

namespace CommandBehavioralPattern
{
    //LDCOM003
    public class UndoPerformer
    {
        public void Undo(ICommand c)
        {
            if (c is UndoCommand)
            {
                int originalLocation = (c as UndoCommand).Location;
                Console.WriteLine("Moving back to position: " + originalLocation);
            }
        }
    }
}
