using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab1
{
    class Worker
    {
        private List<Task> _tableOfTasks;
        public List<Task> table { get { return _tableOfTasks; } }
        Random rand = new Random();
        public void addTask(Task task)
        {
            var query =
                from tsk in table
                select tsk.pid;
            int pid = rand.Next(1, 9999);
            while(query.Select(x => x).Contains(pid)){
                pid = rand.Next(1, 9999);
            }
            task.pid = pid;
            _tableOfTasks.Add(task);
        }

        public Worker()
        {
            _tableOfTasks = new List<Task>();
        }

        public void run() {
            this.sort();
            while (table.Count > 0)
            {
                Task task = _tableOfTasks.First();
                task.run();
                _tableOfTasks.Remove(_tableOfTasks.First());
            }
        }

        public void sort()
        {
            _tableOfTasks.Sort((x, y) => y.priority.CompareTo(x.priority));
        }
    }
}
