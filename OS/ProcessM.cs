using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    
    public class ProcessM
    {
        private static int tableWidth = 73;
        public string Name { get; set; }
        public int RunTime { get; set; }
        public int TimeToRun { get; set; }
        public ProcessM(){}
        public ProcessM(string name, int runTime, int timeToRun)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            RunTime = runTime;
            TimeToRun = timeToRun;
        }
        #region Process Table Writer
        /*
         * Stackoverflow link: 
         * https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c
         */

        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        public void PrintRow(bool header = false,bool prio = false)
        {
            int width = (tableWidth - 3) / 3;
            string row = "|";
            row += AlignCentre(header ? "Folyamat" : this.Name, width) + "|";
            row += AlignCentre(header ? "Futásidő" : this.RunTime.ToString(), width) + "|";
            row += AlignCentre(header ? (prio ? "Prioritás" : "Futásra kész idő") : this.TimeToRun.ToString(), width) + "|";

            Console.WriteLine(row);
            PrintLine();
        }
        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        #endregion
    }
}
