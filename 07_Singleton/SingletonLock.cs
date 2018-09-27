using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Singleton
{
    internal class SingletonLock
    {
        private static volatile SingletonLock _instance; // Нужно ли объявлять как volatile?
        private static readonly object _lock = new object();

        private SingletonLock()
        {
        }

        public static SingletonLock Instance
        {
            get
            {
                // ReSharper disable once InvertIf
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null) _instance = new SingletonLock();
                    }
                }

                return _instance;
            }
        }
    }
}
