using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        private string _name;

        private int _pid = 0;
        public int pid {
            get {
                return _pid;
            }
            set {
                _pid = value;
            }
        }
        private Priority _priority;
        public Priority priority { get { return _priority; } }

        private TimeSpan workTime = new TimeSpan(0);
        private int _timeToSleep;

        public Task(string name, Priority priority, int timeToSleep)
        {
            _name = name;
            _priority = priority;
            _timeToSleep = timeToSleep;
        }

        public void run()
        {
            var start = DateTime.Now;
            Thread.Sleep(_timeToSleep*1000);
            workTime = DateTime.Now - start;
            Console.WriteLine("Task " + _name + " pid " + _pid + " priority " + priority + " ends with time " + workTime.TotalMilliseconds + "ms" );
        }
    }
}
