using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void Eventhandler();
    public class EventHandler
    {
        public static event Eventhandler del;
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("usa");
        }
        public static void Uk()
        {
            Console.WriteLine("uk");
        }
        public static void EventImplement()
        {
            del += new Eventhandler(India);
            del += new Eventhandler(USA);
            del += new Eventhandler(Uk);
            del.Invoke();
        }
    }
}

