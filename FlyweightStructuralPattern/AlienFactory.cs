using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightStructuralPattern
{
    //LDFLY003
    public class AlienFactory
    {
        private Dictionary<int, IAlien> list = new Dictionary<int, IAlien>();

        public void SaveAlien(int index, IAlien alien)
        {
            list.Add(index, alien);
        }

        public IAlien GetAlien(int index)
        {
            return list[index];
        }
    }

}
