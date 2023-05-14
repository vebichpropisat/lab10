using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            N2 n2 = new N2(2000);
            PrioritySubscriber sub1 = new PrioritySubscriber(1);
            PrioritySubscriber sub2 = new PrioritySubscriber(2);
            PrioritySubscriber sub3 = new PrioritySubscriber(3);
            PrioritySubscriber sub4 = new PrioritySubscriber(4);
            n2.Register("EvenEvent", 1, new EventHandler(sub1.HandleEvent));
            n2.Register("EvenEvent", 2, new EventHandler(sub2.HandleEvent));
            n2.Register("OddEvent", 3, new EventHandler(sub3.HandleEvent));
            n2.Register("OddEvent", 4, new EventHandler(sub4.HandleEvent));
            Pub pub = new Pub(n2);
            pub.SendEvent();
        }
    }
}