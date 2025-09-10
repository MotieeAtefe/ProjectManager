using ProjectManager;
using System;



namespace ProjectManager
{
    class Program
    {
        static void Main()
        {
            ProjectManager PM = new ProjectManager(new Programmer());
            PM.AssignTask("fixing bug...");
            PM = new ProjectManager(new Tester());
            PM.AssignTask("Testing bug...");
            PM = new ProjectManager(new Designer());
            PM.AssignTask("Design programm...");
        }
    }



}