using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton()
        {
            Thread.Sleep(1000);
            string data = "这里需存储1GB数据";
            string resource = "这里需要加载1GB资源文件";
            Console.WriteLine("{0}：，线程ID{1}, 加载数据：{2}，加载资源：{3}", this.GetType().Name, Thread.CurrentThread.ManagedThreadId, data, resource);
        }

        private static Singleton _Singleton = null;
        private static object _Lock = new object();

        public static Singleton CreateInstance()
        {
            //不需要等待锁
            if (_Singleton == null)
            {
                lock (_Lock)
                {
                    if (_Singleton == null)
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }

        public void Load()
        {
            Console.WriteLine("Show方法被调用：{0}", this.GetType().Name);
        }
    }
}