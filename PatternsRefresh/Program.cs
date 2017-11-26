using MediatorDesignPattern;
using System;

namespace PatternsRefresh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RunMediatorDesignPattern = true;
            
            //LD STEP006
            #region Mediator Design Pattern
            if (RunMediatorDesignPattern)
            { 
                Mediator lucaMediator = new Mediator(); //LD creation instance of "Mediator"
                
                ColleagueOne c1 = new ColleagueOne(lucaMediator); //LD creation of concrete instance of "Coleague", need to pass "Mediator" instance
                lucaMediator.c1 = c1; //LD set "c1" in concrete "Mediator" instance

                ColleagueTwo c2 = new ColleagueTwo(lucaMediator);
                lucaMediator.c2 = c2;

                ColleagueThree c3 = new ColleagueThree(lucaMediator);
                lucaMediator.c3 = c3;

                //LD test of "Mediator" logic
                c1.Send("msg001");
                c2.Send("msg002");

                Console.ReadLine();
            }
            #endregion
        }
    }
}
