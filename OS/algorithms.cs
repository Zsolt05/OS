using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    public class Algorithms : IAlgorithms
    {
        public string FCFS(List<ProcessM> processes)
        {
            List<ProcessM> sorted = sortArrayASC(processes);
            string result = "";
            for (int i = 0; i < sorted.Count; i++)
            {
                if (sorted.Count - 1 == i)
                {
                    result += sorted[i].Name;
                }
                else
                {
                    result += sorted[i].Name + "->";
                }
            }
            return result;
        }

        public string RR(List<ProcessM> processes, int timeSliceLenght)
        {
            throw new NotImplementedException();
        }

        public string PRIO(List<ProcessM> processes, int timeToStartRun)
        {
            throw new NotImplementedException();
        }

        public string SRTF(List<ProcessM> processes)
        {
            throw new NotImplementedException();
        }

        List<ProcessM> sortArrayASC(List<ProcessM> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[i].TimeToRun > array[j].TimeToRun)
                    {
                        ProcessM a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            return array;
        }
    }
}
