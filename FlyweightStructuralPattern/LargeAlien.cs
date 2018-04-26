using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightStructuralPattern
{
    //LDFLY005
    public class LargeAlien : IAlien
    {
        private string shape = "Large Shape";  //intrinsic state

        //LDFLY001
        string IAlien.Shape
        {
            get { return shape; }
        }

        //LDFLY002
        Color IAlien.GetColor(int madLevel)   //extrinsic state
        {
            if (madLevel == 0)
                return Color.Green;
            else if (madLevel == 1)
                return Color.Red;
            else
                return Color.Blue;
        }
    }
}
