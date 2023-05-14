using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N1
{
    public class Program
    {
        static void Main(string[] args)
        {
            N1 n1 = new N1();
            EventHandler handler1 = (sender, e) =>
            {
                Console.WriteLine($"Handler 1 triggered at {DateTime.Now}");
            };
            EventHandler handler2 = (sender, e) =>
            {
                Console.WriteLine($"Handler 2 triggered at {DateTime.Now}");
            };
            n1.RegisterEventHandler("event1", handler1);
            n1.RegisterEventHandler("event1", handler2);
            for (int i = 0; i < 10; i++)
            {
                n1.TriggerEvent("event1", EventArgs.Empty, 1000);
                Thread.Sleep(500);
            }
            n1.UnregisterEventHandler("event1", handler2);
            for (int i = 0; i < 10; i++)
            {
                n1.TriggerEvent("event1", EventArgs.Empty, 1000);
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
