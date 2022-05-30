using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    public interface IAlgorithms
    {
        #region Ütemezés
        string FCFS(List<ProcessM> processes);
        string RR(List<ProcessM> processes, int timeSliceLenght);
        string PRIO(List<ProcessM> processes, int timeToStartRun);
        string SRTF(List<ProcessM> processes);
        #endregion
        #region Holtpont kezelés

        #endregion
        #region Virtuális tárkezelés

        #endregion
        #region Háttértár kezelés

        #endregion
    }
}
