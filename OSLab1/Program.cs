using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Random rand = new Random();
            for (int i=0; i<10; i++)
            {
                Array values = Enum.GetValues(typeof(Priority));
                Priority priora = (Priority)values.GetValue(rand.Next(values.Length));

                int sleep = rand.Next(1, 5);
                Task task = new Task("task" + Convert.ToString(i), priora, sleep);
                worker.addTask(task);
            }
            worker.run();
            Console.WriteLine("All tasks ends");
            Console.ReadKey();
        }
    }
}
