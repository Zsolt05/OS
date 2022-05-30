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

        public string[] RR(List<ProcessM> processes, int timeSliceLenght, int numOfBoxes)
        {
            bool done = false;
            string schedule = "";
            string answer = "";
            var sortedList = sortArrayASC(processes);
            int time = 0;
            int boxes = 0;
            while (!done)
            {
                bool canrun = false;
                foreach (var process in sortedList.ToList())
                {
                    canrun = false;
                    if (sortedList.Where(x=>x.TimeToRun <= time).Any())
                    {
                        canrun = true;
                        if (process.RunTime <= timeSliceLenght)
                        {
                            schedule += $"{process.Name}[{time}-{time + process.RunTime}]" + (sortedList.Count == 1 ? "" : "->");
                            answer += $"{process.Name}{(boxes == numOfBoxes ? "" : "->")}";
                            time += process.RunTime;
                            boxes++;
                            sortedList.Remove(process);
                        }
                        else
                        {
                            schedule += $"{process.Name}[{time}-{time + timeSliceLenght}*]" + (sortedList.Count == 1 ? "" : "->");
                            answer += $"{process.Name}{(boxes == numOfBoxes ? "" : "->")}";
                            process.RunTime = process.RunTime - timeSliceLenght;
                            time += timeSliceLenght;
                            boxes++;
                        }
                    }
                    if (!canrun)
                    {
                        answer += "\"-\"" + (sortedList.Count == 1 && boxes == numOfBoxes ? "" : "->");
                        time++;
                        boxes++;
                    }
                }
                if (!canrun)
                {
                    time++;
                    boxes++;
                    answer += "\"-\"" + (boxes == numOfBoxes ? "" : "->");
                }
                if (boxes == numOfBoxes && sortedList.Count == 0)
                {
                    done = true;
                }
            }
            string[] result = { schedule, answer };
            return result;
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
