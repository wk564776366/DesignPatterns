using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SubClass2
    {
        public static void SubSingleton()
        {
            Console.WriteLine("This is SubClass2");
            Singleton singleton = Singleton.CreateInstance();// new Singleton();
            singleton.Load();
        }
    }
}