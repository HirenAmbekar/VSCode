using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Multithreading
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }
}
