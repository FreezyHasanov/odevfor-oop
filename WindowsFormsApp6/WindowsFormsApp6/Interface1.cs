using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface IHuman
    {
        string dance(string file_location);
        string speak(string file_location);
    }
    interface IRavager
    {
        string speak(string file_location);
    }
    interface IOmnic
    {
        string speak(string file_location);
        string meditate(string file_location);
        string dance(string file_location);
    }
}
