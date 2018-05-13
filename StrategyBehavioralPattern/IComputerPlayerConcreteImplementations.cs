using System;
using System.Collections.Generic;
using System.Text;

//LDSTR002
namespace StrategyBehavioralPattern
{
    public class EasyComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer made an Easy move.");
        }
    }

    public class MediumComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer made an Medium move.");
        }
    }

    public class AdvancedComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer made an Advanced move.");
        }

    }

}
