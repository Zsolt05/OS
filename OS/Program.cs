
namespace OS
{
    public class Program
    {
        readonly IAlgorithms algorithms = new Algorithms();
        static void Main(string[] args)
        {
            new Program().Start();
        }

        private void Start()
        {
            var list = new List<ProcessM>();
            #region FCFS
            /*
            list.Add(new ProcessM { Name = "P" + 1, RunTime = 3, TimeToRun = 1 });
            list.Add(new ProcessM { Name = "P" + 2, RunTime = 6, TimeToRun = 3 });
            list.Add(new ProcessM { Name = "P" + 3, RunTime = 2, TimeToRun = 0 });
            list.Add(new ProcessM { Name = "P" + 4, RunTime = 1, TimeToRun = 10 });
            list.Add(new ProcessM { Name = "P" + 5, RunTime = 3, TimeToRun = 4 });
            TaskWrite(list);
            Console.WriteLine(($"Ütemezés:\t{algorithms.FCFS(list)}\n");
            */
            #endregion
            #region RR
            list.Add(new ProcessM { Name = "P" + 1, RunTime = 3, TimeToRun = 3 });
            list.Add(new ProcessM { Name = "P" + 2, RunTime = 6, TimeToRun = 2 });
            list.Add(new ProcessM { Name = "P" + 3, RunTime = 2, TimeToRun = 0 });
            list.Add(new ProcessM { Name = "P" + 4, RunTime = 5, TimeToRun = 4 });
            TaskWrite(list);
            var rrResult = algorithms.RR(list, 5,8);
            Console.WriteLine($"Ütemezés:\t{rrResult[0]}\nMegoldás:\t{rrResult[1]}\n");
            #endregion

        }
        private void TaskWrite(List<ProcessM> tasks,bool prio = false)
        {
            Console.Clear();
            ProcessM.PrintLine();
            tasks[0].PrintRow(true,prio);
            foreach (var task in tasks)
            {
                task.PrintRow();
            }
            Console.WriteLine();
        }
    }
}