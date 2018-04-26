using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightStructuralPattern
{
    //LDFLY005
    public class LittleAlien : IAlien
    {
        private string shape = "Little Shape";  //intrinsic state

        //LDFLY001
        string IAlien.Shape
        {
            get { return shape; }
        }

        //LDFLY002
        Color IAlien.GetColor(int madLevel)   //extrinsic state
        {
            if (madLevel == 0)
                return Color.Red;
            else if (madLevel == 1)
                return Color.Blue;
            else
                return Color.Green;
        }
    }
}
