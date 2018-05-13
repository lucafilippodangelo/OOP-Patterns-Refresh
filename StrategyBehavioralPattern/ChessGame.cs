using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyBehavioralPattern
{
    //LDSTR003
    public class ChessGame
    {
        private IComputerPlayer computerPlayer;

        public IComputerPlayer ComputerPlayer
        {
            get { return computerPlayer; }
            set { computerPlayer = value; }
        }

        public void Move()
        {
            computerPlayer.MakeMove();   //exhibit the behavior
        }
    }
}
