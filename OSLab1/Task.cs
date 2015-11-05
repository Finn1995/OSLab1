using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab1
{
    enum Priority
    {
        Lazy,
        Low,
        Normal,
        High,
        Critical
    };

    class Task
    {
        string _name;
        int _pid;
        Priority _priority;
        TimeSpan workTime = new TimeSpan(0);

        Task(string name, Priority priority, int timeToSleep)
        {
            _name = name;
            _priority = priority;
        }
    }
}
