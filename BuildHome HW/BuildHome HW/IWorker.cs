using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    interface IWorker
    {
        abstract void PrintInfoAbout(string message = "No message");
    }
}
