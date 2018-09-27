using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Singleton
{
    internal class SingletonNonThreadSafe
    {
        private static SingletonNonThreadSafe _instance;

        public static SingletonNonThreadSafe Instance => _instance ?? 
                                                         (_instance = new SingletonNonThreadSafe());

        private SingletonNonThreadSafe()
        {
        }
    }
}
