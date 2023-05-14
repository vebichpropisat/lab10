using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N3
{
    public class Pub
    {
        private global::N3 n3;
        public Pub(global::N3 n3)
        {
            this.n3 = n3;
        }
        public void SendEvent()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    n3.Send("EvenEvent", this, EventArgs.Empty);
                }
                else
                {
                    n3.Send("OddEvent", this, EventArgs.Empty);
                }
                Thread.Sleep(2000);
            }
        }
    }
}
