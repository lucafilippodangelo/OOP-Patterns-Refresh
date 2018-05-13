using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodBehavioralPattern
{
    //LDTEM002
    public class PorcheBuilder : AbstractCarBuilder
    {
        protected override void BuildSkeleton()
        {
            Console.WriteLine("Building Porche Skeleton");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Installing Porche Engine");
        }

        protected override void InstallDoor()
        {
            Console.WriteLine("Installing Porche Door");
        }
    }

    //LDTEM003
    public class BeetleBuilder : AbstractCarBuilder
    {
        protected override void BuildSkeleton()
        {
            Console.WriteLine("Building Beetle Skeleton");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Installing Beetle Engine");
        }

        protected override void InstallDoor()
        {
            Console.WriteLine("Installing Beetle Door");
        }
    }
}
