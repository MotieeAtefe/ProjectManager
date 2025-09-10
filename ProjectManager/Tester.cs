using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Tester : IWorker
    {
        public void Worker(string task)
        {
            Console.WriteLine($"the Tester debuging code, {task}");
        }
    }
}
