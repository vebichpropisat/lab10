using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    public class Priority
    {
        public int Priorit { get; set; }

        public Priority(int priority)
        {
            Priorit = priority;
        }
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine(Priorit);
        }
    }
}
