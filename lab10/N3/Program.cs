using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    public class Program
    {
        static void Main(string[] args)
        {
            N3 eventBus = new N3(5, 1000, 5000, 1.5);
            Publisher publisher = new Publisher(eventBus);
            Priority sub1 = new Priority(1);
            Priority sub2 = new Priority(2);
            Priority sub3 = new Priority(3);
            eventBus.Register("OddEvent", sub1.Priorit, new Action<object, EventArgs>(sub1.HandleEvent));
            eventBus.Register("EvenEvent", sub2.Priorit, new Action<object, EventArgs>(sub2.HandleEvent));
            eventBus.Register("OddEvent", sub3.Priorit, new Action<object, EventArgs>(sub3.HandleEvent));
            publisher.SendEvent();
            Console.ReadLine();
        }
    }
}