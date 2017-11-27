using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback waitCallback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(waitCallback, "Hello");
            ThreadPool.QueueUserWorkItem(waitCallback, "Hi");
            ThreadPool.QueueUserWorkItem(waitCallback, "Heya");
            ThreadPool.QueueUserWorkItem(waitCallback, "Goodbye");
            Console.ReadKey();
        }

        static void ShowMyText(object state)
        {
            string text = state.ToString();
            Console.WriteLine(text + " " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
