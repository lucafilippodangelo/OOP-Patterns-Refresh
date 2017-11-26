using MediatorDesignPattern;
using System;

namespace PatternsRefresh
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mediator Design Pattern
            
            //LD STEP006
            Mediator lucaMediator = new Mediator();
            
            ColleagueOne c1 = new ColleagueOne(lucaMediator);
            lucaMediator.c1 = c1;

            ColleagueTwo c2 = new ColleagueTwo(lucaMediator);
            lucaMediator.c2 = c2;

            ColleagueThree c3 = new ColleagueThree(lucaMediator);
            lucaMediator.c3 = c3;

            c1.Send("msg001");
            c2.Send("msg002");

            Console.ReadLine();

            #endregion
        }
    }
}
