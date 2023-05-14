using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Workflow початок");
            Console.WriteLine();
            var workflow = new Workflow();
            workflow.ActionAdded += OnActionAdded;
            workflow.ActionCompleted += OnActionCompleted;
            workflow.WorkflowCompleted += OnWorkflowCompleted;
            workflow.Run();
            Console.WriteLine("Workflow кiнець");
        }
        private static void OnActionAdded(object sender, ActionEventArgs a)
        {
            Console.WriteLine(a.Action.Name);
            Console.WriteLine();
        }
        private static void OnActionCompleted(object sender, ActionEventArgs a)
        {
            Console.WriteLine(a.Action.Name);
            Console.WriteLine();
        }
        private static void OnWorkflowCompleted(object sender, EventArgs a)
        {
            Console.WriteLine("Workflow виконано");
            Console.WriteLine();
        }
    }
}
