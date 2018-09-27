using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Singleton
{
    internal class SingletonThreadSafe
    {
        private static readonly Lazy<SingletonThreadSafe> _lazy =
            new Lazy<SingletonThreadSafe>(() => new SingletonThreadSafe());

        public static SingletonThreadSafe Instance => _lazy.Value;

        private SingletonThreadSafe()
        {
        }
    }
}
