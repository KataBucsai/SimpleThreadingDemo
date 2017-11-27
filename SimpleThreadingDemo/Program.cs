using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart start = new ThreadStart(Counting);
            Thread thread1 = new Thread(start);
            Thread thread2 = new Thread(start);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.ReadLine();
        }

        static void Counting()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i + " " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
