using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        //public static Singleton singletonCommon = new Singleton();//只构造一个对象

        private static void Main(string[] args)
        {
            ////Singleton singleton = Singleton.CreateInstance(); //new Singleton();//只构造一个对象
            ////for (int i = 0; i < 10; i++)
            ////{
            ////    Singleton singleton = Singleton.CreateInstance();
            ////    Singleton singleton = new Singleton();//
            ////    singletonCommon.Load();
            ////    singleton.Load();
            ////}

            ////SubClass1.SubSingleton();
            ////SubClass2.SubSingleton();
            ////SubClass3.SubSingleton();

            for (int i = 0; i < 10; i++)
            {
                new Action(() =>
                {
                    Singleton singleton = Singleton.CreateInstance();
                    singleton.Load();
                }).BeginInvoke(null, null);
            }

            Console.Read();
        }
    }
}