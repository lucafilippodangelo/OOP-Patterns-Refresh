using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodBehavioralPattern
{
    //LDTEM001
    public abstract class AbstractCarBuilder
    {
        protected abstract void BuildSkeleton();
        protected abstract void InstallEngine();
        protected abstract void InstallDoor();

        //Template Method that specifies the general logic
        public void BuildCar()
        {
            BuildSkeleton();
            InstallEngine();
            InstallDoor();
        }
    }
}
