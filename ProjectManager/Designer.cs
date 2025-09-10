using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Designer : IWorker
    {
        public void Worker(string task)
        {
            Console.WriteLine($"Design coding....{task}");
        }
    }
}
