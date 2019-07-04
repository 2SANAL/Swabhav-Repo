using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViloationApp
{
    interface IWorker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
