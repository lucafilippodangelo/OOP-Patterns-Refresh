using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightStructuralPattern
{
    //LDFLY004
    public interface IAlien
    {
        string Shape { get; }  //intrinsic state

        Color GetColor(int madLevel);  //extrinsic state
    }
}
