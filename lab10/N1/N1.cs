using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    public delegate void EventHandler(object sender, EventArgs args);

    public class N1
    {
        private Dictionary<string, EventHandler> eventHandlers = new Dictionary<string, EventHandler>();
        private Dictionary<string, DateTime> lastTriggeredTime = new Dictionary<string, DateTime>();
        public void RegisterEventHandler(string eventName, EventHandler handler)
        {
            if (!eventHandlers.ContainsKey(eventName))
            {
                eventHandlers[eventName] = null;
            }
            eventHandlers[eventName] += handler;
        }
        public void UnregisterEventHandler(string eventName, EventHandler handler)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                eventHandlers[eventName] -= handler;
            }
        }
        public void TriggerEvent(string eventName, EventArgs args, int throttleMilliseconds)
        {
            if (eventHandlers.ContainsKey(eventName))
            {
                DateTime lastTimeTriggered;
                if (!lastTriggeredTime.TryGetValue(eventName, out lastTimeTriggered))
                {
                    lastTimeTriggered = DateTime.MinValue;
                }
                if (DateTime.Now.Subtract(lastTimeTriggered).TotalMilliseconds >= throttleMilliseconds)
                {
                    eventHandlers[eventName]?.Invoke(this, args);
                    lastTriggeredTime[eventName] = DateTime.Now;
                }
            }
        }
    }
}
