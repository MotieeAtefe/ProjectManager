using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class ProjectManager 
    {
       private IWorker _worker;
        public ProjectManager(IWorker worker)
        {
            _worker = worker;
        }

        public void AssignTask(string task)
        {
            Console.WriteLine("Manager assigning task....");
            _worker.Worker(task);
        }
    }
}
