using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Programmer : IWorker
    {
        public void Worker(string task)
        {
            Console.WriteLine($"Programer, program new application, {task}");
        }
    }
}
