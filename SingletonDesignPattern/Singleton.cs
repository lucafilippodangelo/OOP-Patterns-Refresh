using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonCreationalPattern
{
    public sealed class Singleton
    {
        public static void Main(string[] args) {}

        private static Singleton _instance = null;
        private static object syncLock = new object();// Lock synchronization object

        //LD The private constructor will make sure that the class can't be instantiated from outside.
        private Singleton() { }

        /*
         * property which will return the static instance of the object present within the class itself. 
         * Hence the object will be shared between all the external entities.
         */
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance; 
            }
        }
    }

}



